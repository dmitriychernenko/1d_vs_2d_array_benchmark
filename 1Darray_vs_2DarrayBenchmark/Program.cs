using System;
using BenchmarkDotNet.Running;

namespace _1Darray_vs_2DarrayBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ArrayTest>();
            Console.WriteLine(summary);
        }
    }
}
