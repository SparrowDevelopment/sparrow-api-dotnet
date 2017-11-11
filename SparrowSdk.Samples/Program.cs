using System;
using System.Linq;
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

            var allResponses = SparrowResponseSamples.AllResponses;
            var allResponses_text = allResponses.Select(x => x.Key).JoinStrings("\r\n");

            var unparsed = SparrowResponseSamples.AllUnparsed;
            var unparsed_properties = unparsed.Select(x => $"public string {x.Key} {{ get; set; }}").JoinStrings("\r\n");
            var unparsed_sets = unparsed.Select(x => $"{x.Key} = values.GetStringOrEmpty(\"{x.Key}\")").JoinStrings("\r\n");
        }
    }
}
