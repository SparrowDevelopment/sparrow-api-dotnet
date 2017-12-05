using System;
using System.Collections.Generic;
using System.Text;

namespace SparrowSdk.Samples
{
    partial class SampleGenerator
    {
        private static Sparrow _sparrow_badApiKey = new Sparrow("BAD_API_KEY");
        private static Sparrow _sparrow_creditcard = new Sparrow("CUK5YODHVAZHFBM6KESZO1J4");
        private static Sparrow _sparrow_ach = new Sparrow("RZOZ2AMMYF7GX2VF1L05WW1G");
        private static Sparrow _sparrow_cash = new Sparrow("23QFJBN8KME0FCTGBEASMLAF");
        private static Sparrow _sparrow_starcard = new Sparrow("PNk0xFNbn89ARFjA2Q1Q5tLVtoky5rrw");
        private static Sparrow _sparrow_ewallet = new Sparrow("1W53QL0TJLIERXHIQKRXJRTK");

        private StringBuilder _logger = new StringBuilder();

        public string Result
        {
            get
            {
                return _logger.ToString();
            }
        }

        private void Log(string text)
        {
            _logger.AppendLine(text);

            Console.WriteLine(text);
        }
    }
}
