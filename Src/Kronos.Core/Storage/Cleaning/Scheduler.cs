﻿using System.Threading;
using Kronos.Core.Configuration;

namespace Kronos.Core.Storage.Cleaning
{
    internal class Scheduler : IScheduler
    {
        private Timer _timer;

        public void Register(TimerCallback callback, int period = Settings.CleanupTimeMs)
        {
            _timer = new Timer(callback, null, 0, period);
        }
    }
}
