using System;
using System.Collections.Generic;
using System.Text;

namespace Sparrow
{
    public enum EWalletType
    {
        PayPal,
    }
    public class EWallet: IPaymentType
    {
        public EWalletType Type { get; set; }
        public string Account { get; set; }
    }
}
