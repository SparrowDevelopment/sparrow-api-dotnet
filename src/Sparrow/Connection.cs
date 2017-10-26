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

        public Response Sale(CreditCard card, string )
        {
            return new Response();
        }
    }
}
