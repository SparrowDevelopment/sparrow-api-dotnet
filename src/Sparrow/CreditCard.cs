using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow
{
    public class CreditCard: IPaymentType
    {
        public string CardNum { get; set; }
        public string CardExp { get; set; }
        public string CVV { get; set; }
    }
}
