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

                PaymentTokens = values.GetStringArray("paymenttoken"),

                ErrorCode = values.GetIntOrZero("errorcode"),

                Raw = values,
            };
        }

        public bool IsSuccess
        {
            get
            {
                return Status == 200 || TextResponse.ToUpper().Contains("SUCCESS");
            }
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

        public IList<string> PaymentTokens { get; set; }

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

        public static IList<string> GetStringArray(this Dictionary<string, string> values, string key)
        {
            var items = new List<string>();
            var i = 1;

            while (values.TryGetValue(key + "_" + i, out string value))
            {
                items.Add(value.Replace("+", " "));
                i++;
            }

            return items;
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
    }
}
