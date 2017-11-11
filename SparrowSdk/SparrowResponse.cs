using System;
using System.Linq;
using System.Collections.Generic;

namespace SparrowSdk
{
    public class SparrowResponse
    {
        public static SparrowResponse Create(Dictionary<string, string> values, Dictionary<string, string> request)
        {
            var values_lower = values.ToDictionary(x => x.Key.ToLowerInvariant(), x => x.Value);

            return new SparrowResponse()
            {
                RawRequest = request,
                RawResponse = values,

                Status = values_lower.GetIntOrZero("status"),
                Response = values_lower.GetIntOrZero("response"),
                TextResponse = values_lower.GetStringOrEmpty("textresponse"),

                TransId = values_lower.GetStringOrEmpty("transid"),
                XRef = values_lower.GetStringOrEmpty("xref"),
                AuthCode = values_lower.GetStringOrEmpty("authcode"),
                OrderId = values_lower.GetStringOrEmpty("orderid"),
                Type = values_lower.GetStringOrEmpty("type"),
                AvsResponse = values_lower.GetStringOrEmpty("avsresponse"),
                CvvResponse = values_lower.GetStringOrEmpty("cvvresponse"),
                CodeResponse = values_lower.GetIntOrZero("coderesponse"),
                CodeDescription = values_lower.GetStringOrEmpty("codedescription"),

                CustomerToken = values_lower.GetStringOrEmpty("customertoken"),
                PlanToken = values_lower.GetStringOrEmpty("plantoken"),
                InvoiceNumber = values_lower.GetStringOrEmpty("invoicenumber"),
                AssignmentToken = values_lower.GetStringOrEmpty("assignmenttoken"),

                PaymentTokens = values_lower.GetStringArray("paymenttoken"),

                CustomerStatus = values.GetStringOrEmpty("CustomerStatus"),
                FirstName = values.GetStringOrEmpty("firstname"),
                LastName = values.GetStringOrEmpty("lastname"),
                PayType = values.GetStringOrEmpty("paytype"),
                PayNo = values.GetStringOrEmpty("payno"),
                CardExp = values.GetStringOrEmpty("cardexp"),
                Account = values.GetStringOrEmpty("account"),
                UseAccountUpdater = values.GetStringOrEmpty("useAccountUpdater"),
                Token = values.GetStringOrEmpty("token"),
                CustomField1 = values.GetStringOrEmpty("customField1"),
                InvoiceAmount = values.GetStringOrEmpty("invoiceamount"),
                Currency = values.GetStringOrEmpty("currency"),
                InvoiceDate = values.GetStringOrEmpty("invoicedate"),
                InvoiceStatus = values.GetStringOrEmpty("invoicestatus"),
                InvoicePaymentLink = values.GetStringOrEmpty("invoicepaymentlink"),
                OrigTransId = values.GetStringOrEmpty("origtransid"),
                OrigResponse = values.GetStringOrEmpty("origresponse"),
                OrigTextResponse = values.GetStringOrEmpty("origtextresponse"),

                ErrorCode = values_lower.GetIntOrZero("errorcode"),
            };
        }

        public bool IsSuccess
        {
            get
            {
                return Status == 200 || Response == 1 || TextResponse.ToUpper().Contains("SUCCESS");
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

        public string CustomerStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PayType { get; set; }
        public string PayNo { get; set; }
        public string CardExp { get; set; }
        public string Account { get; set; }
        public string UseAccountUpdater { get; set; }
        public string Token { get; set; }
        public string CustomField1 { get; set; }
        public string InvoiceAmount { get; set; }
        public string Currency { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceStatus { get; set; }
        public string InvoicePaymentLink { get; set; }

        public string OrigTransId { get; set; }
        public string OrigResponse { get; set; }
        public string OrigTextResponse { get; set; }


        public int ErrorCode { get; set; }

        public Dictionary<string, string> RawResponse { get; set; }
        public Dictionary<string, string> RawRequest { get; set; }
    }

    public static class Helpers
    {
        public static string GetStringOrEmpty(this Dictionary<string, string> values, string key)
        {
            if (values.TryGetValue(key.ToLowerInvariant(), out string value))
            {
                return Uri.UnescapeDataString(value).Replace("+", " ");
            }

            return "";
        }

        public static int GetIntOrZero(this Dictionary<string, string> values, string key)
        {
            if (values.TryGetValue(key.ToLowerInvariant(), out string value))
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

            while (values.TryGetValue(key.ToLowerInvariant() + "_" + i, out string value))
            {
                items.Add(Uri.UnescapeDataString(value).Replace("+", " "));
                i++;
            }

            return items;
        }

    }
}
