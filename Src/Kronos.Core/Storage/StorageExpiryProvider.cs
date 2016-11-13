﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NLog;

namespace Kronos.Core.Storage
{
    public class StorageExpiryProvider : IExpiryProvider
    {
        public static readonly int Timer = 1000;
        private int _runsWithoutGc;
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public void Start(ConcurrentDictionary<NodeMetatada, byte[]> nodes, CancellationToken token)
        {
            Task.Factory.StartNew(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    long ticks = DateTime.UtcNow.Ticks;
                    ulong deleted = 0;
                    foreach (KeyValuePair<NodeMetatada, byte[]> node in nodes)
                    {
                        if (node.Key.ExpiryDate.Ticks < ticks)
                        {
                            byte[] temp;
                            nodes.TryRemove(node.Key, out temp);

                            deleted++;
                        }
                    }
                    if (deleted > 0)
                    {
                        _logger.Info($"Deleted {deleted} elements from storage");
                    }

                    _runsWithoutGc++;
                    if (_runsWithoutGc >= 25)
                    {
                        _runsWithoutGc = 0;
                        FlushMemory();
                    }

                    await Task.Delay(Timer, token);
                }

            }, TaskCreationOptions.LongRunning);
        }

        private void FlushMemory()
        {
            long memory = GC.GetTotalMemory(true);
            _logger.Debug($"Memory was flushed. Current usage: {ConvertBytesToMegabytes(memory)}mb");
        }

        private static string ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f / 1024f).ToString("0.00");
        }
    }
}

