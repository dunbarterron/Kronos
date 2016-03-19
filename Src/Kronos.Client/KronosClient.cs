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
            RequestStatusCode status = request.Execute(_service, request);

            Trace.WriteLine($"InsertRequest status: {status}");
        }

        public byte[] TryGetValue(string key)
        {
            Trace.WriteLine("New get request");
            GetRequest request = new GetRequest(key);

            byte[] valueFromCache = request.Execute(_service, request);

            if (valueFromCache != null)
            {
                Trace.WriteLine($"GetRequest status returned object with {valueFromCache.Length} bytes");
            }
            else
            {
                Trace.WriteLine($"GetRequest status returned null");
            }

            return valueFromCache;
        }
    }
}
