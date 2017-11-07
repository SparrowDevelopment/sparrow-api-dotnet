using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SparrowSdk.Tests
{
    [TestClass]
    public partial class Tests
    {
        private static Sparrow _sparrow_badApiKey;
        private static Sparrow _sparrow_creditcard;
        private static Sparrow _sparrow_ach;
        private static Sparrow _sparrow_cash;
        private static Sparrow _sparrow_starcard;
        private static Sparrow _sparrow_ewallet;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _sparrow_badApiKey = new Sparrow("BAD_API_KEY");

            _sparrow_creditcard = new Sparrow("CUK5YODHVAZHFBM6KESZO1J4");
            _sparrow_ach = new Sparrow("RZOZ2AMMYF7GX2VF1L05WW1G");
            _sparrow_cash = new Sparrow("23QFJBN8KME0FCTGBEASMLAF");
            _sparrow_starcard = new Sparrow("PNk0xFNbn89ARFjA2Q1Q5tLVtoky5rrw");
            _sparrow_ewallet = new Sparrow("1W53QL0TJLIERXHIQKRXJRTK");
        }

        public TestContext TestContext { get; set; }

        [TestMethod]
        public async Task CreateSale_ExpectFail()
        {
            var result = await _sparrow_badApiKey.CreateSale_Example("4111111111111111", "1010", 9.95M, "999");

            // response=3&textresponse=Cannot+find+transaction+routing+info.+Check+the+value+of+payment+field+mkey&errorcode=

            Assert.AreEqual(result.Response, 3);
            Assert.AreEqual(result.TextResponse, "Cannot find transaction routing info. Check the value of payment field mkey");
            Assert.AreEqual(result.ErrorCode, 0);
        }

        [TestMethod]
        public async Task CreateSale()
        {
            var result = await _sparrow_creditcard.CreateSale_Example("4111111111111111", "1010", 9.95M, "999");

            // response=1&textresponse=SUCCESS&transid=10497689&xref=3779249270&authcode=123456&orderid=&type=sale&avsresponse=&cvvresponse=M&coderesponse=100&codedescription=Transaction+was+Approved&status=200

            Assert.AreEqual(result.Response, 1);
            Assert.AreEqual(result.TextResponse, "SUCCESS");
            Assert.IsTrue(!string.IsNullOrEmpty(result.TransId));
            Assert.IsTrue(!string.IsNullOrEmpty(result.XRef));
            Assert.AreEqual(result.AuthCode, "123456");
            Assert.AreEqual(result.OrderId, "");
            Assert.AreEqual(result.Type, "sale");
            Assert.AreEqual(result.AvsResponse, "");
            Assert.AreEqual(result.CvvResponse, "M");
            Assert.AreEqual(result.CodeResponse, 100);
            Assert.AreEqual(result.CodeDescription, "Transaction was Approved");
            Assert.AreEqual(result.Status, 200);
        }
       
    }
}
