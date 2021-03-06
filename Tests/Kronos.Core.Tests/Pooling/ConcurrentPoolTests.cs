﻿using Kronos.Core.Pooling;

namespace Kronos.Core.Tests.Pooling
{
    public class ConcurrentPoolTests : PoolTests
    {
        protected override Pool<byte> Create(int count = 100)
        {
            return new ConcurrentPool<byte>(count);
        }
    }
}
