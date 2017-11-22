using System;
using System.Threading.Tasks;
using SparrowSdk;

namespace SampleClient
{
    class Sample
    {
        private static Sparrow _sparrow = new Sparrow("SPARROW_API_KEY");

        public async Task CreateSparrowSale()
        {
            var result = await _sparrow.SimpleSale(new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21), Cvv = "123" }, 9.97m);

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
            var result = await _sparrow.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21), Cvv = "123" },
                amount: 9.97m);

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
