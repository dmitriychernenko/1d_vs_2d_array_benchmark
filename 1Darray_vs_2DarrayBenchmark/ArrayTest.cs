using System;
using BenchmarkDotNet.Attributes;

namespace _1Darray_vs_2DarrayBenchmark
{
    public class ArrayTest
    {
        private const int sizeI = 100;
        private const int sizeJ = 100;

        [Params(0, 25, 50, 75, 99)]
        public int I { get; set; }

        [Params(0, 25, 50, 75, 99)]
        public int J { get; set; }

        private byte[] firstArray;
        private byte[,] secondArray;


        public ArrayTest()
        {

            firstArray = new byte[sizeI * sizeJ];
            secondArray = new byte[sizeI, sizeJ];

            var random = new Random(125);

            random.NextBytes(firstArray);

            var counter = 0;
            for (var i = 0; i < sizeI; i++)
            {
                for (var j = 0; j < sizeJ; j++)
                {
                    secondArray[i, j] = firstArray[counter++];
                }
            }
        }

        [Benchmark]
        public byte FirstArray()
        {
            return firstArray[I * sizeJ + J];
        }

        [Benchmark]
        public byte SecondArray()
        {
            return secondArray[I, J];
        }
    }
}