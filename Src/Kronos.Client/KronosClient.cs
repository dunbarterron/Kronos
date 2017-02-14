﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Kronos.Client.Transfer;
using Kronos.Core.Configuration;
using Kronos.Core.Networking;
using Kronos.Core.Processing;
using Kronos.Core.Requests;
using Kronos.Core.Serialization;

namespace Kronos.Client
{
    /// <summary>
    /// Official Kronos client
    /// <see cref="IKronosClient" />
    /// </summary>
    internal class KronosClient : IKronosClient
    {
        private readonly InsertProcessor _insertProcessor = new InsertProcessor();
        private readonly GetProcessor _getProcessor = new GetProcessor();
        private readonly DeleteProcessor _deleteProcessor = new DeleteProcessor();
        private readonly CountProcessor _countProcessor = new CountProcessor();
        private readonly ContainsProcessor _containsProcessor = new ContainsProcessor();
        private readonly ClearProcessor _clearProcessor = new ClearProcessor();

        private readonly ServerProvider _serverProvider;
        private readonly Func<IPEndPoint, IConnection> _createConnection;

        public KronosClient(KronosConfig config) : this(config, endpoint => new Connection(endpoint))
        {
        }

        internal KronosClient(KronosConfig config, Func<IPEndPoint, IConnection> createConnection)
        {
            _serverProvider = new ServerProvider(config.ClusterConfig);
            _createConnection = createConnection;
        }

        public async Task InsertAsync(string key, byte[] package, DateTime expiryDate)
        {
            Debug.WriteLine("New insert request");
            InsertRequest request = new InsertRequest(key, package, expiryDate);

            IConnection connection = SelectServerAndCreateConnection(key);
            bool response = await _insertProcessor.ExecuteAsync(request, connection);

            Debug.WriteLine($"InsertRequest status: {response}");
        }

        public async Task<byte[]> GetAsync(string key)
        {
            Debug.WriteLine("New get request");
            GetRequest request = new GetRequest(key);

            IConnection connection = SelectServerAndCreateConnection(key);
            byte[] valueFromCache = await _getProcessor.ExecuteAsync(request, connection);

            byte[] notFoundBytes = SerializationUtils.Serialize(RequestStatusCode.NotFound);
            if (valueFromCache != null && valueFromCache.SequenceEqual(notFoundBytes))
                return null;

            return valueFromCache;
        }

        public async Task DeleteAsync(string key)
        {
            Debug.WriteLine("New delete request");
            DeleteRequest request = new DeleteRequest(key);
            IConnection connection = SelectServerAndCreateConnection(key);
            bool status = await _deleteProcessor.ExecuteAsync(request, connection);

            Debug.WriteLine($"InsertRequest status: {status}");
        }

        public async Task<int> CountAsync()
        {
            Debug.WriteLine("New count request");

            var request = new CountRequest();
            int[] results = await _countProcessor.ExecuteAsync(request, SelectAllServers());

            return results.Sum();
        }

        public async Task<bool> ContainsAsync(string key)
        {
            Debug.WriteLine("New contains request");

            var request = new ContainsRequest(key);

            IConnection connection = SelectServerAndCreateConnection(key);
            bool contains = await _containsProcessor.ExecuteAsync(request, connection);

            return contains;
        }

        public async Task ClearAsync()
        {
            Debug.WriteLine("New clear request");

            var request = new ClearRequest();
            await _clearProcessor.ExecuteAsync(request, SelectAllServers());
        }

        private IConnection SelectServerAndCreateConnection(string key)
        {
            ServerConfig server = _serverProvider.SelectServer(key.GetHashCode());
            Debug.WriteLine($"Selected server {server}");
            IConnection connection = _createConnection(server.EndPoint);
            return connection;
        }

        private IConnection[] SelectAllServers()
        {
            return _serverProvider.Servers.Select(x => _createConnection(x.EndPoint)).ToArray();
        }
    }
}

