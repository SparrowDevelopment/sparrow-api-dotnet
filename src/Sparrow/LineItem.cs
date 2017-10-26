using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow
{
    public class LineItem
    {
        public string SkuNumber { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
    }
}
