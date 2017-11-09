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
    }
}
