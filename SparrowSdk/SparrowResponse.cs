using System;
using System.Collections.Generic;

namespace SparrowSdk
{
    public class SparrowResponse
    {
        public static SparrowResponse Create(Dictionary<string, string> values, Dictionary<string, string> request)
        {
            return new SparrowResponse()
            {
                RawRequest = request,

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

                RawResponse = values,
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

        public Dictionary<string, string> RawResponse { get; set; }
        public Dictionary<string, string> RawRequest { get; set; }
    }

    public static class Helpers
    {
        public static string GetStringOrEmpty(this Dictionary<string, string> values, string key)
        {
            if (values.TryGetValue(key, out string value))
            {
                return Uri.UnescapeDataString(value).Replace("+", " ");
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
                items.Add(Uri.UnescapeDataString(value).Replace("+", " "));
                i++;
            }

            return items;
        }

    }
}
