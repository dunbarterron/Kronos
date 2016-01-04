﻿using System;
using Kronos.Shared.Network.Codes;
using Kronos.Shared.Network.Model;

namespace Kronos.Client.Core
{
    /// <summary>
    /// DataContract for KronosClient
    /// </summary>
    public interface IKronosClient : IDisposable
    {
        /// <summary>
        /// Write object to Kronos server
        /// </summary>
        /// <param name="key">Package identifier</param>
        /// <param name="package">Package to save in the Kronos</param>
        /// <param name="expiryDate">Package Expiration date</param>
        /// <returns>Request status code</returns>
        RequestStatusCode InsertToServer(string key, byte[] package, DateTime expiryDate);

        /// <summary>
        /// Write object to Kronos server
        /// </summary>
        /// <param name="objectToCache">Object to serialize and save</param>
        /// <returns>Request status code</returns>
        RequestStatusCode InsertToServer(CachedObject objectToCache);
    }
}
