using System;
using System.Collections.Generic;
using System.Text;
using Sparrow;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public Response SimpleSale()
        {
            var connection = new Connection("");

            return connection.Sale(
                new CreditCard
                {
                    CardNum = "",
                    CardExp = "",
                    CVV = ""
                },
                amount: 2.99m);
        }
    }
}
