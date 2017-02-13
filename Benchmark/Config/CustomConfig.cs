﻿using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Order;

namespace Benchmark.Config
{
    [OrderProvider(SummaryOrderPolicy.FastestToSlowest)]
    public class CustomConfig : ManualConfig
    {
        public CustomConfig()
        {
            Add(MarkdownExporter.GitHub);
        }
    }
}
