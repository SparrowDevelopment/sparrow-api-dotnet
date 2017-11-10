using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparrowSdk
{
    public partial class Sparrow
    {

        /// <summary>
        /// Simple Sale
        /// </summary>
        /// <param name="transType">sale = Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0711 = 7/2011) (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="cvv">Card security code</param>
        public async Task<SparrowResponse> SimpleSale(string cardNum, string cardExp, decimal amount, string cvv = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") },
                { "cvv", cvv }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AdvancedSaleOptions
        {
            /// <summary>
            /// card security code
            /// </summary>
            public string Cvv { get; set; } = "";
            /// <summary>
            /// Order Description
            /// </summary>
            public string OrderDesc { get; set; } = "";
            /// <summary>
            /// Order ID
            /// </summary>
            public string OrderId { get; set; } = "";
            /// <summary>
            /// IP address of the customer, can be used for fraud prevention in FBI Tools
            /// </summary>
            public string CardIpAddress { get; set; } = "";
            /// <summary>
            /// Total tax amount
            /// </summary>
            public decimal? Tax { get; set; } = null;
            /// <summary>
            /// Original Purchase Order
            /// </summary>
            public string PoNumber { get; set; } = "";
            /// <summary>
            /// Send multiple transaction receipts to customers. Multiple email must be separated by commas.
            /// </summary>
            public string SendTransReceiptToEmails { get; set; } = "";
            /// <summary>
            /// Customer or customer payment info unique identifier.
            /// </summary>
            public string Token { get; set; } = "";
            /// <summary>
            /// If parameter 'saveclient' = true and the customer is identified as new, then a new Data Vault client will be created with payment/contact info from the transaction data and DV token will be generated. The payment transaction will be assigned to this new DV client.
            /// </summary>
            public bool? SaveClient { get; set; } = null;
            /// <summary>
            /// If the parameter 'updateclient' = true and the DataVault finds the client according to customer identification rules, then the payment transaction will be assigned to the DataVault client and the DataVault client payment/contact info will be updated according to the transaction's data.
            /// </summary>
            public bool? UpdateClient { get; set; } = null;
            /// <summary>
            /// Group ID of the Split Funding group. If groupid is defined for the transaction system splits it in accordance with group settings.
            /// </summary>
            public string GroupId { get; set; } = "";
        }

        public class AdvancedSaleOptionalAmount
        {
            /// <summary>
            /// Value of additional amount (e.g. 1.00)
            /// </summary>
            public decimal? OptAmountValue { get; set; } = null;
            /// <summary>
            /// Percentage of additional amount (e.g. 10)
            /// </summary>
            public string OptAmountPercentage { get; set; } = "";
        }

        public class AdvancedSaleShipping
        {
            /// <summary>
            /// Total shipping amount
            /// </summary>
            public decimal? ShipAmount { get; set; } = null;
            /// <summary>
            /// Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Shipping Address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping Address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping City
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping State
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping Zip Code
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping Country, ie US
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping Phone Number
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping Email
            /// </summary>
            public string ShipEmail { get; set; } = "";
            /// <summary>
            /// If true receipt will be sent to email from Shipping Information if email is specified
            /// </summary>
            public bool? SendTransReceiptToShipEmail { get; set; } = null;
        }

        public class AdvancedSaleBilling
        {
            /// <summary>
            /// Billing first name
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing address
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address2
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing Country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone number
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing fax number
            /// </summary>
            public string Fax { get; set; } = "";
            /// <summary>
            /// Billing Email Address
            /// </summary>
            public string Email { get; set; } = "";
            /// <summary>
            /// If true receipt will be sent to email from Billing Information if email is specified
            /// </summary>
            public bool? SendTransReceiptToBillEmail { get; set; } = null;
            /// <summary>
            /// Code of the payment currency. If currency is not specified, the default currency (USD) is assumed.
            /// </summary>
            public string Currency { get; set; } = "";
        }

        public class AdvancedSaleProduct
        {
            /// <summary>
            /// SKU number of the product being purchased (skunumber_1, skunumber_2, etc)
            /// </summary>
            public string SkuNumber { get; set; } = "";
            /// <summary>
            /// Description of the product being purchased
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// Price of the single unit of a product being purchased
            /// </summary>
            public decimal? Amount { get; set; } = null;
            /// <summary>
            /// Number of units of a product being purchased
            /// </summary>
            public int? Quantity { get; set; } = null;
        }

        /// <summary>
        /// Advanced Sale
        /// </summary>
        /// <param name="transType">Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0719 = 7/2019 (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="options">AdvancedSaleOptions</param>,
        /// <param name="optionalAmounts">AdvancedSaleOptionalAmount</param>,
        /// <param name="shipping">AdvancedSaleShipping</param>,
        /// <param name="billing">AdvancedSaleBilling</param>,
        /// <param name="products">AdvancedSaleProduct</param>
        public async Task<SparrowResponse> AdvancedSale(string cardNum, string cardExp, decimal amount, AdvancedSaleOptions options = null, IList<AdvancedSaleOptionalAmount> optionalAmounts = null, AdvancedSaleShipping shipping = null, AdvancedSaleBilling billing = null, IList<AdvancedSaleProduct> products = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") }
            };


            if (options != null)
            {
                var x = options;
                data.Add("cvv", x.Cvv);
                data.Add("orderdesc", x.OrderDesc);
                data.Add("orderid", x.OrderId);
                data.Add("cardipaddress", x.CardIpAddress);
                data.Add("tax", x.Tax?.ToString("f2") ?? "");
                data.Add("ponumber", x.PoNumber);
                data.Add("sendtransreceipttoemails", x.SendTransReceiptToEmails);
                data.Add("token", x.Token);
                data.Add("saveclient", x.SaveClient == true ? "true" : "false");
                data.Add("updateclient", x.UpdateClient == true ? "true" : "false");
                data.Add("groupid", x.GroupId);
            }

            if (optionalAmounts != null)
            {
                for (int i = 0; i < optionalAmounts.Count; i++)
                {
                    var x = optionalAmounts[i];
                    data.Add("opt_amount_type_" + (i + 1), "tip");
                    data.Add("opt_amount_value_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("opt_amount_percentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipamount", x.ShipAmount?.ToString("f2") ?? "");
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
                data.Add("sendtransreceipttoshippemail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("company", x.Company);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("phone", x.Phone);
                data.Add("fax", x.Fax);
                data.Add("email", x.Email);
                data.Add("sendtransreceipttobillemail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("currency", x.Currency);
            }

            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    var x = products[i];
                    data.Add("skunumber_" + (i + 1), x.SkuNumber);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("amount_" + (i + 1), x.Amount?.ToString("f2") ?? "");
                    data.Add("quantity_" + (i + 1), "" + x.Quantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Authorization: Authorization transactions are processed immediately but are not flagged for settlement. This process will verify funds availability and hold them until capture (3-7 days). In order to settle an open auth, a subsequent capture must be made. An authorization may have all of the same fields as a Sale transaction, but with transtype=auth
        /// </summary>
        /// <param name="transType">Authorization = Transaction Auth (Format: auth)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0711 = 7/2011) (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="cvv">Card security code</param>
        public async Task<SparrowResponse> SimpleAuthorization(string cardNum, string cardExp, decimal amount, string cvv = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "auth" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") },
                { "cvv", cvv }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class SimpleCaptureOptions
        {
            /// <summary>
            /// Additional list of emails to receive receipts
            /// </summary>
            public string SendTransReceiptToEmails { get; set; } = "";
            /// <summary>
            /// If true receipt will be sent to email from Shipping Information if email is specified
            /// </summary>
            public bool? SendTransReceiptToShipEmail { get; set; } = null;
            /// <summary>
            /// If true receipt will be sent to email from Billing Information if email is specified
            /// </summary>
            public bool? SendTransReceiptToBillEmail { get; set; } = null;
        }

        /// <summary>
        /// Simple Capture: Capture transactions flag existing authorizations for settlement. Only authorizations can be captured. Captures can be submitted for an amount equal to or less than the original authorization amount. *In order to capture an amount that is higher than the original auth, please contact support to make sure that the correct settings have been enabled for your account.
        /// </summary>
        /// <param name="transType">Capture = Transaction Capture (Format: capture)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original Payment Gateway Transaction ID</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="options">SimpleCaptureOptions</param>
        public async Task<SparrowResponse> SimpleCapture(string transId, decimal amount, SimpleCaptureOptions options = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "capture" },
                { "mkey", _apiKey },
                { "transid", transId },
                { "amount", amount.ToString("f2") }
            };


            if (options != null)
            {
                var x = options;
                data.Add("sendtransreceipttoemails", x.SendTransReceiptToEmails);
                data.Add("sendtransreceipttoshipemail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
                data.Add("sendtransreceipttobillemail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Offline Capture
        /// </summary>
        /// <param name="transType">Offline Capture closes an open authorization which was manually obtained from the card issuer (Format: offline)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0711 = 7/2011) (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="authCode">Auth code received from the issuer (Format: string)</param>,
        /// <param name="authDate">Date that auth code was obtained, required for Chase only (Format: MM/DD/YYYY)</param>,
        /// <param name="cvv">Card security code</param>
        public async Task<SparrowResponse> SimpleOfflineCapture(string cardNum, string cardExp, decimal amount, string authCode, string authDate, string cvv = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "offline" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") },
                { "authcode", authCode },
                { "authdate", authDate },
                { "cvv", cvv }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Refund
        /// </summary>
        /// <param name="transType">Refund (Format: refund)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="amount">Total amount to be refunded (Format: d.dd)</param>
        public async Task<SparrowResponse> SimpleRefund(string transId, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "refund" },
                { "mkey", _apiKey },
                { "transid", transId },
                { "amount", amount.ToString("f2") }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AdvancedRefundOptions
        {
            /// <summary>
            /// Send multiple transaction receipts to customers. Multiple email must be separated by commas.
            /// </summary>
            public string SendTransReceiptToEmails { get; set; } = "";
            /// <summary>
            /// If true a receipt will be sent to the email provided in the shipping information if email is specified
            /// </summary>
            public bool? SendTransReceiptToShipEmail { get; set; } = null;
            /// <summary>
            /// If true a receipt will be sent to the email provided in the billing information if email is specified
            /// </summary>
            public bool? SendTransReceiptToBillEmail { get; set; } = null;
        }

        public class AdvancedRefundOptionalAmount
        {
            /// <summary>
            /// Type of additional amount
            /// </summary>
            public string OptAmountType { get; set; } = "";
            /// <summary>
            /// Value of additional amount (1.00)
            /// </summary>
            public string OptAmountValue { get; set; } = "";
        }

        /// <summary>
        /// Advanced Refund
        /// </summary>
        /// <param name="transType">Refund (Format: refund)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="amount">Total amount to be refunded (Format: d.dd)</param>,
        /// <param name="options">AdvancedRefundOptions</param>,
        /// <param name="optionalAmounts">AdvancedRefundOptionalAmount</param>
        public async Task<SparrowResponse> AdvancedRefund(string transId, decimal amount, AdvancedRefundOptions options = null, IList<AdvancedRefundOptionalAmount> optionalAmounts = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "refund" },
                { "mkey", _apiKey },
                { "transid", transId },
                { "amount", amount.ToString("f2") }
            };


            if (options != null)
            {
                var x = options;
                data.Add("sendtransreceipttoemails", x.SendTransReceiptToEmails);
                data.Add("sendtransreceipttoshipemail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
                data.Add("sendtransreceipttobillemail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
            }

            if (optionalAmounts != null)
            {
                for (int i = 0; i < optionalAmounts.Count; i++)
                {
                    var x = optionalAmounts[i];
                    data.Add("opt_amount_type_" + (i + 1), x.OptAmountType);
                    data.Add("opt_amount_value_" + (i + 1), x.OptAmountValue);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Void
        /// </summary>
        /// <param name="transType">Void (Format: void)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>
        public async Task<SparrowResponse> SimpleVoid(string transId)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "void" },
                { "mkey", _apiKey },
                { "transid", transId }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AdvancedVoidOptions
        {
            /// <summary>
            /// Send multiple transaction receipts to customers. Multiple email must be separated by commas.
            /// </summary>
            public string SendTransReceiptToEmails { get; set; } = "";
            /// <summary>
            /// If true a receipt will be sent to the email provided in the shipping information if email is specified
            /// </summary>
            public bool? SendTransReceiptToShipEmail { get; set; } = null;
            /// <summary>
            /// If true a receipt will be sent to the email provided in the billing information if email is specified
            /// </summary>
            public bool? SendTransReceiptToBillEmail { get; set; } = null;
        }

        /// <summary>
        /// Advanced Void
        /// </summary>
        /// <param name="transType">Void (Format: void)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="options">AdvancedVoidOptions</param>
        public async Task<SparrowResponse> AdvancedVoid(string transId, AdvancedVoidOptions options = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "void" },
                { "mkey", _apiKey },
                { "transid", transId }
            };


            if (options != null)
            {
                var x = options;
                data.Add("sendtransreceipttoemails", x.SendTransReceiptToEmails);
                data.Add("sendtransreceipttoshipemail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
                data.Add("sendtransreceipttobillemail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class PassengerSaleOptions
        {
            /// <summary>
            /// Card security code
            /// </summary>
            public string Cvv { get; set; } = "";
            /// <summary>
            /// 
            /// </summary>
            public string StopOverCode { get; set; } = "";
            /// <summary>
            /// Codes for different trip legs, 3 characters
            /// </summary>
            public string AirportCodeLeg { get; set; } = "";
            /// <summary>
            /// 2 characters
            /// </summary>
            public string CarrierCoupon { get; set; } = "";
            /// <summary>
            /// 1 or 2 characters
            /// </summary>
            public string ClassOfServiceCoupon { get; set; } = "";
            /// <summary>
            /// 1 character
            /// </summary>
            public string AddressVerificationCode { get; set; } = "";
            /// <summary>
            /// The field must be forwarded when sent from TSYS, or manually filled with zeros. 15 characters
            /// </summary>
            public string TransactionId { get; set; } = "";
            /// <summary>
            /// 12 characters
            /// </summary>
            public string ReferenceNumber { get; set; } = "";
        }

        /// <summary>
        /// Passenger Sale
        /// </summary>
        /// <param name="transType">Transaction Sale (Format: passengersale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0719 = 7/2019 (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="passengerName">First and last name of the passenger, 1-20 characters (Format: [a-z, A-Z, 0-9, ‘ ’])</param>,
        /// <param name="airportCodeStart">Origination Airport Code, 3 characters (airportcode1 Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="airlineCodeNumber">3 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="ticketNumber">10 characters (Format: [0-9])</param>,
        /// <param name="flightDateCoupon">Departure date (flightdatecoupon1 Format: MM/DD/YYYY)</param>,
        /// <param name="flightDepartureTimeCoupon">Departure time (flightdeparturetimecoupon1 Format: HH:mm (military))</param>,
        /// <param name="approvalCode">6 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="authCharIndicator">Used as Returned Authorization Characteristics Indicator. Must contain the value returned in authorization response (ic case of online auth) (Format: [ |A|E|F|I|C|K|M|N|P|R|S|T|U|V|W])</param>,
        /// <param name="validationCode">4 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="authResponseCode">2 characters (Format: [a-zA-Z0-9 ] or two spaces)</param>,
        /// <param name="options">PassengerSaleOptions</param>
        public async Task<SparrowResponse> PassengerSale(string cardNum, string cardExp, decimal amount, string passengerName, string airportCodeStart, string airlineCodeNumber, string ticketNumber, string flightDateCoupon, string flightDepartureTimeCoupon, string approvalCode, string authCharIndicator, string validationCode, string authResponseCode, PassengerSaleOptions options = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "passengersale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") },
                { "passengername", passengerName },
                { "airportcode1", airportCodeStart },
                { "airlinecodenumber", airlineCodeNumber },
                { "ticketnumber", ticketNumber },
                { "flightdatecoupon", flightDateCoupon },
                { "flightdeparturetimecoupon", flightDepartureTimeCoupon },
                { "approvalcode", approvalCode },
                { "authcharindicator", authCharIndicator },
                { "validationcode", validationCode },
                { "authresponsecode", authResponseCode }
            };


            if (options != null)
            {
                var x = options;
                data.Add("cvv", x.Cvv);
                data.Add("stopovercode", x.StopOverCode);
                data.Add("airportcode2", x.AirportCodeLeg);
                data.Add("carriercoupon", x.CarrierCoupon);
                data.Add("classofservicecoupon", x.ClassOfServiceCoupon);
                data.Add("addressverificationcode", x.AddressVerificationCode);
                data.Add("transactionid", x.TransactionId);
                data.Add("referencenumber", x.ReferenceNumber);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Star Card
        /// </summary>
        /// <param name="transType">Transaction sale (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Card number</param>,
        /// <param name="amount">Total amount to be refunded (Format: d.dd)</param>,
        /// <param name="CID">11 digit numerical code (CID Format: Custom Field)</param>
        public async Task<SparrowResponse> SimpleStarCard(string cardNum, decimal amount, string CID)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "amount", amount.ToString("f2") },
                { "CID", CID }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AdvancedStarCardOptions
        {
            /// <summary>
            /// Order Description
            /// </summary>
            public string OrderDesc { get; set; } = "";
            /// <summary>
            /// Order ID
            /// </summary>
            public string OrderId { get; set; } = "";
            /// <summary>
            /// IP address of the customer, can be used for fraud prevention in FBI Tools
            /// </summary>
            public string CardIpAddress { get; set; } = "";
            /// <summary>
            /// Total tax amount
            /// </summary>
            public decimal? Tax { get; set; } = null;
            /// <summary>
            /// Original Purchase Order
            /// </summary>
            public string PoNumber { get; set; } = "";
        }

        public class AdvancedStarCardShipping
        {
            /// <summary>
            /// Total shipping amount
            /// </summary>
            public decimal? ShipAmount { get; set; } = null;
            /// <summary>
            /// Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Shipping Address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping Address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping City
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping State
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping Zip Code
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping Country, ie US
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping Phone Number
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping Email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        public class AdvancedStarCardBilling
        {
            /// <summary>
            /// Billing first name
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing address
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address2
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing Country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone number
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing fax number
            /// </summary>
            public string Fax { get; set; } = "";
            /// <summary>
            /// Billing Email Address
            /// </summary>
            public string Email { get; set; } = "";
            /// <summary>
            /// Code of the payment currency. If currency is not specified, the default currency (USD) is assumed.
            /// </summary>
            public string Currency { get; set; } = "";
        }

        public class AdvancedStarCardProduct
        {
            /// <summary>
            /// SKU number of the product being purchased (skunumber_1, skunumber_2, etc)
            /// </summary>
            public string SkuNumber { get; set; } = "";
            /// <summary>
            /// Description of the product being purchased
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// Price of the single unit of a product being purchased
            /// </summary>
            public decimal? Amount { get; set; } = null;
            /// <summary>
            /// Number of units of a product being purchased
            /// </summary>
            public int? Quantity { get; set; } = null;
        }

        /// <summary>
        /// Advanced Star Card
        /// </summary>
        /// <param name="transType">Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0719 = 7/2019 (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="CID">11 digit numerical code (CID Format: custom field)</param>,
        /// <param name="options">AdvancedStarCardOptions</param>,
        /// <param name="shipping">AdvancedStarCardShipping</param>,
        /// <param name="billing">AdvancedStarCardBilling</param>,
        /// <param name="products">AdvancedStarCardProduct</param>
        public async Task<SparrowResponse> AdvancedStarCard(string cardNum, string cardExp, decimal amount, string CID, AdvancedStarCardOptions options = null, AdvancedStarCardShipping shipping = null, AdvancedStarCardBilling billing = null, IList<AdvancedStarCardProduct> products = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") },
                { "CID", CID }
            };


            if (options != null)
            {
                var x = options;
                data.Add("orderdesc", x.OrderDesc);
                data.Add("orderid", x.OrderId);
                data.Add("cardipaddress", x.CardIpAddress);
                data.Add("tax", x.Tax?.ToString("f2") ?? "");
                data.Add("ponumber", x.PoNumber);
            }

            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipamount", x.ShipAmount?.ToString("f2") ?? "");
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("company", x.Company);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("phone", x.Phone);
                data.Add("fax", x.Fax);
                data.Add("email", x.Email);
                data.Add("currency", x.Currency);
            }

            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    var x = products[i];
                    data.Add("skunumber_" + (i + 1), x.SkuNumber);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("amount_" + (i + 1), x.Amount?.ToString("f2") ?? "");
                    data.Add("quantity_" + (i + 1), "" + x.Quantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple ACH
        /// </summary>
        /// <param name="transType">sale- transaction sale, refund- transaction refund, credit- transaction credit (Format: [sale|refund|credit])</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="bankName">Customers bank name</param>,
        /// <param name="routing">Customers bank routing number</param>,
        /// <param name="account">Customers bank account number</param>,
        /// <param name="achAccountType">Customers type of bank account (Format: [checking|savings])</param>,
        /// <param name="achAccountSubType">Customers type of bank account (Format: [business|personal])</param>,
        /// <param name="amount">Total amount to be charged (Format: d.dd)</param>,
        /// <param name="firstName">Customer's first name</param>,
        /// <param name="lastName">Customer's last name</param>,
        /// <param name="company">Billing Company</param>
        public async Task<SparrowResponse> SimpleACH(string transType, string bankName, string routing, string account, string achAccountType, string achAccountSubType, decimal amount, string firstName, string lastName, string company = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", transType },
                { "mkey", _apiKey },
                { "bankname", bankName },
                { "routing", routing },
                { "account", account },
                { "achaccounttype", achAccountType },
                { "achaccountsubtype", achAccountSubType },
                { "amount", amount.ToString("f2") },
                { "firstname", firstName },
                { "lastname", lastName },
                { "company", company }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AdvancedACHOptions
        {
            /// <summary>
            /// Order Description
            /// </summary>
            public string OrderDesc { get; set; } = "";
            /// <summary>
            /// Order ID
            /// </summary>
            public string OrderId { get; set; } = "";
            /// <summary>
            /// If parameter 'saveclient' = true and the customer is identified as new, then a new Data Vault client will be created with payment/contact info from the transaction data and DV token will be generated. The payment transaction will be assigned to this new DV client.
            /// </summary>
            public bool? SaveClient { get; set; } = null;
            /// <summary>
            /// If the parameter 'updateclient' = true and the DataVault finds the client according to customer identification rules, then the payment transaction will be assigned to the DataVault client and the DataVault client payment/contact info will be updated according to the transaction's data.
            /// </summary>
            public string UpdateClient { get; set; } = "";
            /// <summary>
            /// Birthdate of the customer
            /// </summary>
            public string BirthDate { get; set; } = "";
            /// <summary>
            /// Check number. 1-15 alphanumeric characters
            /// </summary>
            public string CheckNumber { get; set; } = "";
            /// <summary>
            /// Drivers license number, 1-50 alphanumeric characters
            /// </summary>
            public string DriverLicenseNumber { get; set; } = "";
            /// <summary>
            /// Drivers license country
            /// </summary>
            public string DriverLicenseCountry { get; set; } = "";
            /// <summary>
            /// Drivers license state
            /// </summary>
            public string DriverLicenseState { get; set; } = "";
            /// <summary>
            /// This field is optional only for GETI ACH, for other processors can be ignored. From 1 to 50 characters.
            /// </summary>
            public string CourtesyCardId { get; set; } = "";
            /// <summary>
            /// Send multiple transaction receipts to customers. Multiple email must be separated by commas.
            /// </summary>
            public string SendTransReceiptToEmails { get; set; } = "";
        }

        public class AdvancedACHOptionalAmount
        {
            /// <summary>
            /// Type of additional amount (Tip)
            /// </summary>
            public string OptAmountType { get; set; } = "";
            /// <summary>
            /// Value of the additional amount (10.00)
            /// </summary>
            public decimal? OptAmountValue { get; set; } = null;
            /// <summary>
            /// Percentage of additional amount (20)
            /// </summary>
            public string OptAmountPercentage { get; set; } = "";
        }

        public class AdvancedACHShipping
        {
            /// <summary>
            /// Shipping first name, should be from 1-100 characters. Required for PayPal processor if shipping address is entered.
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name, should be from 1-100 characters. Required for PayPal processor if shipping address is entered.
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Shipping address. Should be from 1-200 alpha-numeric characters and can include # - : ;
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping address - line 2. Should be from 1-200 alpha-numeric characters and can include # - : ;
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping city, should be 1-50 alpha characters
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping state, 2 character abbreviation
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping postal code. If the country is US the zip code format must be: [5 digits: XXXXX] or [9 digits XXXXX-XXXX]
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping country (ie. US)
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping phone number, 10 digits
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping email
            /// </summary>
            public string ShipEmail { get; set; } = "";
            /// <summary>
            /// If true, this will send a transaction receipt to the shipping email if present
            /// </summary>
            public bool? SendTransReceiptToShipEmail { get; set; } = null;
        }

        public class AdvancedACHBilling
        {
            /// <summary>
            /// Billing first name, should be from 1-100 characters
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name, should be from 1-100 characters
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing Company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing address. Should be from 1-200 alpha-numeric characters and can include # - : ;
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address - line 2. Should be from 1-200 alpha-numeric characters and can include # - : ;
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city, should be 1-50 alpha characters
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state (2 character abbreviation)
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone number, 10 digits
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing email address
            /// </summary>
            public string Email { get; set; } = "";
            /// <summary>
            /// If true, this will send a transaction receipt to the billing email if present
            /// </summary>
            public bool? SendTransReceiptToBillEmail { get; set; } = null;
        }

        /// <summary>
        /// Advanced ACH
        /// </summary>
        /// <param name="transType">sale- transaction sale, refund- transaction refund, credit- transaction credit (Format: [sale|refund|credit])</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="bankName">Customers bank name</param>,
        /// <param name="routing">Customers bank routing number</param>,
        /// <param name="account">Customers bank account number</param>,
        /// <param name="achAccountType">Customers type of bank account (Format: [checking|savings])</param>,
        /// <param name="achAccountSubType">Customers type of bank account (Format: [business|personal])</param>,
        /// <param name="amount">Total amount to be charged (Format: d.dd)</param>,
        /// <param name="firstName">Customer's first name</param>,
        /// <param name="lastName">Customer's last name</param>,
        /// <param name="options">AdvancedACHOptions</param>,
        /// <param name="optionalAmounts">AdvancedACHOptionalAmount</param>,
        /// <param name="shipping">AdvancedACHShipping</param>,
        /// <param name="billing">AdvancedACHBilling</param>
        public async Task<SparrowResponse> AdvancedACH(string transType, string bankName, string routing, string account, string achAccountType, string achAccountSubType, decimal amount, string firstName, string lastName, AdvancedACHOptions options = null, IList<AdvancedACHOptionalAmount> optionalAmounts = null, AdvancedACHShipping shipping = null, AdvancedACHBilling billing = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", transType },
                { "mkey", _apiKey },
                { "bankname", bankName },
                { "routing", routing },
                { "account", account },
                { "achaccounttype", achAccountType },
                { "achaccountsubtype", achAccountSubType },
                { "amount", amount.ToString("f2") },
                { "firstname", firstName },
                { "lastname", lastName }
            };


            if (options != null)
            {
                var x = options;
                data.Add("orderdesc", x.OrderDesc);
                data.Add("orderid", x.OrderId);
                data.Add("saveclient", x.SaveClient == true ? "true" : "false");
                data.Add("updateclient", x.UpdateClient);
                data.Add("birthdate", x.BirthDate);
                data.Add("checknumber", x.CheckNumber);
                data.Add("driverlicensenumber", x.DriverLicenseNumber);
                data.Add("driverlicensecountry", x.DriverLicenseCountry);
                data.Add("driverlicensestate", x.DriverLicenseState);
                data.Add("courtesycardid", x.CourtesyCardId);
                data.Add("sendtransreceipttoemails", x.SendTransReceiptToEmails);
            }

            if (optionalAmounts != null)
            {
                for (int i = 0; i < optionalAmounts.Count; i++)
                {
                    var x = optionalAmounts[i];
                    data.Add("opt_amount_type_" + (i + 1), x.OptAmountType);
                    data.Add("opt_amount_value_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("opt_amount_percentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
                data.Add("sendtransreceipttoshipemail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("company", x.Company);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
                data.Add("sendtransreceipttobillemail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// eWallet Simple Credit
        /// </summary>
        /// <param name="transType">credit- funds being pushed to the customer (Format: credit)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="ewalletAccount">eWallet account credentials (ie email address associated with the customers paypal account)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="ewallet">Currently PayPal is the only eWallet type supported (ewallet type Format: PayPal)</param>,
        /// <param name="currency">Code of the payment currency. If not currency is specified, the default is USD (Format: ccc)</param>
        public async Task<SparrowResponse> EWalletSimpleCredit(string ewalletAccount, decimal amount, string currency = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "credit" },
                { "mkey", _apiKey },
                { "ewalletaccount", ewalletAccount },
                { "amount", amount.ToString("f2") },
                { "ewallet", "paypal" },
                { "currency", currency }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Fiserv Simple Sale
        /// </summary>
        /// <param name="transType">sale = Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0711 = 7/2011) (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>
        public async Task<SparrowResponse> FiservSimpleSale(string cardNum, string cardExp, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AdvancedFiservSaleOptions
        {
            /// <summary>
            /// card security code
            /// </summary>
            public string Cvv { get; set; } = "";
            /// <summary>
            /// Order Description
            /// </summary>
            public string OrderDesc { get; set; } = "";
            /// <summary>
            /// Order ID
            /// </summary>
            public string OrderId { get; set; } = "";
            /// <summary>
            /// IP address of the customer, can be used for fraud prevention in FBI Tools
            /// </summary>
            public string CardIpAddress { get; set; } = "";
            /// <summary>
            /// Total tax amount
            /// </summary>
            public decimal? Tax { get; set; } = null;
            /// <summary>
            /// Original Purchase Order
            /// </summary>
            public string PoNumber { get; set; } = "";
        }

        public class AdvancedFiservSaleShipping
        {
            /// <summary>
            /// Total shipping amount
            /// </summary>
            public decimal? ShipAmount { get; set; } = null;
            /// <summary>
            /// Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Shipping Address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping Address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping City
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping State
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping Zip Code
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping Country, ie US
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping Phone Number
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping Email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        public class AdvancedFiservSaleBilling
        {
            /// <summary>
            /// Billing first name
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing address
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address2
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing Country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing Email Address
            /// </summary>
            public string Email { get; set; } = "";
            /// <summary>
            /// Code of the payment currency. If currency is not specified, the default currency (USD) is assumed.
            /// </summary>
            public string Currency { get; set; } = "";
        }

        public class AdvancedFiservSaleProduct
        {
            /// <summary>
            /// SKU number of the product being purchased (skunumber_1, skunumber_2, etc)
            /// </summary>
            public string SkuNumber { get; set; } = "";
            /// <summary>
            /// Description of the product being purchased
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// Price of the single unit of a product being purchased
            /// </summary>
            public decimal? Amount { get; set; } = null;
            /// <summary>
            /// Number of units of a product being purchased
            /// </summary>
            public int? Quantity { get; set; } = null;
        }

        /// <summary>
        /// Advanced Fiserv Sale
        /// </summary>
        /// <param name="transType">Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0719 = 7/2019 (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="options">AdvancedFiservSaleOptions</param>,
        /// <param name="shipping">AdvancedFiservSaleShipping</param>,
        /// <param name="billing">AdvancedFiservSaleBilling</param>,
        /// <param name="products">AdvancedFiservSaleProduct</param>
        public async Task<SparrowResponse> AdvancedFiservSale(string cardNum, string cardExp, decimal amount, AdvancedFiservSaleOptions options = null, AdvancedFiservSaleShipping shipping = null, AdvancedFiservSaleBilling billing = null, IList<AdvancedFiservSaleProduct> products = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "sale" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") }
            };


            if (options != null)
            {
                var x = options;
                data.Add("cvv", x.Cvv);
                data.Add("orderdesc", x.OrderDesc);
                data.Add("orderid", x.OrderId);
                data.Add("cardipaddress", x.CardIpAddress);
                data.Add("tax", x.Tax?.ToString("f2") ?? "");
                data.Add("ponumber", x.PoNumber);
            }

            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipamount", x.ShipAmount?.ToString("f2") ?? "");
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("company", x.Company);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("email", x.Email);
                data.Add("currency", x.Currency);
            }

            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    var x = products[i];
                    data.Add("skunumber_" + (i + 1), x.SkuNumber);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("amount_" + (i + 1), x.Amount?.ToString("f2") ?? "");
                    data.Add("quantity_" + (i + 1), "" + x.Quantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Mark a successful transaction as a Chargeback
        /// </summary>
        /// <param name="transType">Chargeback will mark the transaction as “disputed” (Format: chargeback)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="reason">Description of the reason for the chargeback (Format: alphanumeric)</param>
        public async Task<SparrowResponse> MarkSuccessfulTransactionAsChargeback(string transId, string reason)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "chargeback" },
                { "mkey", _apiKey },
                { "transid", transId },
                { "reason", reason }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Retrieve Card Balance
        /// </summary>
        /// <param name="transType">Balanceinquire returns the available card balance (Format: balanceinquire)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>
        public async Task<SparrowResponse> RetrieveCardBalance(string cardNum)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "balanceinquire" },
                { "mkey", _apiKey },
                { "cardnum", cardNum }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Decrypt Custom Fields
        /// </summary>
        /// <param name="transType">The decrypt operation returns the value of the custom field (Format: decrypt)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="fieldName">Custom field name</param>,
        /// <param name="token">This is a unique Data Vault customer identifier or Data Vault payment type identifier (Format: alphanumeric string)</param>
        public async Task<SparrowResponse> DecryptCustomFields(string fieldName, string token)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "decrypt" },
                { "mkey", _apiKey },
                { "fieldname", fieldName },
                { "token", token }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Verify Account
        /// </summary>
        /// <param name="transType">auth (Format: auth)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie 0719 = 07/2019) (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged should be 0.00 (Format: d.dd)</param>,
        /// <param name="cvv">Card security code</param>,
        /// <param name="zip">Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx</param>
        public async Task<SparrowResponse> VerifyAccount(string cardNum, string cardExp, decimal amount, string cvv = "", string zip = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "auth" },
                { "mkey", _apiKey },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "amount", amount.ToString("f2") },
                { "cvv", cvv },
                { "zip", zip }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AddCustomerOptions
        {
            /// <summary>
            /// External customer identifier
            /// </summary>
            public string CustomerId { get; set; } = "";
            /// <summary>
            /// Customer note
            /// </summary>
            public string Note { get; set; } = "";
            /// <summary>
            /// Client user name. This field is required if the Client Service Portal is enabled and ‘password’ or ‘clientuseremail’ is specified
            /// </summary>
            public string UserName { get; set; } = "";
            /// <summary>
            /// Client user password. This field is required if the Client Service Portal is enabled and ‘username’ or ‘clientuseremail’ is specified
            /// </summary>
            public string Password { get; set; } = "";
            /// <summary>
            /// Client user email. This field is required if the Client Service Portal is enabled and ‘password’ or ‘username’ is specified
            /// </summary>
            public string ClientUserEmail { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
        }

        public class AddCustomerPayment
        {
            /// <summary>
            /// Type of payment info
            /// </summary>
            public string PayType { get; set; } = "";
            /// <summary>
            /// Company name, specific to the payment type
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing first name, specific to the payment type
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name, specific to the payment type
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing address, specific to the payment type
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address-line 2, specific to the payment type
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city, specific to the payment type
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state, 2 character abbreviation, specific to the payment type
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing zip, specific to payment type
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing Country, specific to payment type
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone, specific to payment type
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing email, specific to payment type
            /// </summary>
            public string Email { get; set; } = "";
            /// <summary>
            /// Credit card number
            /// </summary>
            public string CardNum { get; set; } = "";
            /// <summary>
            /// Credit card expiration
            /// </summary>
            public string CardExp { get; set; } = "";
            /// <summary>
            /// ACH bank name
            /// </summary>
            public string BankName { get; set; } = "";
            /// <summary>
            /// ACH routing number
            /// </summary>
            public string Routing { get; set; } = "";
            /// <summary>
            /// ACH account number
            /// </summary>
            public string Account { get; set; } = "";
            /// <summary>
            /// ACH account type
            /// </summary>
            public string AchAccountType { get; set; } = "";
            /// <summary>
            /// ACH account sub type
            /// </summary>
            public string AchAccountSubType { get; set; } = "";
            /// <summary>
            /// Priority of the payment type among others when sending payment using the customertoken
            /// </summary>
            public int? PayNo { get; set; } = null;
            /// <summary>
            /// eWallet account credentials, ie; email
            /// </summary>
            public string EwalletAccount { get; set; } = "";
        }

        public class AddCustomerShipping
        {
            /// <summary>
            /// Default Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Default Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Default Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Default Shipping Address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Default Shipping Address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Default Shipping City
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Default Shipping State
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Default Shipping Zip Code
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Default Shipping Country, ie US
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Default Shipping Phone Number
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Default Shipping Email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        /// <summary>
        /// Add a Customer
        /// </summary>
        /// <param name="transType">Add customer will create a new Data Vault entry (Format: addcustomer)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="firstName">Customer’s first name</param>,
        /// <param name="lastName">Customer’s last name</param>,
        /// <param name="address1">Default address</param>,
        /// <param name="address2">Default address2</param>,
        /// <param name="city">Default city</param>,
        /// <param name="state">Default state (Format: 2 character abbreviation)</param>,
        /// <param name="country">Default Country (ie. US) (Format: CC (ISO-3166))</param>,
        /// <param name="phone">Default billing phone number</param>,
        /// <param name="email">Default Email Address</param>,
        /// <param name="options">AddCustomerOptions</param>,
        /// <param name="payments">AddCustomerPayment</param>,
        /// <param name="shipping">AddCustomerShipping</param>
        public async Task<SparrowResponse> AddCustomer(string firstName, string lastName, string address1 = "", string address2 = "", string city = "", string state = "", string country = "", string phone = "", string email = "", AddCustomerOptions options = null, IList<AddCustomerPayment> payments = null, AddCustomerShipping shipping = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transtype", "addcustomer" },
                { "mkey", _apiKey },
                { "firstname", firstName },
                { "lastname", lastName },
                { "address1", address1 },
                { "address2", address2 },
                { "city", city },
                { "state", state },
                { "country", country },
                { "phone", phone },
                { "email", email }
            };


            if (options != null)
            {
                var x = options;
                data.Add("customerid", x.CustomerId);
                data.Add("note", x.Note);
                data.Add("username", x.UserName);
                data.Add("password", x.Password);
                data.Add("clientuseremail", x.ClientUserEmail);
                data.Add("zip", x.Zip);
            }

            if (payments != null)
            {
                for (int i = 0; i < payments.Count; i++)
                {
                    var x = payments[i];
                    data.Add("paytype_" + (i + 1), x.PayType);
                    data.Add("company_" + (i + 1), x.Company);
                    data.Add("firstname_" + (i + 1), x.FirstName);
                    data.Add("lastname_" + (i + 1), x.LastName);
                    data.Add("address1_" + (i + 1), x.Address1);
                    data.Add("address2_" + (i + 1), x.Address2);
                    data.Add("city_" + (i + 1), x.City);
                    data.Add("state_" + (i + 1), x.State);
                    data.Add("zip_" + (i + 1), x.Zip);
                    data.Add("country_" + (i + 1), x.Country);
                    data.Add("phone_" + (i + 1), x.Phone);
                    data.Add("email_" + (i + 1), x.Email);
                    data.Add("cardnum_" + (i + 1), x.CardNum);
                    data.Add("cardexp_" + (i + 1), x.CardExp);
                    data.Add("bankname_" + (i + 1), x.BankName);
                    data.Add("routing_" + (i + 1), x.Routing);
                    data.Add("account_" + (i + 1), x.Account);
                    data.Add("achaccounttype_" + (i + 1), x.AchAccountType);
                    data.Add("achaccountsubtype_" + (i + 1), x.AchAccountSubType);
                    data.Add("payno_" + (i + 1), "" + x.PayNo);
                    data.Add("ewalletaccount_" + (i + 1), x.EwalletAccount);
                    data.Add("ewallettype_" + (i + 1), "paypal");
                }
            }

            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AddCreditCardPayment
        {
            /// <summary>
            /// Credit card number
            /// </summary>
            public string CardNum { get; set; }
            /// <summary>
            /// Credit card expiration
            /// </summary>
            public string CardExp { get; set; }
        }

        /// <summary>
        /// Add Credit Card
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType">Add a new Data Vault Customer (Format: addcustomer)</param>,
        /// <param name="firstName">Customer’s first nam</param>,
        /// <param name="lastName">Customer’s last name</param>,
        /// <param name="token">Unique customer or payment info identifier (Format: alphanumeric string)</param>,
        /// <param name="payments">AddCreditCardPayment</param>
        public async Task<SparrowResponse> AddCreditCard(string firstName, string lastName, string token = "", IList<AddCreditCardPayment> payments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "addcustomer" },
                { "firstname", firstName },
                { "lastname", lastName },
                { "token", token }
            };


            if (payments != null)
            {
                for (int i = 0; i < payments.Count; i++)
                {
                    var x = payments[i];
                    data.Add("paytype_" + (i + 1), "creditcard");
                    data.Add("cardnum_" + (i + 1), x.CardNum);
                    data.Add("cardexp_" + (i + 1), x.CardExp);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AddACHPayment
        {
            /// <summary>
            /// Type of ACH account
            /// </summary>
            public string AchAccountType { get; set; }
            /// <summary>
            /// Subtype of ACH account
            /// </summary>
            public string AchAccountSubType { get; set; }
        }

        /// <summary>
        /// Add ACH
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType">Add a new Data Vault Customer (Format: addcustomer)</param>,
        /// <param name="firstName">Customer’s first name</param>,
        /// <param name="lastName">Customer’s last name</param>,
        /// <param name="bankName">Bank name (bankname_#)</param>,
        /// <param name="routing">Bank routing number (routing_#)</param>,
        /// <param name="account">Bank account number (account_#)</param>,
        /// <param name="token">Unique customer or payment info identifier (Format: alphanumeric string)</param>,
        /// <param name="payments">AddACHPayment</param>
        public async Task<SparrowResponse> AddACH(string firstName, string lastName, string bankName, string routing, string account, string token = "", IList<AddACHPayment> payments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "addcustomer" },
                { "firstname", firstName },
                { "lastname", lastName },
                { "bankname", bankName },
                { "routing", routing },
                { "account", account },
                { "token", token }
            };


            if (payments != null)
            {
                for (int i = 0; i < payments.Count; i++)
                {
                    var x = payments[i];
                    data.Add("paytype_" + (i + 1), "ach");
                    data.Add("achaccounttype_" + (i + 1), x.AchAccountType);
                    data.Add("achaccountsubtype_" + (i + 1), x.AchAccountSubType);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AddStarCardPayment
        {
            /// <summary>
            /// Credit Card number
            /// </summary>
            public string CardNum { get; set; }
        }

        /// <summary>
        /// Add Star Card
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType">Add a new Data Vault Customer (Format: addcustomer)</param>,
        /// <param name="firstName">Customer’s first name</param>,
        /// <param name="lastName">Customer’s last name</param>,
        /// <param name="CID">11 digit numerical (CID Format: custom field)</param>,
        /// <param name="token">Unique customer or payment info identifier (Format: alphanumeric string)</param>,
        /// <param name="payments">AddStarCardPayment</param>
        public async Task<SparrowResponse> AddStarCard(string firstName, string lastName, string CID, string token = "", IList<AddStarCardPayment> payments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "addcustomer" },
                { "firstname", firstName },
                { "lastname", lastName },
                { "CID", CID },
                { "token", token }
            };


            if (payments != null)
            {
                for (int i = 0; i < payments.Count; i++)
                {
                    var x = payments[i];
                    data.Add("paytype_" + (i + 1), "starcard");
                    data.Add("cardnum_" + (i + 1), x.CardNum);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AddEwalletPayment
        {
            /// <summary>
            /// eWallet credentials (email)
            /// </summary>
            public string EwalletAccount { get; set; }
        }

        /// <summary>
        /// Add Ewallet
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType">Add a new Data Vault Customer (Format: addcustomer)</param>,
        /// <param name="firstName">Customer’s first name</param>,
        /// <param name="lastName">Customer’s last name</param>,
        /// <param name="token">Unique customer or payment info identifier (Format: alphanumeric string)</param>,
        /// <param name="payments">AddEwalletPayment</param>
        public async Task<SparrowResponse> AddEwallet(string firstName, string lastName, string token = "", IList<AddEwalletPayment> payments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "addcustomer" },
                { "firstname", firstName },
                { "lastname", lastName },
                { "token", token }
            };


            if (payments != null)
            {
                for (int i = 0; i < payments.Count; i++)
                {
                    var x = payments[i];
                    data.Add("paytype_" + (i + 1), "ewallet");
                    data.Add("ewallettype_" + (i + 1), "paypal");
                    data.Add("ewalletaccount_" + (i + 1), x.EwalletAccount);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class UpdateCustomerOptions
        {
            /// <summary>
            /// Client Service Portal username
            /// </summary>
            public string UserName { get; set; } = "";
            /// <summary>
            /// Client Service Portal password
            /// </summary>
            public string Password { get; set; } = "";
            /// <summary>
            /// Client Service Portal email
            /// </summary>
            public string ClientUserEmail { get; set; } = "";
        }

        public class UpdateCustomerShipping
        {
            /// <summary>
            /// Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping address1
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping address2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping city
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping state
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping zip
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping country
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping phone
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        public class UpdateCustomerBilling
        {
            /// <summary>
            /// Billing first name
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing address
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address, line 2
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing zip
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing country
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing email
            /// </summary>
            public string Email { get; set; } = "";
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: updatecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>,
        /// <param name="options">UpdateCustomerOptions</param>,
        /// <param name="shipping">UpdateCustomerShipping</param>,
        /// <param name="billing">UpdateCustomerBilling</param>
        public async Task<SparrowResponse> UpdateCustomer(string token, UpdateCustomerOptions options = null, UpdateCustomerShipping shipping = null, UpdateCustomerBilling billing = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "updatecustomer" },
                { "token", token }
            };


            if (options != null)
            {
                var x = options;
                data.Add("username", x.UserName);
                data.Add("password", x.Password);
                data.Add("clientuseremail", x.ClientUserEmail);
            }

            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class DeletePaymentTypePayment
        {
            /// <summary>
            /// Token of the payment type to be deleted
            /// </summary>
            public string Token { get; set; }
        }

        /// <summary>
        /// Delete Payment Type
        /// </summary>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: updatecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>,
        /// <param name="payments">DeletePaymentTypePayment</param>
        public async Task<SparrowResponse> DeletePaymentType(string token, IList<DeletePaymentTypePayment> payments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "updatecustomer" },
                { "token", token }
            };


            if (payments != null)
            {
                for (int i = 0; i < payments.Count; i++)
                {
                    var x = payments[i];
                    data.Add("token_" + (i + 1), x.Token);
                    data.Add("operationtype_" + (i + 1), "deletepaytype");
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Delete Data Vault Customer
        /// </summary>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: deletecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>
        public async Task<SparrowResponse> DeleteDataVaultCustomer(string token)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "deletecustomer" },
                { "token", token }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class NotificationSettingsOptions
        {
            /// <summary>
            /// If “true” this will set the payment plan to pending until it is reviewed by the merchant admin
            /// </summary>
            public bool? ReviewOnAssignment { get; set; } = null;
            /// <summary>
            /// Specifies if new payments should be processed immediately or end of day
            /// </summary>
            public bool? ProcessImmediately { get; set; } = null;
            /// <summary>
            /// Specifies whether to override sender email for customers notifications
            /// </summary>
            public bool? OverrideSender { get; set; } = null;
            /// <summary>
            /// Sender email. This field is required if overridesender = true
            /// </summary>
            public string SenderEmail { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify customer about upcoming payment
            /// </summary>
            public bool? NotifyUpcomingPayment { get; set; } = null;
            /// <summary>
            /// Number of days before notification about upcoming payment should be sent to the client. This field is required if notifyupcomingpayment = true
            /// </summary>
            public int? NotifyDaysBeforeUpcomingPayment { get; set; } = null;
            /// <summary>
            /// Specifies whether to send merchant a Summarized Plan Report
            /// </summary>
            public bool? NotifyPlanSummary { get; set; } = null;
            /// <summary>
            /// Interval of plan summary notifications. This field is required if notifyplansummary = true
            /// </summary>
            public string NotifyPlanSummaryInterval { get; set; } = "";
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifyplansummary = true
            /// </summary>
            public string NotifyPlanSummaryEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to send merchant a Daily Plan Processing Statistics Report
            /// </summary>
            public bool? NotifyDailyStats { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifydailystats = true
            /// </summary>
            public string NotifyDailyStatsEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify merchant about plan completion
            /// </summary>
            public bool? NotifyPlanComplete { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifyplancomplete = true
            /// </summary>
            public string NotifyPlanCompleteEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify merchant about failed payments
            /// </summary>
            public bool? NotifyDecline { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifydecline = true
            /// </summary>
            public string NotifyDeclineEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to transfer transaction file via ftp
            /// </summary>
            public bool? NotifyViaFtp { get; set; } = null;
            /// <summary>
            /// FTP address on which transaction file is transferred. This field is required if notifyviaftp = true
            /// </summary>
            public bool? NotifyViaFtpUrl { get; set; } = null;
            /// <summary>
            /// Username to access FTP address. This field is required if notifyviaftp = true
            /// </summary>
            public string NotifyViaFtpUserName { get; set; } = "";
            /// <summary>
            /// Password to access FTP address. This field is required if notifyviaftp = true
            /// </summary>
            public string NotifyViaFtpPassword { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify merchant about flagged for review payments
            /// </summary>
            public bool? NotifyFlagged { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifyflagged = true
            /// </summary>
            public string NotifyFlaggedEmails { get; set; } = "";
        }

        public class BuildSequenceOptions
        {
            /// <summary>
            /// Sends notification emails to the client if failed payments occur
            /// </summary>
            public bool? NotifyFailures { get; set; } = null;
            /// <summary>
            /// Specifies whether to reprocess failed transactions for this plan
            /// </summary>
            public bool? UseRecycling { get; set; } = null;
            /// <summary>
            /// Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise
            /// </summary>
            public int? RetryCount { get; set; } = null;
            /// <summary>
            /// Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date
            /// </summary>
            public string RetryType { get; set; } = "";
            /// <summary>
            /// Number of days between retry attempts. This field is required if retrytype=daily
            /// </summary>
            public int? RetryPeriod { get; set; } = null;
            /// <summary>
            /// This field is required if retrytype=weekly (monday, tuesday etc.)
            /// </summary>
            public string RetryDayOfWeek { get; set; } = "";
            /// <summary>
            /// First date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetryFirstDayOfMonth { get; set; } = null;
            /// <summary>
            /// Second date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetrySecondDayOfMonth { get; set; } = null;
            /// <summary>
            /// Creates username and password for Client Portal automatically when plan is assigned to the client
            /// </summary>
            public bool? AutoCreateClientAccounts { get; set; } = null;
            /// <summary>
            /// Merchant key of eWallet account with which plan payments should be processed by default
            /// </summary>
            public string DefaultEwalletMKey { get; set; } = "";
        }

        public class BuildSequenceSequence
        {
            /// <summary>
            /// The sequence number defines which set of payments should occur first, second third, etc; if multiple sequences are present
            /// </summary>
            public int? Sequence { get; set; } = null;
            /// <summary>
            /// Amount to be paid
            /// </summary>
            public decimal Amount { get; set; }
            /// <summary>
            /// Specifies the type of payment schedule. Supported types are: every month of a specified date, every N days, every year on a specified date
            /// </summary>
            public string ScheduleType { get; set; }
            /// <summary>
            /// Day of the month for processing payments (scheduletype=monthly) or number of days between payments (scheduletype=custom)
            /// </summary>
            public int ScheduleDay { get; set; }
            /// <summary>
            /// Positive number of charges or -1 if no limit
            /// </summary>
            public int Duration { get; set; }
            /// <summary>
            /// External ID for the product
            /// </summary>
            public string ProductId { get; set; } = "";
            /// <summary>
            /// Description of the sequence
            /// </summary>
            public string Description { get; set; } = "";
        }

        /// <summary>
        /// Create a Payment Plan: First we must describe our plan
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: addplan)</param>,
        /// <param name="planName">Payment plan name (Format: string)</param>,
        /// <param name="planDesc">Payment plan description (Format: string)</param>,
        /// <param name="startDate">Starting day of the plan (Format: MM/DD/YYYY)</param>,
        /// <param name="defaultAchMKey">Merchant key of ACH account with which plan payments should be processed by default</param>,
        /// <param name="defaultCreditCardMKey">Merchant key of Credit Card account with which plan payments should be processed by default</param>,
        /// <param name="defaultEcheckMKey">Merchant key of eCheck account with which plan payments should be processed by default</param>,
        /// <param name="defaultStartCardMKey">Merchant key of Star Card account with which plan payments should be processed by default</param>,
        /// <param name="defaultEwalletMKey">Merchant key of eWallet account with which plan payments should be processed by default</param>,
        /// <param name="options">NotificationSettingsOptions</param>,
        /// <param name="buildSequenceOptions">BuildSequenceOptions</param>,
        /// <param name="sequences">BuildSequenceSequence</param>
        public async Task<SparrowResponse> CreatePaymentPlan(string planName, string planDesc, string startDate, string defaultAchMKey = "", string defaultCreditCardMKey = "", string defaultEcheckMKey = "", string defaultStartCardMKey = "", string defaultEwalletMKey = "", NotificationSettingsOptions options = null, BuildSequenceOptions buildSequenceOptions = null, IList<BuildSequenceSequence> sequences = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "addplan" },
                { "planname", planName },
                { "plandesc", planDesc },
                { "startdate", startDate },
                { "defaultachmkey", defaultAchMKey },
                { "defaultcreditcardmkey", defaultCreditCardMKey },
                { "defaultecheckmkey", defaultEcheckMKey },
                { "defaultstartcardmkey", defaultStartCardMKey },
                { "defaultewalletmkey", defaultEwalletMKey }
            };


            if (options != null)
            {
                var x = options;
                data.Add("reviewonassignment", x.ReviewOnAssignment == true ? "true" : "false");
                data.Add("processimmediately", x.ProcessImmediately == true ? "true" : "false");
                data.Add("overridesender", x.OverrideSender == true ? "true" : "false");
                data.Add("senderemail", x.SenderEmail);
                data.Add("notifyupcomingpayment", x.NotifyUpcomingPayment == true ? "true" : "false");
                data.Add("notifydaysbeforeupcomingpayment", "" + x.NotifyDaysBeforeUpcomingPayment);
                data.Add("notifyplansummary", x.NotifyPlanSummary == true ? "true" : "false");
                data.Add("notifyplansummaryinterval", x.NotifyPlanSummaryInterval);
                data.Add("notifyplansummaryemails", x.NotifyPlanSummaryEmails);
                data.Add("notifydailystats", x.NotifyDailyStats == true ? "true" : "false");
                data.Add("notifydailystatsemails", x.NotifyDailyStatsEmails);
                data.Add("notifyplancomplete", x.NotifyPlanComplete == true ? "true" : "false");
                data.Add("notifyplancompleteemails", x.NotifyPlanCompleteEmails);
                data.Add("notifydecline", x.NotifyDecline == true ? "true" : "false");
                data.Add("notifydeclineemails", x.NotifyDeclineEmails);
                data.Add("notifyviaftp", x.NotifyViaFtp == true ? "true" : "false");
                data.Add("notifyviaftpurl", x.NotifyViaFtpUrl == true ? "true" : "false");
                data.Add("notifyviaftpusername", x.NotifyViaFtpUserName);
                data.Add("notifyviaftppassword", x.NotifyViaFtpPassword);
                data.Add("notifyflagged", x.NotifyFlagged == true ? "true" : "false");
                data.Add("notifyflaggedemails", x.NotifyFlaggedEmails);
            }

            if (buildSequenceOptions != null)
            {
                var x = buildSequenceOptions;
                data.Add("notifyfailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("userecycling", x.UseRecycling == true ? "true" : "false");
                data.Add("retrycount", "" + x.RetryCount);
                data.Add("retrytype", x.RetryType);
                data.Add("retryperiod", "" + x.RetryPeriod);
                data.Add("retrydayofweek", x.RetryDayOfWeek);
                data.Add("retryfirstdayofmonth", "" + x.RetryFirstDayOfMonth);
                data.Add("retryseconddayofmonth", "" + x.RetrySecondDayOfMonth);
                data.Add("autocreateclientaccounts", x.AutoCreateClientAccounts == true ? "true" : "false");
                data.Add("defaultewalletmkey", x.DefaultEwalletMKey);
            }

            if (sequences != null)
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    var x = sequences[i];
                    data.Add("sequence_" + (i + 1), "" + x.Sequence);
                    data.Add("amount_" + (i + 1), x.Amount.ToString("f2"));
                    data.Add("scheduletype_" + (i + 1), x.ScheduleType);
                    data.Add("scheduleday_" + (i + 1), "" + x.ScheduleDay);
                    data.Add("duration_" + (i + 1), "" + x.Duration);
                    data.Add("productid_" + (i + 1), x.ProductId);
                    data.Add("description_" + (i + 1), x.Description);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class UpdatePaymentPlanOptions
        {
            /// <summary>
            /// Payment plan name
            /// </summary>
            public string PlanName { get; set; } = "";
            /// <summary>
            /// Payment plan description
            /// </summary>
            public string PlanDesc { get; set; } = "";
            /// <summary>
            /// Starting day of the plan
            /// </summary>
            public string StartDate { get; set; } = "";
            /// <summary>
            /// Specifies whether to reprocess failed transactions in this plan
            /// </summary>
            public bool? UseRecycling { get; set; } = null;
            /// <summary>
            /// Sends notification emails to the client in case of failed payments
            /// </summary>
            public bool? NotifyFailures { get; set; } = null;
            /// <summary>
            /// Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise
            /// </summary>
            public int? RetryCount { get; set; } = null;
            /// <summary>
            /// Specifies the type of retry schedule
            /// </summary>
            public string RetryType { get; set; } = "";
            /// <summary>
            /// Number of days between retry attempts. This field is required if retrytype=daily
            /// </summary>
            public int? RetryPeriod { get; set; } = null;
            /// <summary>
            /// This field is required if retrytype=weekly (monday, tuesday etc.)
            /// </summary>
            public string RetryDayOfWeek { get; set; } = "";
            /// <summary>
            /// First date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetryFirstDayOfMonth { get; set; } = null;
            /// <summary>
            /// Second date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetrySecondDayOfMonth { get; set; } = null;
            /// <summary>
            /// Creates username and password for Client Portal automatically when plan is assigned to the client
            /// </summary>
            public bool? AutoCreateClientAccounts { get; set; } = null;
        }

        public class UpdatePaymentPlanNotificationSettingsOptions
        {
            /// <summary>
            /// If “true” this will set the payment plan to pending until it is reviewed by the merchant admin
            /// </summary>
            public bool? ReviewOnAssignment { get; set; } = null;
            /// <summary>
            /// Specifies if new payments should be processed immediately or end of day
            /// </summary>
            public bool? ProcessImmediately { get; set; } = null;
            /// <summary>
            /// Specifies whether to override sender email for customers notifications
            /// </summary>
            public bool? OverrideSender { get; set; } = null;
            /// <summary>
            /// Sender email. This field is required if overridesender = true
            /// </summary>
            public string SenderEmail { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify customer about upcoming payment
            /// </summary>
            public bool? NotifyUpcomingPayment { get; set; } = null;
            /// <summary>
            /// Number of days before notification about upcoming payment should be sent to the client. This field is required if notifyupcomingpayment = true
            /// </summary>
            public int? NotifyDaysBeforeUpcomingPayment { get; set; } = null;
            /// <summary>
            /// Specifies whether to send merchant a Summarized Plan Report
            /// </summary>
            public bool? NotifyPlanSummary { get; set; } = null;
            /// <summary>
            /// Interval of plan summary notifications. This field is required if notifyplansummary = true
            /// </summary>
            public string NotifyPlanSummaryInterval { get; set; } = "";
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifyplansummary = true
            /// </summary>
            public string NotifyPlanSummaryEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to send merchant a Daily Plan Processing Statistics Report
            /// </summary>
            public bool? NotifyDailyStats { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifydailystats = true
            /// </summary>
            public string NotifyDailyStatsEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify merchant about plan completion
            /// </summary>
            public bool? NotifyPlanComplete { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifyplancomplete = true
            /// </summary>
            public string NotifyPlanCompleteEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify merchant about failed payments
            /// </summary>
            public bool? NotifyDecline { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifydecline = true
            /// </summary>
            public string NotifyDeclineEmails { get; set; } = "";
            /// <summary>
            /// Specifies whether to transfer transaction file via ftp
            /// </summary>
            public bool? NotifyViaFtp { get; set; } = null;
            /// <summary>
            /// FTP address on which transaction file is transferred. This field is required if notifyviaftp = true
            /// </summary>
            public bool? NotifyViaFtpUrl { get; set; } = null;
            /// <summary>
            /// Username to access FTP address. This field is required if notifyviaftp = true
            /// </summary>
            public string NotifyViaFtpUserName { get; set; } = "";
            /// <summary>
            /// Password to access FTP address. This field is required if notifyviaftp = true
            /// </summary>
            public string NotifyViaFtpPassword { get; set; } = "";
            /// <summary>
            /// Specifies whether to notify merchant about flagged for review payments
            /// </summary>
            public bool? NotifyFlagged { get; set; } = null;
            /// <summary>
            /// Multiple addresses are separated by comma. This field is required if notifyflagged = true
            /// </summary>
            public string NotifyFlaggedEmails { get; set; } = "";
        }

        public class AddOrUpdateSequenceOptions
        {
            /// <summary>
            /// Sends notification emails to the client if failed payments occur
            /// </summary>
            public bool? NotifyFailures { get; set; } = null;
            /// <summary>
            /// Specifies whether to reprocess failed transactions for this plan
            /// </summary>
            public bool? UseRecycling { get; set; } = null;
            /// <summary>
            /// Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise
            /// </summary>
            public int? RetryCount { get; set; } = null;
            /// <summary>
            /// Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date
            /// </summary>
            public string RetryType { get; set; } = "";
            /// <summary>
            /// Number of days between retry attempts. This field is required if retrytype=daily
            /// </summary>
            public int? RetryPeriod { get; set; } = null;
            /// <summary>
            /// This field is required if retrytype=weekly (monday, tuesday etc.)
            /// </summary>
            public string RetryDayOfWeek { get; set; } = "";
            /// <summary>
            /// First date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetryFirstDayOfMonth { get; set; } = null;
            /// <summary>
            /// Second date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetrySecondDayOfMonth { get; set; } = null;
            /// <summary>
            /// Creates username and password for Client Portal automatically when plan is assigned to the client
            /// </summary>
            public bool? AutoCreateClientAccounts { get; set; } = null;
            /// <summary>
            /// Merchant key of eWallet account with which plan payments should be processed by default
            /// </summary>
            public string DefaultEwalletMKey { get; set; } = "";
        }

        public class AddOrUpdateSequenceSequence
        {
            /// <summary>
            /// Addsequence will add a new sequence, whereas Updatesequence will update an existing sequence
            /// </summary>
            public string OperationType { get; set; }
            /// <summary>
            /// The sequence number defines which set of payments should occur first, second third, etc; if multiple sequences are present
            /// </summary>
            public int Sequence { get; set; }
            /// <summary>
            /// Amount to be paid
            /// </summary>
            public decimal Amount { get; set; }
            /// <summary>
            /// Specifies the type of payment schedule. Supported types are: every month of a specified date, every N days, every year on a specified date
            /// </summary>
            public string ScheduleType { get; set; }
            /// <summary>
            /// Day of the month for processing payments (scheduletype=monthly) or number of days between payments (scheduletype=custom)
            /// </summary>
            public int ScheduleDay { get; set; }
            /// <summary>
            /// Positive number of charges or -1 if no limit
            /// </summary>
            public int Duration { get; set; }
            /// <summary>
            /// External ID for the product
            /// </summary>
            public string ProductId { get; set; } = "";
            /// <summary>
            /// Description of the sequence
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// New number for the sequence
            /// </summary>
            public int? NewSequence { get; set; } = null;
        }

        public class DeleteSequenceSequence
        {
            /// <summary>
            /// Sequence to be deleted
            /// </summary>
            public int? Sequence { get; set; } = null;
        }

        /// <summary>
        /// Update a Payment Plan: Payment Plans can be updated by using the transaction type “updateplan”.
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: updateplan)</param>,
        /// <param name="token">Unique payment plan identifier</param>,
        /// <param name="defaultAchMKey">Merchant key of ACH account with which plan payments should be processed by default</param>,
        /// <param name="defaultCreditCardMKey">Merchant key of Credit Card account with which plan payments should be processed by default</param>,
        /// <param name="defaultEcheckMKey">Merchant key of eCheck account with which plan payments should be processed by default</param>,
        /// <param name="defaultStartCardMKey">Merchant key of Star Card account with which plan payments should be processed by default</param>,
        /// <param name="defaultEwalletMKey">Merchant key of eWallet account with which plan payments should be processed by default</param>,
        /// <param name="options">UpdatePaymentPlanOptions</param>,
        /// <param name="notificationSettingsOptions">UpdatePaymentPlanNotificationSettingsOptions</param>,
        /// <param name="addOrUpdateSequenceOptions">AddOrUpdateSequenceOptions</param>,
        /// <param name="sequences">AddOrUpdateSequenceSequence</param>,
        /// <param name="deleteSequenceSequences">DeleteSequenceSequence</param>
        public async Task<SparrowResponse> UpdatePaymentPlan(string token, string defaultAchMKey = "", string defaultCreditCardMKey = "", string defaultEcheckMKey = "", string defaultStartCardMKey = "", string defaultEwalletMKey = "", UpdatePaymentPlanOptions options = null, UpdatePaymentPlanNotificationSettingsOptions notificationSettingsOptions = null, AddOrUpdateSequenceOptions addOrUpdateSequenceOptions = null, IList<AddOrUpdateSequenceSequence> sequences = null, IList<DeleteSequenceSequence> deleteSequenceSequences = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "updateplan" },
                { "token", token },
                { "defaultachmkey", defaultAchMKey },
                { "defaultcreditcardmkey", defaultCreditCardMKey },
                { "defaultecheckmkey", defaultEcheckMKey },
                { "defaultstartcardmkey", defaultStartCardMKey },
                { "defaultewalletmkey", defaultEwalletMKey }
            };


            if (options != null)
            {
                var x = options;
                data.Add("planname", x.PlanName);
                data.Add("plandesc", x.PlanDesc);
                data.Add("startdate", x.StartDate);
                data.Add("userecycling", x.UseRecycling == true ? "true" : "false");
                data.Add("notifyfailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("retrycount", "" + x.RetryCount);
                data.Add("retrytype", x.RetryType);
                data.Add("retryperiod", "" + x.RetryPeriod);
                data.Add("retrydayofweek", x.RetryDayOfWeek);
                data.Add("retryfirstdayofmonth", "" + x.RetryFirstDayOfMonth);
                data.Add("retryseconddayofmonth", "" + x.RetrySecondDayOfMonth);
                data.Add("autocreateclientaccounts", x.AutoCreateClientAccounts == true ? "true" : "false");
            }

            if (notificationSettingsOptions != null)
            {
                var x = notificationSettingsOptions;
                data.Add("reviewonassignment", x.ReviewOnAssignment == true ? "true" : "false");
                data.Add("processimmediately", x.ProcessImmediately == true ? "true" : "false");
                data.Add("overridesender", x.OverrideSender == true ? "true" : "false");
                data.Add("senderemail", x.SenderEmail);
                data.Add("notifyupcomingpayment", x.NotifyUpcomingPayment == true ? "true" : "false");
                data.Add("notifydaysbeforeupcomingpayment", "" + x.NotifyDaysBeforeUpcomingPayment);
                data.Add("notifyplansummary", x.NotifyPlanSummary == true ? "true" : "false");
                data.Add("notifyplansummaryinterval", x.NotifyPlanSummaryInterval);
                data.Add("notifyplansummaryemails", x.NotifyPlanSummaryEmails);
                data.Add("notifydailystats", x.NotifyDailyStats == true ? "true" : "false");
                data.Add("notifydailystatsemails", x.NotifyDailyStatsEmails);
                data.Add("notifyplancomplete", x.NotifyPlanComplete == true ? "true" : "false");
                data.Add("notifyplancompleteemails", x.NotifyPlanCompleteEmails);
                data.Add("notifydecline", x.NotifyDecline == true ? "true" : "false");
                data.Add("notifydeclineemails", x.NotifyDeclineEmails);
                data.Add("notifyviaftp", x.NotifyViaFtp == true ? "true" : "false");
                data.Add("notifyviaftpurl", x.NotifyViaFtpUrl == true ? "true" : "false");
                data.Add("notifyviaftpusername", x.NotifyViaFtpUserName);
                data.Add("notifyviaftppassword", x.NotifyViaFtpPassword);
                data.Add("notifyflagged", x.NotifyFlagged == true ? "true" : "false");
                data.Add("notifyflaggedemails", x.NotifyFlaggedEmails);
            }

            if (addOrUpdateSequenceOptions != null)
            {
                var x = addOrUpdateSequenceOptions;
                data.Add("notifyfailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("userecycling", x.UseRecycling == true ? "true" : "false");
                data.Add("retrycount", "" + x.RetryCount);
                data.Add("retrytype", x.RetryType);
                data.Add("retryperiod", "" + x.RetryPeriod);
                data.Add("retrydayofweek", x.RetryDayOfWeek);
                data.Add("retryfirstdayofmonth", "" + x.RetryFirstDayOfMonth);
                data.Add("retryseconddayofmonth", "" + x.RetrySecondDayOfMonth);
                data.Add("autocreateclientaccounts", x.AutoCreateClientAccounts == true ? "true" : "false");
                data.Add("defaultewalletmkey", x.DefaultEwalletMKey);
            }

            if (sequences != null)
            {
                for (int i = 0; i < sequences.Count; i++)
                {
                    var x = sequences[i];
                    data.Add("operationtype_" + (i + 1), x.OperationType);
                    data.Add("sequence_" + (i + 1), "" + x.Sequence);
                    data.Add("amount_" + (i + 1), x.Amount.ToString("f2"));
                    data.Add("scheduletype_" + (i + 1), x.ScheduleType);
                    data.Add("scheduleday_" + (i + 1), "" + x.ScheduleDay);
                    data.Add("duration_" + (i + 1), "" + x.Duration);
                    data.Add("productid_" + (i + 1), x.ProductId);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("newsequence_" + (i + 1), "" + x.NewSequence);
                }
            }

            if (deleteSequenceSequences != null)
            {
                for (int i = 0; i < deleteSequenceSequences.Count; i++)
                {
                    var x = deleteSequenceSequences[i];
                    data.Add("operationtype_" + (i + 1), "deletesequence");
                    data.Add("sequence_" + (i + 1), "" + x.Sequence);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Delete a Plan: We can also delete an entire plan.
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: deleteplan)</param>,
        /// <param name="token">Payment plan unique identifier (Format: alphanumeric string)</param>,
        /// <param name="cancelPayments">Specifies whether to cancel pending payments caused by assignments of this plan. Default value is false (Format: true/false)</param>
        public async Task<SparrowResponse> DeletePlan(string token, bool? cancelPayments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "deleteplan" },
                { "token", token },
                { "cancelpayments", cancelPayments == true ? "true" : "false" }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class AssignPaymentPlanToCustomerOptions
        {
            /// <summary>
            /// Day of the first payment of the plan; if not present the plan’s start date (if it exists) is used.
            /// </summary>
            public string StartDate { get; set; } = "";
            /// <summary>
            /// External ID for the product
            /// </summary>
            public string ProductId { get; set; } = "";
            /// <summary>
            /// Description of plan assignment
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// Sends notification emails to the client if failed payments occur
            /// </summary>
            public bool? NotifyFailures { get; set; } = null;
            /// <summary>
            /// Specifies whether to reprocess failed transactions for this plan
            /// </summary>
            public bool? UseRecycling { get; set; } = null;
            /// <summary>
            /// Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise
            /// </summary>
            public int? RetryCount { get; set; } = null;
            /// <summary>
            /// Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date
            /// </summary>
            public string RetryType { get; set; } = "";
            /// <summary>
            /// Number of days between retry attempts. This field is required if retrytype=daily
            /// </summary>
            public int? RetryPeriod { get; set; } = null;
            /// <summary>
            /// This field is required if retrytype=weekly (monday, tuesday etc.)
            /// </summary>
            public string RetryDayOfWeek { get; set; } = "";
            /// <summary>
            /// First date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetryFirstDayOfMonth { get; set; } = null;
            /// <summary>
            /// Second date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetrySecondDayOfMonth { get; set; } = null;
            /// <summary>
            /// Specifies whether to add prorated payment in this plan
            /// </summary>
            public bool? ProratedPayment { get; set; } = null;
            /// <summary>
            /// Merchant key of account with which plan payments should be processed by default. This account must be of the same type as selected customer’s payment type
            /// </summary>
            public string RoutingKey { get; set; } = "";
        }

        /// <summary>
        /// Assign a Payment Plan to a Customer: Payment plans can be assigned to multiple Data Vault customers
        /// </summary>
        /// <param name="mKey">Secure merchant account key</param>,
        /// <param name="transType"> (Format: assignplan)</param>,
        /// <param name="customerToken">Customer unique identifier (Format: alphanumeric string)</param>,
        /// <param name="planToken">Recurring payment plan unique identifier; used when assigning existing plan to the customer (Format: alphanumeric string)</param>,
        /// <param name="paymentToken">Token of the customer’s payment type, if they have multiple (Format: alphanumeric string)</param>,
        /// <param name="options">AssignPaymentPlanToCustomerOptions</param>
        public async Task<SparrowResponse> AssignPaymentPlanToCustomer(string customerToken, string planToken, string paymentToken, AssignPaymentPlanToCustomerOptions options = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "assignplan" },
                { "customertoken", customerToken },
                { "plantoken", planToken },
                { "paymenttoken", paymentToken }
            };


            if (options != null)
            {
                var x = options;
                data.Add("startdate", x.StartDate);
                data.Add("productid", x.ProductId);
                data.Add("description", x.Description);
                data.Add("notifyfailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("userecycling", x.UseRecycling == true ? "true" : "false");
                data.Add("retrycount", "" + x.RetryCount);
                data.Add("retrytype", x.RetryType);
                data.Add("retryperiod", "" + x.RetryPeriod);
                data.Add("retrydayofweek", x.RetryDayOfWeek);
                data.Add("retryfirstdayofmonth", "" + x.RetryFirstDayOfMonth);
                data.Add("retryseconddayofmonth", "" + x.RetrySecondDayOfMonth);
                data.Add("proratedpayment", x.ProratedPayment == true ? "true" : "false");
                data.Add("routingkey", x.RoutingKey);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class UpdatePaymentPlanAssignmentOptions
        {
            /// <summary>
            /// Day of the first payment of the plan; if not present the plan’s start date (if it exists) is used.
            /// </summary>
            public string StartDate { get; set; } = "";
            /// <summary>
            /// External ID for the product
            /// </summary>
            public string ProductId { get; set; } = "";
            /// <summary>
            /// Description of plan assignment
            /// </summary>
            public string Description { get; set; } = "";
            /// <summary>
            /// Sends notification emails to the client if failed payments occur
            /// </summary>
            public bool? NotifyFailures { get; set; } = null;
            /// <summary>
            /// Specifies whether to reprocess failed transactions for this plan
            /// </summary>
            public bool? UseRecycling { get; set; } = null;
            /// <summary>
            /// Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise
            /// </summary>
            public int? RetryCount { get; set; } = null;
            /// <summary>
            /// Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date
            /// </summary>
            public string RetryType { get; set; } = "";
            /// <summary>
            /// Number of days between retry attempts. This field is required if retrytype=daily
            /// </summary>
            public int? RetryPeriod { get; set; } = null;
            /// <summary>
            /// This field is required if retrytype=weekly (monday, tuesday etc.)
            /// </summary>
            public string RetryDayOfWeek { get; set; } = "";
            /// <summary>
            /// First date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetryFirstDayOfMonth { get; set; } = null;
            /// <summary>
            /// Second date of retry schedule. This field is required if retrytype=monthly
            /// </summary>
            public int? RetrySecondDayOfMonth { get; set; } = null;
            /// <summary>
            /// Specifies whether to add prorated payment in this plan
            /// </summary>
            public bool? ProratedPayment { get; set; } = null;
            /// <summary>
            /// Token of the customer’s payment type, if they have multiple
            /// </summary>
            public string PaymentToken { get; set; } = "";
            /// <summary>
            /// Merchant key of account with which plan payments should be processed by default. This account must be of the same type as selected customer’s payment type
            /// </summary>
            public string RoutingKey { get; set; } = "";
        }

        /// <summary>
        /// Update Payment Plan Assignment: Payment Plan assignments may be updated
        /// </summary>
        /// <param name="mKey">Secure merchant account key</param>,
        /// <param name="transType"> (Format: updateassignment)</param>,
        /// <param name="assignmentToken">Unique identifier of payment plan assignment (Format: alphanumeric string)</param>,
        /// <param name="options">UpdatePaymentPlanAssignmentOptions</param>
        public async Task<SparrowResponse> UpdatePaymentPlanAssignment(string assignmentToken, UpdatePaymentPlanAssignmentOptions options = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "updateassignment" },
                { "assignmenttoken", assignmentToken }
            };


            if (options != null)
            {
                var x = options;
                data.Add("startdate", x.StartDate);
                data.Add("productid", x.ProductId);
                data.Add("description", x.Description);
                data.Add("notifyfailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("userecycling", x.UseRecycling == true ? "true" : "false");
                data.Add("retrycount", "" + x.RetryCount);
                data.Add("retrytype", x.RetryType);
                data.Add("retryperiod", "" + x.RetryPeriod);
                data.Add("retrydayofweek", x.RetryDayOfWeek);
                data.Add("retryfirstdayofmonth", "" + x.RetryFirstDayOfMonth);
                data.Add("retryseconddayofmonth", "" + x.RetrySecondDayOfMonth);
                data.Add("proratedpayment", x.ProratedPayment == true ? "true" : "false");
                data.Add("paymenttoken", x.PaymentToken);
                data.Add("routingkey", x.RoutingKey);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Cancel Plan Assignment: Payment Plan assignments may be cancelled both before and after the plan has begun.
        /// </summary>
        /// <param name="mKey">Secure merchant account key</param>,
        /// <param name="transType"> (Format: cancelassignment)</param>,
        /// <param name="assignmentToken">Unique identifier of payment plan assignment (Format: alphanumeric string)</param>
        public async Task<SparrowResponse> CancelPlanAssignment(string assignmentToken)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "cancelassignment" },
                { "assignmenttoken", assignmentToken }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class CreateInvoiceOptions
        {
            /// <summary>
            /// Unique data vault client identifier
            /// </summary>
            public string CustomerToken { get; set; } = "";
            /// <summary>
            /// If Invoice status is 'Active' email with Pay Invoice URL will be sent to specified email.
            /// </summary>
            public string SendPaymentLinkEmail { get; set; } = "";
            /// <summary>
            /// The source of the invoice. If not specified, the default value is DataVault
            /// </summary>
            public string InvoiceSource { get; set; } = "";
        }

        public class CreateInvoiceProduct
        {
            /// <summary>
            /// SKU number of the product being purchased. Required if one of the following fields is specified: invoiceitemdescription_#, invoiceitemprice_#, invoiceitemquantity_#
            /// </summary>
            public string InvoiceItemSku { get; set; } = "";
            /// <summary>
            /// Description of the product being purchased. Field supports 3000 characters. Required if one of the following fields is specified: invoiceitemsku_#, invoiceitemprice_#, invoiceitemquantity_#
            /// </summary>
            public string InvoiceItemDescription { get; set; } = "";
            /// <summary>
            /// Price of the single unit of a product being purchased. Required if one of the following fields is specified: invoiceitemsku_#, invoiceitemdescription_#, invoiceitemquantity_#
            /// </summary>
            public decimal? InvoiceItemPrice { get; set; } = null;
            /// <summary>
            /// Number of units of a product being purchased. Required if one of the following fields is specified: invoiceitemsku_#, invoiceitemdescription_#, invoiceitemprice_#
            /// </summary>
            public string InvoiceItemQuantity { get; set; } = "";
        }

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: createmerchantinvoice)</param>,
        /// <param name="invoiceDate">The date of the invoice (Format: MM/DD/YYYY)</param>,
        /// <param name="currency">Code of the payment currency (Format: CCC (ISO 4217 alphabetic code))</param>,
        /// <param name="invoiceStatus">The status of the invoice. Only active invoices can be paid (Format: [draft|active])</param>,
        /// <param name="invoiceAmount">Total amount of invoice (i.e. 10.00). Required if product list is not specified (Format: d.dd)</param>,
        /// <param name="options">CreateInvoiceOptions</param>,
        /// <param name="products">CreateInvoiceProduct</param>
        public async Task<SparrowResponse> CreateInvoice(string invoiceDate, string currency, string invoiceStatus, decimal invoiceAmount, CreateInvoiceOptions options = null, IList<CreateInvoiceProduct> products = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "createmerchantinvoice" },
                { "invoicedate", invoiceDate },
                { "currency", currency },
                { "invoicestatus", invoiceStatus },
                { "invoiceamount", invoiceAmount.ToString("f2") }
            };


            if (options != null)
            {
                var x = options;
                data.Add("customertoken", x.CustomerToken);
                data.Add("sendpaymentlinkemail", x.SendPaymentLinkEmail);
                data.Add("invoicesource", x.InvoiceSource);
            }

            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    var x = products[i];
                    data.Add("invoiceitemsku_" + (i + 1), x.InvoiceItemSku);
                    data.Add("invoiceitemdescription_" + (i + 1), x.InvoiceItemDescription);
                    data.Add("invoiceitemprice_" + (i + 1), x.InvoiceItemPrice?.ToString("f2") ?? "");
                    data.Add("invoiceitemquantity_" + (i + 1), x.InvoiceItemQuantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class UpdateInvoiceOptions
        {
            /// <summary>
            /// Unique data vault client identifier
            /// </summary>
            public string CustomerToken { get; set; } = "";
            /// <summary>
            /// The date of the invoice
            /// </summary>
            public string InvoiceDate { get; set; } = "";
            /// <summary>
            /// Code of the payment currency
            /// </summary>
            public string Currency { get; set; } = "";
            /// <summary>
            /// The status of the invoice. Only active invoices can be paid
            /// </summary>
            public string InvoiceStatus { get; set; } = "";
            /// <summary>
            /// Total amount of invoice (i.e. 10.00). Required if product list is not specified
            /// </summary>
            public decimal? InvoiceAmount { get; set; } = null;
            /// <summary>
            /// If Invoice status is 'Active' email with Pay Invoice URL will be sent to specified email.
            /// </summary>
            public string SendPaymentLinkEmail { get; set; } = "";
            /// <summary>
            /// The source of the invoice. If not specified, the default value is DataVault
            /// </summary>
            public string InvoiceSource { get; set; } = "";
        }

        public class UpdateInvoiceProduct
        {
            /// <summary>
            /// SKU number of the product being purchased. Required if one of the following fields is specified: invoiceitemdescription_#, invoiceitemprice_#, invoiceitemquantity_#
            /// </summary>
            public string InvoiceItemSku { get; set; } = "";
            /// <summary>
            /// Description of the product being purchased. Field supports 3000 characters. Required if one of the following fields is specified: invoiceitemsku_#, invoiceitemprice_#, invoiceitemquantity_#
            /// </summary>
            public string InvoiceItemDescription { get; set; } = "";
            /// <summary>
            /// Price of the single unit of a product being purchased. Required if one of the following fields is specified: invoiceitemsku_#, invoiceitemdescription_#, invoiceitemquantity_#
            /// </summary>
            public decimal? InvoiceItemPrice { get; set; } = null;
            /// <summary>
            /// Number of units of a product being purchased. Required if one of the following fields is specified: invoiceitemsku_#, invoiceitemdescription_#, invoiceitemprice_#
            /// </summary>
            public string InvoiceItemQuantity { get; set; } = "";
        }

        /// <summary>
        /// Update Invoice
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: updateinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>,
        /// <param name="options">UpdateInvoiceOptions</param>,
        /// <param name="products">UpdateInvoiceProduct</param>
        public async Task<SparrowResponse> UpdateInvoice(string invoiceNumber, UpdateInvoiceOptions options = null, IList<UpdateInvoiceProduct> products = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "updateinvoice" },
                { "invoicenumber", invoiceNumber }
            };


            if (options != null)
            {
                var x = options;
                data.Add("customertoken", x.CustomerToken);
                data.Add("invoicedate", x.InvoiceDate);
                data.Add("currency", x.Currency);
                data.Add("invoicestatus", x.InvoiceStatus);
                data.Add("invoiceamount", x.InvoiceAmount?.ToString("f2") ?? "");
                data.Add("sendpaymentlinkemail", x.SendPaymentLinkEmail);
                data.Add("invoicesource", x.InvoiceSource);
            }

            if (products != null)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    var x = products[i];
                    data.Add("invoiceitemsku_" + (i + 1), x.InvoiceItemSku);
                    data.Add("invoiceitemdescription_" + (i + 1), x.InvoiceItemDescription);
                    data.Add("invoiceitemprice_" + (i + 1), x.InvoiceItemPrice?.ToString("f2") ?? "");
                    data.Add("invoiceitemquantity_" + (i + 1), x.InvoiceItemQuantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Retrieve Invoice
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: getinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>
        public async Task<SparrowResponse> RetrieveInvoice(string invoiceNumber)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "getinvoice" },
                { "invoicenumber", invoiceNumber }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Cancel Invoice
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: cancelinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>,
        /// <param name="invoiceStatusReason">The reason of canceling the invoice (Format: alphanumeric)</param>
        public async Task<SparrowResponse> CancelInvoice(string invoiceNumber, string invoiceStatusReason)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "cancelinvoice" },
                { "invoicenumber", invoiceNumber },
                { "invoicestatusreason", invoiceStatusReason }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Cancel Invoice by Customer
        /// </summary>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: cancelinvoicebycustomer)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>,
        /// <param name="invoiceStatusReason">The reason of canceling the invoice (Format: alphanumeric)</param>
        public async Task<SparrowResponse> CancelInvoiceByCustomer(string invoiceNumber, string invoiceStatusReason)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "cancelinvoicebycustomer" },
                { "invoicenumber", invoiceNumber },
                { "invoicestatusreason", invoiceStatusReason }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class PayInvoiceWithCreditCardShipping
        {
            /// <summary>
            /// Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Shipping Address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping Address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping City
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping State
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping Zip Code
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping Country, ie US
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping Phone Number
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping Email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        public class PayInvoiceWithCreditCardBilling
        {
            /// <summary>
            /// Billing first name
            /// </summary>
            public string FirstName { get; set; } = "";
            /// <summary>
            /// Billing last name
            /// </summary>
            public string LastName { get; set; } = "";
            /// <summary>
            /// Billing company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing address
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address2
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing Country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone number
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing fax number
            /// </summary>
            public string Fax { get; set; } = "";
            /// <summary>
            /// Billing Email Address
            /// </summary>
            public string Email { get; set; } = "";
        }

        /// <summary>
        /// Pay an Invoice with a Credit Card
        /// </summary>
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="transType"> (Format: payinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv-[0-9])</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0719 = 7/2019) (Format: MMYY)</param>,
        /// <param name="cvv">card security code</param>,
        /// <param name="shipping">PayInvoiceWithCreditCardShipping</param>,
        /// <param name="billing">PayInvoiceWithCreditCardBilling</param>
        public async Task<SparrowResponse> PayInvoiceWithCreditCard(string invoiceNumber, string cardNum, string cardExp, string cvv = "", PayInvoiceWithCreditCardShipping shipping = null, PayInvoiceWithCreditCardBilling billing = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "payinvoice" },
                { "invoicenumber", invoiceNumber },
                { "cardnum", cardNum },
                { "cardexp", cardExp },
                { "cvv", cvv }
            };


            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("company", x.Company);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("phone", x.Phone);
                data.Add("fax", x.Fax);
                data.Add("email", x.Email);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        public class PayInvoiceWithBankAccountShipping
        {
            /// <summary>
            /// Shipping first name
            /// </summary>
            public string ShipFirstName { get; set; } = "";
            /// <summary>
            /// Shipping last name
            /// </summary>
            public string ShipLastName { get; set; } = "";
            /// <summary>
            /// Shipping company
            /// </summary>
            public string ShipCompany { get; set; } = "";
            /// <summary>
            /// Shipping Address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping Address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
            /// <summary>
            /// Shipping City
            /// </summary>
            public string ShipCity { get; set; } = "";
            /// <summary>
            /// Shipping State
            /// </summary>
            public string ShipState { get; set; } = "";
            /// <summary>
            /// Shipping Zip Code
            /// </summary>
            public string ShipZip { get; set; } = "";
            /// <summary>
            /// Shipping Country, ie US
            /// </summary>
            public string ShipCountry { get; set; } = "";
            /// <summary>
            /// Shipping Phone Number
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping Email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        public class PayInvoiceWithBankAccountBilling
        {
            /// <summary>
            /// Billing first name
            /// </summary>
            public string FirstName { get; set; }
            /// <summary>
            /// Billing last name
            /// </summary>
            public string LastName { get; set; }
            /// <summary>
            /// Billing company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Billing address
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing address2
            /// </summary>
            public string Address2 { get; set; } = "";
            /// <summary>
            /// Billing city
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing Country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing phone number
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing fax number
            /// </summary>
            public string Fax { get; set; } = "";
            /// <summary>
            /// Billing Email Address
            /// </summary>
            public string Email { get; set; } = "";
        }

        /// <summary>
        /// Pay an Invoice with a Bank Account
        /// </summary>
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="transType"> (Format: payinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv-[0-9])</param>,
        /// <param name="bankName">The customer’s bank name</param>,
        /// <param name="routing">The customer’s bank routing number</param>,
        /// <param name="account">The customer’s bank account number</param>,
        /// <param name="achAccountType">The customer’s type of ACH account (Format: [checking|savings])</param>,
        /// <param name="achAccountSubType">The customer’s ACH account entity (Format: [business|personal])</param>,
        /// <param name="shipping">PayInvoiceWithBankAccountShipping</param>,
        /// <param name="billing">PayInvoiceWithBankAccountBilling</param>
        public async Task<SparrowResponse> PayInvoiceWithBankAccount(string invoiceNumber, string bankName, string routing, string account, string achAccountType, string achAccountSubType, PayInvoiceWithBankAccountBilling billing, PayInvoiceWithBankAccountShipping shipping = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mkey", _apiKey },
                { "transtype", "payinvoice" },
                { "invoicenumber", invoiceNumber },
                { "bankname", bankName },
                { "routing", routing },
                { "account", account },
                { "achaccounttype", achAccountType },
                { "achaccountsubtype", achAccountSubType }
            };


            if (shipping != null)
            {
                var x = shipping;
                data.Add("shipfirstname", x.ShipFirstName);
                data.Add("shiplastname", x.ShipLastName);
                data.Add("shipcompany", x.ShipCompany);
                data.Add("shipaddress1", x.ShipAddress1);
                data.Add("shipaddress2", x.ShipAddress2);
                data.Add("shipcity", x.ShipCity);
                data.Add("shipstate", x.ShipState);
                data.Add("shipzip", x.ShipZip);
                data.Add("shipcountry", x.ShipCountry);
                data.Add("shipphone", x.ShipPhone);
                data.Add("shipemail", x.ShipEmail);
            }

            if (billing != null)
            {
                var x = billing;
                data.Add("firstname", x.FirstName);
                data.Add("lastname", x.LastName);
                data.Add("company", x.Company);
                data.Add("address1", x.Address1);
                data.Add("address2", x.Address2);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("phone", x.Phone);
                data.Add("fax", x.Fax);
                data.Add("email", x.Email);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

    }
}
