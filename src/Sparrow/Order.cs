using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow
{
    public class Order
    {
        public string OrderId { get; set; }
        public string OrderDescription { get; set; }
        public string PONumber { get; set; }

        public IEnumerable<LineItem> LineItems { get; set; } = new List<LineItem>();
    }
}
