using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sparrow
{
    public class Connection
    {
        private string _mKey;
        public Connection(string mKey)
        {
            _mKey = mKey;
        }

        public Response Sale(IPaymentType card, decimal amount, string currency = null, string paytype = null,
            Order order = null, string ipAddress = null, decimal? tax = null, decimal? shipAmount = null,
            Contact billingContact = null, Contact shippingContact = null, bool? saveClient = null, bool? updateClient = null)
        {
            return new Response();
        }
    }
}
