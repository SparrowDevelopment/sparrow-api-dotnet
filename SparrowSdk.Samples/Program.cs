using System;
using System.Threading.Tasks;

namespace SparrowSdk.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        static async Task Run()
        {
            var generator = new SampleGenerator();
            await generator.Generate();
            var result = generator.Result;

            var unparsed = SparrowResponseSamples.AllUnparsed;
        }
    }
}
