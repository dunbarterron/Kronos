﻿using System;
using System.Diagnostics;
using Kronos.Core.Command;
using Kronos.Core.Communication;
using Kronos.Core.Model;
using Kronos.Core.Requests;
using Kronos.Core.StatusCodes;

namespace Kronos.Client
{
    /// <summary>
    /// Official Kronos client
    /// <see cref="IKronosClient" />
    /// </summary>
    internal class KronosClient : IKronosClient
    {
        private readonly IClientServerConnection _service;

        public KronosClient(IClientServerConnection service)
        {
            _service = service;
        }

        public void InsertToServer(string key, byte[] package, DateTime expiryDate)
        {
            Trace.WriteLine("New insert request");
            InsertRequest request = new InsertRequest(key, package, expiryDate);

            InsertCommand command = new InsertCommand();
            RequestStatusCode status = command.Execute(_service, request);

            Trace.WriteLine($"InsertRequest status: {status}");
        }

        public byte[] TryGetValue(string key)
        {
            Trace.WriteLine("New get request");
            GetRequest request = new GetRequest(key);

            GetCommand command = new GetCommand();
            byte[] valueFromCache = command.Execute(_service, request);

            Trace.WriteLine($"GetRequest status returned object with {valueFromCache.Length} bytes");

            return valueFromCache;
        }
    }
}
