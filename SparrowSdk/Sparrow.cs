using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SparrowSdk
{
    // Docs at: http://foresight.sparrowone.com/

    public class SparrowReponse
    {
        public static SparrowReponse Create(Dictionary<string, string> values)
        {
            return new SparrowReponse()
            {
                Status = values.GetIntOrZero("status"),
                Response = values.GetIntOrZero("response"),
                TextResponse = values.GetStringOrEmpty("textresponse"),
                TransId = values.GetStringOrEmpty("transid"),
                XRef = values.GetStringOrEmpty("xref"),
                AuthCode = values.GetStringOrEmpty("authcode"),
                OrderId = values.GetStringOrEmpty("orderid"),
                Type = values.GetStringOrEmpty("type"),
                AvsResponse = values.GetStringOrEmpty("avsresponse"),
                CvvResponse = values.GetStringOrEmpty("cvvresponse"),
                CodeResponse = values.GetIntOrZero("coderesponse"),
                CodeDescription = values.GetStringOrEmpty("codedescription"),

                CustomerToken = values.GetStringOrEmpty("customertoken"),
                PlanToken = values.GetStringOrEmpty("plantoken"),
                InvoiceNumber = values.GetStringOrEmpty("invoicenumber"),
                AssignmentToken = values.GetStringOrEmpty("assignmenttoken"),

                ErrorCode = values.GetIntOrZero("errorcode"),

                Raw = values,
            };
        }

        public int Status { get; set; }
        public int Response { get; set; }
        public string TextResponse { get; set; }
        public string TransId { get; set; }
        public string XRef { get; set; }
        public string AuthCode { get; set; }
        public string OrderId { get; set; }
        public string Type { get; set; }
        public string AvsResponse { get; set; }
        public string CvvResponse { get; set; }
        public int CodeResponse { get; set; }
        public string CodeDescription { get; set; }

        public string CustomerToken { get; set; }
        public string PlanToken { get; set; }
        public string InvoiceNumber { get; set; }
        public string AssignmentToken { get; set; }

        public int ErrorCode { get; set; }

        public Dictionary<string, string> Raw { get; set; }

        public override string ToString()
        {
            return Raw.Aggregate(new System.Text.StringBuilder(), (sb, x) => sb.AppendLine(x.Key + " = " + x.Value + " ")).ToString();
        }
    }

    public static class Helpers
    {
        public static string GetStringOrEmpty(this Dictionary<string, string> values, string key)
        {
            if (values.TryGetValue(key, out string value))
            {
                return value.Replace("+", " ");
            }

            return "";
        }

        public static int GetIntOrZero(this Dictionary<string, string> values, string key)
        {
            if (values.TryGetValue(key, out string value))
            {
                if (int.TryParse(value, out int v))
                {
                    return v;
                }
            }

            return 0;
        }
    }

    public partial class Sparrow
    {
        private const string _url = "https://secure.sparrowone.com/Payments/Services_api.aspx";

        private HttpClient _client;
        private string _apiKey;

        public Sparrow(string apiKey, HttpClient client = null)
        {
            _apiKey = apiKey;
            _client = client ?? new HttpClient();
        }

        private async Task<Dictionary<string, string>> MakeRequest(Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            var response = await _client.PostAsync(_url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            var responseValues = ParseResponse(responseString);

            return responseValues;
        }

        private Dictionary<string, string> ParseResponse(string responseString)
        {
            var parts = responseString.Split('&');
            var values = parts.Select(p =>
            {
                var keyValue = p.Split('=');
                var key = keyValue[0];
                var value = keyValue[1];
                return new
                {
                    key,
                    value
                };
            }).ToDictionary(x => x.key, x => x.value);

            return values;
        }

        public async Task<SparrowReponse> CreateSale_Example(string cardnum, string cardexp, decimal amount, string cvv)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardnum },
                { "cardexp", cardexp },
                { "amount", amount.ToString("f2") },
                { "cvv", cvv },
            };

            var responseValues = await MakeRequest(data);
            return SparrowReponse.Create(responseValues);
        }


        // Example with Array


        public class Product_Example
        {
            /// <summary>
            /// SKU number of the product being purchased (skunumber_1, skunumber_2, etc) (skunumber_#)
            /// </summary>
            public string SkuNumber { get; set; } = "";
            public string Description { get; set; } = "";
            public string Amount { get; set; } = "";
            public string Quantity { get; set; } = "";
        }


        /// <param name="lastName">Billing last name</param>,
        /// <param name="skuNumberArray">SKU number of the product being purchased (skunumber_1, skunumber_2, etc) (skunumber_#)</param>,
        /// <param name="descriptionArray">Description of the product being purchased (description_#)</param>,
        /// <param name="amountArray">Price of the single unit of a product being purchased (amount_#)</param>,
        /// <param name="quantityArray">Number of units of a product being purchased (quantity_#)</param>,
        /// <param name="orderDesc">Order Description</param>,
        public async Task<SparrowReponse> AdvancedSale_Example(
            string cardNum, string cardExp, decimal amount, string cvv = "", decimal? currency = null, string firstName = "", string lastName = "",
            IList<Product_Example> products = null,
            string orderDesc = "", string orderId = "", string cardIpAddress = "", decimal? tax = null, decimal? shipAmount = null, string poNumber = "",
            string company = "", string address1 = "", string address2 = "", string city = "", string state = "", string zip = "", string groupId = "",
            string phone = "", string fax = "", string email = "", string shipFirstName = "", string shipLastName = "", string shipCompany = "", string shipAddress1 = "", string shipAddress2 = "",
            string shipCity = "", string shipState = "", string shipZip = "", string shipCountry = "", string shipPhone = "", string shipEmail = "",
            decimal[] optAmountValueArray = null, string[] optAmountPercentageArray = null,
            bool? sendTransReceiptToBillEmail = null, bool? sendTransReceiptToShipEmail = null, string sendTransReceiptToEmails = "", string token = "",
            bool? saveClient = null, bool? updateClient = null, string country = "")
        {
            var data = new Dictionary<string, string>
            {
                { "currency", currency != null ? currency.Value.ToString("f2") : "" },
                { "firstname", firstName },
                { "lastname", lastName },
                //{ "skunumber", skuNumberArray },
                //{ "description", descriptionArray },
                //{ "amount", amountArray },
                //{ "quantity", quantityArray },
                { "orderdesc", orderDesc },
                { "orderid", orderId },
                { "cardipaddress", cardIpAddress },

            };

            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    var x = products[i];
                    data.Add("skunumber" + i, x.SkuNumber);
                    data.Add("description" + i, x.Description);
                    data.Add("amount" + i, x.Amount);
                    data.Add("quantity" + i, x.Quantity);
                }
            }


            var responseValues = await MakeRequest(data);
            return SparrowReponse.Create(responseValues);
        }
    }
}
