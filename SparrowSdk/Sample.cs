using System.Threading.Tasks;
using SparrowSdk;

namespace SampleClient
{
    class Sample
    {
        private static Sparrow _sparrow = new Sparrow("SPARROW_API_KEY");

        public async Task CreateSparrowSale()
        {
            var result = await _sparrow.SimpleSale("4111111111111111", "01/18", 9.97m, "123");

            if (result.IsSuccess)
            {
                var transactionId = result.TransId;

                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }
        }

        public async Task CreateSparrowSale_WithNamedArguments()
        {
            var result = await _sparrow.SimpleSale(cardNum: "4111111111111111", cardExp: "01/18", amount: 9.97m, cvv: "123");

            if (result.IsSuccess)
            {
                var transactionId = result.TransId;

                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }
        }

    }
}
