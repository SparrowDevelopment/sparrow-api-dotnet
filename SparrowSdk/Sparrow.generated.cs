using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SparrowSdk
{
    public partial class Sparrow
    {
        // --- Enums ---


        public enum AchAccountType
        {
            Checking,
            Savings
        }

        public enum AchAccountSubType
        {
            Business,
            Personal
        }

        public enum StopOverCode
        {
            SPACE,
            O,
            X
        }

        public enum AuthCharIndicator
        {
            SPACE,
            A,
            E,
            F,
            I,
            C,
            K,
            M,
            N,
            P,
            R,
            S,
            T,
            U,
            V,
            W
        }

        public enum PayType
        {
            Creditcard,
            Check,
            Ach,
            Starcard,
            Ewallet
        }

        public enum InvoiceStatus
        {
            Draft,
            Active
        }

        public enum InvoiceSource
        {
            Checkoutapi,
            Datavault
        }

        public enum OptAmountType
        {
            Tip,
            Surcharge
        }

        public enum RetryType
        {
            Daily,
            Weekly,
            Monthly
        }

        public enum NotifyPlanSummaryInterval
        {
            Daily,
            Weekly,
            Monthly,
            Quaterly
        }

        public enum ScheduleType
        {
            Monthly,
            Custom,
            Annual
        }

        public enum OperationType
        {
            Addsequence,
            Updatesequence
        }

        public enum ShipCarrier
        {
            Ups,
            Fedex,
            Dhl,
            Usps
        }

        // --- Common Objects ---

        public class Address
        {
            /// <summary>
            /// Billing address. Should be from 1-200 alpha-numeric characters and can include # - : ;
            /// </summary>
            public string Address1 { get; set; } = "";
            /// <summary>
            /// Billing city, should be 1-50 alpha characters
            /// </summary>
            public string City { get; set; } = "";
            /// <summary>
            /// Billing state (2 character abbreviation)
            /// </summary>
            public string State { get; set; } = "";
            /// <summary>
            /// Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx
            /// </summary>
            public string Zip { get; set; } = "";
            /// <summary>
            /// Billing country (ie. US)
            /// </summary>
            public string Country { get; set; } = "";
            /// <summary>
            /// Billing address - line 2. Should be from 1-200 alpha-numeric characters and can include # - : ;
            /// </summary>
            public string Address2 { get; set; } = "";
        }

        public class ContactInfo
        {
            /// <summary>
            /// Customer's first name
            /// </summary>
            public string FirstName { get; set; }
            /// <summary>
            /// Customer's last name
            /// </summary>
            public string LastName { get; set; }
            /// <summary>
            /// Birthdate of the customer
            /// </summary>
            public DateTime? BirthDate { get; set; } = null;
            /// <summary>
            /// Billing Company
            /// </summary>
            public string Company { get; set; } = "";
            /// <summary>
            /// Address
            /// </summary>
            public Address Address { get; set; } = null;
            /// <summary>
            /// Billing phone number, 10 digits
            /// </summary>
            public string Phone { get; set; } = "";
            /// <summary>
            /// Billing email address
            /// </summary>
            public string Email { get; set; } = "";
        }

        public class ShippingAddress
        {
            /// <summary>
            /// Shipping address
            /// </summary>
            public string ShipAddress1 { get; set; } = "";
            /// <summary>
            /// Shipping city
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
            /// Shipping address - line 2
            /// </summary>
            public string ShipAddress2 { get; set; } = "";
        }

        public class ShippingContactInfo
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
            public ShippingAddress ShippingAddress { get; set; } = null;
            /// <summary>
            /// Shipping phone number, 10 digits
            /// </summary>
            public string ShipPhone { get; set; } = "";
            /// <summary>
            /// Shipping email
            /// </summary>
            public string ShipEmail { get; set; } = "";
        }

        public class ClientAccount
        {
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
        }

        public class Product
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

        public class InvoiceProduct
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

        public class SequenceStep
        {
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
            public ScheduleType ScheduleType { get; set; }
            /// <summary>
            /// Day of the month for processing payments (scheduletype=monthly) or number of days between payments (scheduletype=custom)
            /// </summary>
            public int ScheduleDay { get; set; }
            /// <summary>
            /// Positive number of charges or -1 if no limit
            /// </summary>
            public int Duration { get; set; }
            /// <summary>
            /// Addsequence will add a new sequence, whereas Updatesequence will update an existing sequence
            /// </summary>
            public OperationType OperationType { get; set; }
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

        public class SequenceStepToDelete
        {
            /// <summary>
            /// Sequence to be deleted
            /// </summary>
            public int Sequence { get; set; }
        }

        public class OptionalAmount
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

        public class BankAccount
        {
            /// <summary>
            /// Customers bank name
            /// </summary>
            public string BankName { get; set; }
            /// <summary>
            /// Customers bank routing number
            /// </summary>
            public string Routing { get; set; }
            /// <summary>
            /// Customers bank account number
            /// </summary>
            public string Account { get; set; }
            /// <summary>
            /// Customers type of bank account
            /// </summary>
            public AchAccountType AchAccountType { get; set; }
            /// <summary>
            /// Customers type of bank account
            /// </summary>
            public AchAccountSubType AchAccountSubType { get; set; }
        }

        public class CreditCard
        {
            /// <summary>
            /// Credit card number
            /// </summary>
            public string CardNum { get; set; }
            /// <summary>
            /// Credit card expiration (ie 0719 = 07/2019)
            /// </summary>
            public DateTime CardExp { get; set; }
            /// <summary>
            /// Card security code
            /// </summary>
            public string Cvv { get; set; } = "";
        }

        public class Ewallet
        {
            /// <summary>
            /// eWallet account credentials (ie email address associated with the customers paypal account)
            /// </summary>
            public string EwalletAccount { get; set; }
        }

        public class PaymentType
        {
            /// <summary>
            /// Type of payment info
            /// </summary>
            public PayType PayType { get; set; } = PayType.Creditcard;
            /// <summary>
            /// Priority of the payment type among others when sending payment using the customertoken
            /// </summary>
            public int? PayNo { get; set; } = null;
            /// <summary>
            /// Contact Info
            /// </summary>
            public ContactInfo ContactInfo { get; set; } = null;
            /// <summary>
            /// Credit Card
            /// </summary>
            public CreditCard CreditCard { get; set; } = null;
            /// <summary>
            /// Bank Account
            /// </summary>
            public BankAccount BankAccount { get; set; }
            /// <summary>
            /// eWallet Account
            /// </summary>
            public Ewallet Ewallet { get; set; }
        }

        public class PaymentTypeToUpdate
        {
            /// <summary>
            /// Unique payment type identifier
            /// </summary>
            public string Token { get; set; }
            /// <summary>
            /// Payment Type
            /// </summary>
            public PaymentType PaymentType { get; set; } = null;
        }

        public class PaymentTypeToAdd
        {
            /// <summary>
            /// Payment Type
            /// </summary>
            public PaymentType PaymentType { get; set; }
        }

        public class PaymentTypeToDelete
        {
            /// <summary>
            /// Token of the payment type to be deleted
            /// </summary>
            public string Token { get; set; }
        }

        public class DefaultKeys
        {
            /// <summary>
            /// Merchant key of ACH account with which plan payments should be processed by default
            /// </summary>
            public string DefaultAchMKey { get; set; } = "";
            /// <summary>
            /// Merchant key of Credit Card account with which plan payments should be processed by default
            /// </summary>
            public string DefaultCreditCardMKey { get; set; } = "";
            /// <summary>
            /// Merchant key of eCheck account with which plan payments should be processed by default
            /// </summary>
            public string DefaultEcheckMKey { get; set; } = "";
            /// <summary>
            /// Merchant key of Star Card account with which plan payments should be processed by default
            /// </summary>
            public string DefaultStartCardMKey { get; set; } = "";
            /// <summary>
            /// Merchant key of eWallet account with which plan payments should be processed by default
            /// </summary>
            public string DefaultEwalletMKey { get; set; } = "";
        }

        public class NotificationOptions
        {
            /// <summary>
            /// Sends notification emails to the client if failed payments occur
            /// </summary>
            public bool? NotifyFailures { get; set; } = null;
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
            public NotifyPlanSummaryInterval NotifyPlanSummaryInterval { get; set; } = NotifyPlanSummaryInterval.Daily;
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

        public class SendTransReceiptOptions
        {
            /// <summary>
            /// Send multiple transaction receipts to customers. Multiple email must be separated by commas.
            /// </summary>
            public string SendTransReceiptToEmails { get; set; } = "";
            /// <summary>
            /// If true, this will send a transaction receipt to the billing email if present
            /// </summary>
            public bool? SendTransReceiptToBillEmail { get; set; } = null;
            /// <summary>
            /// If true, this will send a transaction receipt to the shipping email if present
            /// </summary>
            public bool? SendTransReceiptToShipEmail { get; set; } = null;
        }

        public class DriversLicense
        {
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
        }


        // --- Content ---

        /// <summary>
        /// Advanced eCheck
        /// </summary>
        /// <remarks>
        /// ach/advanced-echeck-sale.md - Advanced eCheck
        /// </remarks>
        /// <param name="transType">Sale Transaction (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (Format: d.dd)</param>,
        /// <param name="orderDesc">Order Description</param>,
        /// <param name="orderId">Order ID</param>,
        /// <param name="saveClient">If parameter 'saveclient' = true and the customer is identified as new, then a new Data Vault client will be created with payment/contact info from the transaction data and DV token will be generated. The payment transaction will be assigned to this new DV client. (Format: true/false)</param>,
        /// <param name="updateClient">If the parameter 'updateclient' = true and the DataVault finds the client according to customer identification rules, then the payment transaction will be assigned to the DataVault client and the DataVault client payment/contact info will be updated according to the transaction's data. (Format: true/false)</param>,
        /// <param name="bankAccount">BankAccount</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>,
        /// <param name="optionalAmount">OptionalAmount</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>
        public async Task<SparrowResponse> AdvancedECheck(BankAccount bankAccount, decimal amount, ContactInfo contactInfo, ShippingContactInfo shippingContactInfo = null, string orderDesc = "", string orderId = "", bool? saveClient = null, bool? updateClient = null, IList<OptionalAmount> optionalAmount = null, SendTransReceiptOptions sendTransReceiptOptions = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "orderDesc", orderDesc },
                { "orderId", orderId },
                { "saveClient", saveClient == true ? "true" : "false" },
                { "updateClient", updateClient == true ? "true" : "false" }
            };


            if (bankAccount != null)
            {
                var x = bankAccount;
                data.Add("bankName", x.BankName);
                data.Add("routing", x.Routing);
                data.Add("account", x.Account);
                data.Add("achAccountType", EnumToString(x.AchAccountType));
                data.Add("achAccountSubType", EnumToString(x.AchAccountSubType));
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            if (optionalAmount != null)
            {
                for (int i = 0; i < optionalAmount.Count; i++)
                {
                    var x = optionalAmount[i];
                    data.Add("optAmountType_" + (i + 1), x.OptAmountType);
                    data.Add("optAmountValue_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("optAmountPercentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced ACH
        /// </summary>
        /// <remarks>
        /// ach/advanced-sale.md - Advanced ACH
        /// </remarks>
        /// <param name="transType">Sale Transaction (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (Format: d.dd)</param>,
        /// <param name="orderDesc">Order Description</param>,
        /// <param name="orderId">Order ID</param>,
        /// <param name="saveClient">If parameter 'saveclient' = true and the customer is identified as new, then a new Data Vault client will be created with payment/contact info from the transaction data and DV token will be generated. The payment transaction will be assigned to this new DV client. (Format: true/false)</param>,
        /// <param name="updateClient">If the parameter 'updateclient' = true and the DataVault finds the client according to customer identification rules, then the payment transaction will be assigned to the DataVault client and the DataVault client payment/contact info will be updated according to the transaction's data. (Format: true/false)</param>,
        /// <param name="checkNumber">Check number. 1-15 alphanumeric characters</param>,
        /// <param name="courtesyCardId">This field is optional only for GETI ACH, for other processors can be ignored. From 1 to 50 characters. (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="bankAccount">BankAccount</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>,
        /// <param name="optionalAmount">OptionalAmount</param>,
        /// <param name="driversLicense">DriversLicense</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>
        public async Task<SparrowResponse> AdvancedACH(BankAccount bankAccount, decimal amount, ContactInfo contactInfo, string orderDesc = "", string orderId = "", ShippingContactInfo shippingContactInfo = null, bool? saveClient = null, bool? updateClient = null, IList<OptionalAmount> optionalAmount = null, string checkNumber = "", DriversLicense driversLicense = null, string courtesyCardId = "", SendTransReceiptOptions sendTransReceiptOptions = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "orderDesc", orderDesc },
                { "orderId", orderId },
                { "saveClient", saveClient == true ? "true" : "false" },
                { "updateClient", updateClient == true ? "true" : "false" },
                { "checkNumber", checkNumber },
                { "courtesyCardId", courtesyCardId }
            };


            if (bankAccount != null)
            {
                var x = bankAccount;
                data.Add("bankName", x.BankName);
                data.Add("routing", x.Routing);
                data.Add("account", x.Account);
                data.Add("achAccountType", EnumToString(x.AchAccountType));
                data.Add("achAccountSubType", EnumToString(x.AchAccountSubType));
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            if (optionalAmount != null)
            {
                for (int i = 0; i < optionalAmount.Count; i++)
                {
                    var x = optionalAmount[i];
                    data.Add("optAmountType_" + (i + 1), x.OptAmountType);
                    data.Add("optAmountValue_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("optAmountPercentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            if (driversLicense != null)
            {
                var x = driversLicense;
                data.Add("driverLicenseNumber", x.DriverLicenseNumber);
                data.Add("driverLicenseCountry", x.DriverLicenseCountry);
                data.Add("driverLicenseState", x.DriverLicenseState);
            }

            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple ACH
        /// </summary>
        /// <remarks>
        /// ach/simple-ach.md - Simple ACH
        /// </remarks>
        /// <param name="transType">Sale Transaction (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (Format: d.dd)</param>,
        /// <param name="bankAccount">BankAccount</param>,
        /// <param name="contactInfo">ContactInfo</param>
        public async Task<SparrowResponse> SimpleACH(BankAccount bankAccount, decimal amount, ContactInfo contactInfo)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") }
            };


            if (bankAccount != null)
            {
                var x = bankAccount;
                data.Add("bankName", x.BankName);
                data.Add("routing", x.Routing);
                data.Add("account", x.Account);
                data.Add("achAccountType", EnumToString(x.AchAccountType));
                data.Add("achAccountSubType", EnumToString(x.AchAccountSubType));
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple eCheck
        /// </summary>
        /// <remarks>
        /// ach/simple-echeck.md - Simple eCheck
        /// </remarks>
        /// <param name="transType">Sale Transaction (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (Format: d.dd)</param>,
        /// <param name="bankAccount">BankAccount</param>,
        /// <param name="contactInfo">ContactInfo</param>
        public async Task<SparrowResponse> SimpleECheck(BankAccount bankAccount, decimal amount, ContactInfo contactInfo)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") }
            };


            if (bankAccount != null)
            {
                var x = bankAccount;
                data.Add("bankName", x.BankName);
                data.Add("routing", x.Routing);
                data.Add("account", x.Account);
                data.Add("achAccountType", EnumToString(x.AchAccountType));
                data.Add("achAccountSubType", EnumToString(x.AchAccountSubType));
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Passenger Sale
        /// </summary>
        /// <remarks>
        /// airline-passenger-sale/passenger-sale.md - Passenger Sale
        /// </remarks>
        /// <param name="transType">Transaction Sale (Format: passengersale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="passengerName">First and last name of the passenger, 1-20 characters (Format: [a-z, A-Z, 0-9, ‘ ’])</param>,
        /// <param name="stopOverCode"> (Format: [ |O|X])</param>,
        /// <param name="airportCode">Airport Codes, 3 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="carrierCoupon">2 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="airlineCodeNumber">3 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="ticketNumber">10 characters (Format: [0-9])</param>,
        /// <param name="classOfServiceCoupon">1 or 2 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="flightDateCoupon">Departure date (Format: MM/DD/YYYY)</param>,
        /// <param name="flightDepartureTimeCoupon">Departure time (Format: HH:mm (military))</param>,
        /// <param name="addressVerificationCode">1 character (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="approvalCode">6 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="transactionId">The field must be forwarded when sent from TSYS, or manually filled with zeros. 15 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="authCharIndicator">Used as Returned Authorization Characteristics Indicator. Must contain the value returned in authorization response (ic case of online auth) (Format: [ |A|E|F|I|C|K|M|N|P|R|S|T|U|V|W])</param>,
        /// <param name="referenceNumber">12 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="validationCode">4 characters (Format: [a-z, A-Z, 0-9])</param>,
        /// <param name="authResponseCode">2 characters (Format: [a-zA-Z0-9 ] or two spaces)</param>,
        /// <param name="creditCard">CreditCard</param>
        public async Task<SparrowResponse> PassengerSale(CreditCard creditCard, decimal amount, string passengerName, IList<string> airportCodes, string airlineCodeNumber, string ticketNumber, IList<DateTime> flightDateCoupons, IList<string> flightDepartureTimeCoupons, string approvalCode, AuthCharIndicator authCharIndicator, string validationCode, string authResponseCode, StopOverCode stopOverCode = StopOverCode.SPACE, IList<string> carrierCoupons = null, IList<string> classOfServiceCoupons = null, string addressVerificationCode = "", string transactionId = "", string referenceNumber = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "passengersale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "passengerName", passengerName },
                { "stopOverCode", EnumToString(stopOverCode) },
                { "airlineCodeNumber", airlineCodeNumber },
                { "ticketNumber", ticketNumber },
                { "addressVerificationCode", addressVerificationCode },
                { "approvalCode", approvalCode },
                { "transactionId", transactionId },
                { "authCharIndicator", EnumToString(authCharIndicator) },
                { "referenceNumber", referenceNumber },
                { "validationCode", validationCode },
                { "authResponseCode", authResponseCode }
            };


            if (airportCodes != null)
            {
                for (int i = 0; i < airportCodes.Count; i++)
                {
                    data.Add("airportCodes" + (i + 1), airportCodes[i]);
                }
            }

            if (carrierCoupons != null)
            {
                for (int i = 0; i < carrierCoupons.Count; i++)
                {
                    data.Add("carrierCoupons" + (i + 1), carrierCoupons[i]);
                }
            }

            if (classOfServiceCoupons != null)
            {
                for (int i = 0; i < classOfServiceCoupons.Count; i++)
                {
                    data.Add("classOfServiceCoupons" + (i + 1), classOfServiceCoupons[i]);
                }
            }

            if (flightDateCoupons != null)
            {
                for (int i = 0; i < flightDateCoupons.Count; i++)
                {
                    data.Add("flightDateCoupons" + (i + 1), flightDateCoupons[i].ToString("MM/dd/yy"));
                }
            }

            if (flightDepartureTimeCoupons != null)
            {
                for (int i = 0; i < flightDepartureTimeCoupons.Count; i++)
                {
                    data.Add("flightDepartureTimeCoupons" + (i + 1), flightDepartureTimeCoupons[i]);
                }
            }

            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Retrieve Card Balance
        /// </summary>
        /// <remarks>
        /// balance-inquiry/check-balance.md - Retrieve Card Balance
        /// </remarks>
        /// <param name="transType">Balanceinquire returns the available card balance (Format: balanceinquire)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>
        public async Task<SparrowResponse> RetrieveCardBalance(string cardNum)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "balanceinquire" },
                { "mKey", _apiKey },
                { "cardNum", cardNum }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Verify Account
        /// </summary>
        /// <remarks>
        /// cc-verification/card-verification.md - Account Verification
        /// </remarks>
        /// <param name="transType">auth (Format: auth)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged should be 0.00 (Format: d.dd)</param>,
        /// <param name="zip">Billing postal code. If the country is US zip code format must be 5 digits or 9 digits. Example xxxxx, xxxxxxxxx or xxxxx-xxxx</param>,
        /// <param name="creditCard">CreditCard</param>
        public async Task<SparrowResponse> VerifyAccount(CreditCard creditCard, decimal amount, string zip = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "auth" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "zip", zip }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Mark a successful transaction as a Chargeback
        /// </summary>
        /// <remarks>
        /// chargeback/mark-chargeback.md - Marking a successful transaction as a Chargeback
        /// </remarks>
        /// <param name="transType">Chargeback will mark the transaction as “disputed” (Format: chargeback)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="reason">Description of the reason for the chargeback (Format: alphanumeric)</param>
        public async Task<SparrowResponse> MarkSuccessfulTransactionAsChargeback(string transId, string reason)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "chargeback" },
                { "mKey", _apiKey },
                { "transId", transId },
                { "reason", reason }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Credit
        /// </summary>
        /// <remarks>
        /// creating-a-credit/simple-credit.md - Simple Credit
        /// </remarks>
        /// <param name="transType">sale = Transaction Sale (Format: credit)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="creditCard">CreditCard</param>
        public async Task<SparrowResponse> SimpleCredit(CreditCard creditCard, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "credit" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced Sale
        /// </summary>
        /// <remarks>
        /// creating-a-sale/advanced-sale.md - Advanced Sale
        /// </remarks>
        /// <param name="transType">Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="currency">Code of the payment currency. If currency is not specified, the default currency (USD) is assumed. (Format: CCC (ISO 4217 alphabetic code))</param>,
        /// <param name="orderDesc">Order Description</param>,
        /// <param name="orderId">Order ID</param>,
        /// <param name="cardIpAddress">IP address of the customer, can be used for fraud prevention in FBI Tools (Format: ddd.ddd.ddd.ddd)</param>,
        /// <param name="tax">Total tax amount (Format: d.dd)</param>,
        /// <param name="shipAmount">Total shipping amount (Format: d.dd)</param>,
        /// <param name="poNumber">Original Purchase Order</param>,
        /// <param name="fax">Billing fax number</param>,
        /// <param name="token">Customer or customer payment info unique identifier. (Format: [A-Z, 0-9])</param>,
        /// <param name="saveClient">If parameter 'saveclient' = true and the customer is identified as new, then a new Data Vault client will be created with payment/contact info from the transaction data and DV token will be generated. The payment transaction will be assigned to this new DV client. (Format: true / false)</param>,
        /// <param name="updateClient">If the parameter 'updateclient' = true and the DataVault finds the client according to customer identification rules, then the payment transaction will be assigned to the DataVault client and the DataVault client payment/contact info will be updated according to the transaction's data. (Format: true / false)</param>,
        /// <param name="groupId">Group ID of the Split Funding group. If groupid is defined for the transaction system splits it in accordance with group settings. (Format: alphanumeric)</param>,
        /// <param name="pinlessDebitIndicator">For Chase Processor only. Indicator to process PIN-less debit transactions. (Format: true / false)</param>,
        /// <param name="sendPaymentDesc">Overrides ‘Send Payment Descriptor’ account setting for the transaction. (Format: true / false)</param>,
        /// <param name="creditCard">CreditCard</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="product">Product</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>,
        /// <param name="optionalAmount">OptionalAmount</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>
        public async Task<SparrowResponse> AdvancedSale(CreditCard creditCard, decimal amount, string currency = "", ContactInfo contactInfo = null, IList<Product> product = null, string orderDesc = "", string orderId = "", string cardIpAddress = "", decimal? tax = null, decimal? shipAmount = null, string poNumber = "", string fax = "", ShippingContactInfo shippingContactInfo = null, IList<OptionalAmount> optionalAmount = null, SendTransReceiptOptions sendTransReceiptOptions = null, string token = "", bool? saveClient = null, bool? updateClient = null, string groupId = "", bool? pinlessDebitIndicator = null, bool? sendPaymentDesc = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "currency", currency },
                { "orderDesc", orderDesc },
                { "orderId", orderId },
                { "cardIpAddress", cardIpAddress },
                { "tax", tax?.ToString("f2") ?? "" },
                { "shipAmount", shipAmount?.ToString("f2") ?? "" },
                { "poNumber", poNumber },
                { "fax", fax },
                { "token", token },
                { "saveClient", saveClient == true ? "true" : "false" },
                { "updateClient", updateClient == true ? "true" : "false" },
                { "groupId", groupId },
                { "pinlessDebitIndicator", pinlessDebitIndicator == true ? "true" : "false" },
                { "sendPaymentDesc", sendPaymentDesc == true ? "true" : "false" }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (product != null)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    var x = product[i];
                    data.Add("skuNumber_" + (i + 1), x.SkuNumber);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("amount_" + (i + 1), x.Amount?.ToString("f2") ?? "");
                    data.Add("quantity_" + (i + 1), "" + x.Quantity);
                }
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            if (optionalAmount != null)
            {
                for (int i = 0; i < optionalAmount.Count; i++)
                {
                    var x = optionalAmount[i];
                    data.Add("optAmountType_" + (i + 1), x.OptAmountType);
                    data.Add("optAmountValue_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("optAmountPercentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Sale
        /// </summary>
        /// <remarks>
        /// creating-a-sale/simple-sale.md - Simple Sale
        /// </remarks>
        /// <param name="transType">sale = Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="creditCard">CreditCard</param>
        public async Task<SparrowResponse> SimpleSale(CreditCard creditCard, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Add Payment Types to a Customer
        /// </summary>
        /// <remarks>
        /// datavault/add-payment-type.md - Adding Payment Types to a Customer
        /// </remarks>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: updatecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>,
        /// <param name="paymentTypeToAdd">PaymentTypeToAdd</param>
        public async Task<SparrowResponse> AddPaymentTypesToCustomer(string token, IList<PaymentTypeToAdd> paymentTypeToAdd)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updatecustomer" },
                { "token", token }
            };


            if (paymentTypeToAdd != null)
            {
                for (int i = 0; i < paymentTypeToAdd.Count; i++)
                {
                    var x = paymentTypeToAdd[i];
                    data.Add("operationType_" + (i + 1), "addpaytype");
                    data.Add("payType_" + (i + 1), EnumToString(x.PaymentType?.PayType));
                    data.Add("payNo_" + (i + 1), "" + x.PaymentType?.PayNo);
                    data.Add("firstName_" + (i + 1), x.PaymentType?.ContactInfo?.FirstName);
                    data.Add("lastName_" + (i + 1), x.PaymentType?.ContactInfo?.LastName);
                    data.Add("company_" + (i + 1), x.PaymentType?.ContactInfo?.Company);
                    data.Add("address1_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Address1);
                    data.Add("city_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.City);
                    data.Add("state_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.State);
                    data.Add("zip_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Zip);
                    data.Add("country_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Country);
                    data.Add("address2_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Address2);
                    data.Add("phone_" + (i + 1), x.PaymentType?.ContactInfo?.Phone);
                    data.Add("email_" + (i + 1), x.PaymentType?.ContactInfo?.Email);
                    data.Add("cardNum_" + (i + 1), x.PaymentType?.CreditCard?.CardNum);
                    data.Add("cardExp_" + (i + 1), x.PaymentType?.CreditCard?.CardExp.ToString("MMyy"));
                    data.Add("cvv_" + (i + 1), x.PaymentType?.CreditCard?.Cvv);
                    data.Add("bankName_" + (i + 1), x.PaymentType?.BankAccount?.BankName);
                    data.Add("routing_" + (i + 1), x.PaymentType?.BankAccount?.Routing);
                    data.Add("account_" + (i + 1), x.PaymentType?.BankAccount?.Account);
                    data.Add("achAccountType_" + (i + 1), EnumToString(x.PaymentType?.BankAccount?.AchAccountType));
                    data.Add("achAccountSubType_" + (i + 1), EnumToString(x.PaymentType?.BankAccount?.AchAccountSubType));
                    data.Add("ewalletAccount_" + (i + 1), x.PaymentType?.Ewallet?.EwalletAccount);
                    data.Add("ewalletType_" + (i + 1), "paypal");
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Add a Customer
        /// </summary>
        /// <remarks>
        /// datavault/adding-a-customer.md - Adding a Customer
        /// </remarks>
        /// <param name="transType">Add customer will create a new Data Vault entry (Format: addcustomer)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="customerId">External customer identifier</param>,
        /// <param name="note">Customer note</param>,
        /// <param name="defaultContactInfo">ContactInfo</param>,
        /// <param name="defaultAddress">Address</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>,
        /// <param name="clientAccount">ClientAccount</param>,
        /// <param name="paymentType">PaymentType</param>
        public async Task<SparrowResponse> AddCustomer(ContactInfo defaultContactInfo, IList<PaymentType> paymentType, string customerId = "", string note = "", Address defaultAddress = null, ShippingContactInfo shippingContactInfo = null, ClientAccount clientAccount = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "addcustomer" },
                { "mKey", _apiKey },
                { "customerId", customerId },
                { "note", note }
            };


            if (defaultContactInfo != null)
            {
                var x = defaultContactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (defaultAddress != null)
            {
                var x = defaultAddress;
                data.Add("address1", x.Address1);
                data.Add("city", x.City);
                data.Add("state", x.State);
                data.Add("zip", x.Zip);
                data.Add("country", x.Country);
                data.Add("address2", x.Address2);
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            if (clientAccount != null)
            {
                var x = clientAccount;
                data.Add("userName", x.UserName);
                data.Add("password", x.Password);
                data.Add("clientUserEmail", x.ClientUserEmail);
            }

            if (paymentType != null)
            {
                for (int i = 0; i < paymentType.Count; i++)
                {
                    var x = paymentType[i];
                    data.Add("payType_" + (i + 1), EnumToString(x.PayType));
                    data.Add("payNo_" + (i + 1), "" + x.PayNo);
                    data.Add("firstName_" + (i + 1), x.ContactInfo?.FirstName);
                    data.Add("lastName_" + (i + 1), x.ContactInfo?.LastName);
                    data.Add("company_" + (i + 1), x.ContactInfo?.Company);
                    data.Add("address1_" + (i + 1), x.ContactInfo?.Address?.Address1);
                    data.Add("city_" + (i + 1), x.ContactInfo?.Address?.City);
                    data.Add("state_" + (i + 1), x.ContactInfo?.Address?.State);
                    data.Add("zip_" + (i + 1), x.ContactInfo?.Address?.Zip);
                    data.Add("country_" + (i + 1), x.ContactInfo?.Address?.Country);
                    data.Add("address2_" + (i + 1), x.ContactInfo?.Address?.Address2);
                    data.Add("phone_" + (i + 1), x.ContactInfo?.Phone);
                    data.Add("email_" + (i + 1), x.ContactInfo?.Email);
                    data.Add("cardNum_" + (i + 1), x.CreditCard?.CardNum);
                    data.Add("cardExp_" + (i + 1), x.CreditCard?.CardExp.ToString("MMyy"));
                    data.Add("cvv_" + (i + 1), x.CreditCard?.Cvv);
                    data.Add("bankName_" + (i + 1), x.BankAccount?.BankName);
                    data.Add("routing_" + (i + 1), x.BankAccount?.Routing);
                    data.Add("account_" + (i + 1), x.BankAccount?.Account);
                    data.Add("achAccountType_" + (i + 1), EnumToString(x.BankAccount?.AchAccountType));
                    data.Add("achAccountSubType_" + (i + 1), EnumToString(x.BankAccount?.AchAccountSubType));
                    data.Add("ewalletAccount_" + (i + 1), x.Ewallet?.EwalletAccount);
                    data.Add("ewalletType_" + (i + 1), "paypal");
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Delete Data Vault Customer
        /// </summary>
        /// <remarks>
        /// datavault/delete-customer.md - Delete Data Vault Customer
        /// </remarks>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: deletecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>
        public async Task<SparrowResponse> DeleteDataVaultCustomer(string token)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "deletecustomer" },
                { "token", token }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Delete Payment Type
        /// </summary>
        /// <remarks>
        /// datavault/delete-payment-type.md - Delete Payment Type
        /// </remarks>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: updatecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>,
        /// <param name="paymentTypeToDelete">PaymentTypeToDelete</param>
        public async Task<SparrowResponse> DeletePaymentType(string token, IList<PaymentTypeToDelete> paymentTypeToDelete)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updatecustomer" },
                { "token", token }
            };


            if (paymentTypeToDelete != null)
            {
                for (int i = 0; i < paymentTypeToDelete.Count; i++)
                {
                    var x = paymentTypeToDelete[i];
                    data.Add("operationType_" + (i + 1), "deletepaytype");
                    data.Add("token_" + (i + 1), x.Token);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Retrieve Customer
        /// </summary>
        /// <remarks>
        /// datavault/get-customer.md - Retrieve Customer
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: getcustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumeric string)</param>
        public async Task<SparrowResponse> RetrieveCustomer(string token)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "getcustomer" },
                { "token", token }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Retrieve Payment Type
        /// </summary>
        /// <remarks>
        /// datavault/get-payment-type.md - Retrieve Payment Type
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: getcustomer)</param>,
        /// <param name="token">Unique payment type identifier (Format: alphanumeric string)</param>
        public async Task<SparrowResponse> RetrievePaymentType(string token)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "getcustomer" },
                { "token", token }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Update Customer
        /// </summary>
        /// <remarks>
        /// datavault/update-payment-type.md - Update Customer
        /// </remarks>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: updatecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>,
        /// <param name="clientAccount">ClientAccount</param>
        public async Task<SparrowResponse> UpdateCustomer(string token, ContactInfo contactInfo = null, ShippingContactInfo shippingContactInfo = null, ClientAccount clientAccount = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updatecustomer" },
                { "token", token }
            };


            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            if (clientAccount != null)
            {
                var x = clientAccount;
                data.Add("userName", x.UserName);
                data.Add("password", x.Password);
                data.Add("clientUserEmail", x.ClientUserEmail);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Update Payment Type
        /// </summary>
        /// <remarks>
        /// datavault/update-payment-types.md - Update Payment Type
        /// </remarks>
        /// <param name="mKey">Secured merchant key</param>,
        /// <param name="transType">This transaction type will update the current client information with any new data fields provided (Format: updatecustomer)</param>,
        /// <param name="token">Unique customer identifier (Format: alphanumericstring)</param>,
        /// <param name="paymentTypeToUpdate">PaymentTypeToUpdate</param>
        public async Task<SparrowResponse> UpdatePaymentType(string token, IList<PaymentTypeToUpdate> paymentTypeToUpdate)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updatecustomer" },
                { "token", token }
            };


            if (paymentTypeToUpdate != null)
            {
                for (int i = 0; i < paymentTypeToUpdate.Count; i++)
                {
                    var x = paymentTypeToUpdate[i];
                    data.Add("operationType_" + (i + 1), "updatepaytype");
                    data.Add("token_" + (i + 1), x.Token);
                    data.Add("payType_" + (i + 1), EnumToString(x.PaymentType?.PayType));
                    data.Add("payNo_" + (i + 1), "" + x.PaymentType?.PayNo);
                    data.Add("firstName_" + (i + 1), x.PaymentType?.ContactInfo?.FirstName);
                    data.Add("lastName_" + (i + 1), x.PaymentType?.ContactInfo?.LastName);
                    data.Add("company_" + (i + 1), x.PaymentType?.ContactInfo?.Company);
                    data.Add("address1_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Address1);
                    data.Add("city_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.City);
                    data.Add("state_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.State);
                    data.Add("zip_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Zip);
                    data.Add("country_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Country);
                    data.Add("address2_" + (i + 1), x.PaymentType?.ContactInfo?.Address?.Address2);
                    data.Add("phone_" + (i + 1), x.PaymentType?.ContactInfo?.Phone);
                    data.Add("email_" + (i + 1), x.PaymentType?.ContactInfo?.Email);
                    data.Add("cardNum_" + (i + 1), x.PaymentType?.CreditCard?.CardNum);
                    data.Add("cardExp_" + (i + 1), x.PaymentType?.CreditCard?.CardExp.ToString("MMyy"));
                    data.Add("cvv_" + (i + 1), x.PaymentType?.CreditCard?.Cvv);
                    data.Add("bankName_" + (i + 1), x.PaymentType?.BankAccount?.BankName);
                    data.Add("routing_" + (i + 1), x.PaymentType?.BankAccount?.Routing);
                    data.Add("account_" + (i + 1), x.PaymentType?.BankAccount?.Account);
                    data.Add("achAccountType_" + (i + 1), EnumToString(x.PaymentType?.BankAccount?.AchAccountType));
                    data.Add("achAccountSubType_" + (i + 1), EnumToString(x.PaymentType?.BankAccount?.AchAccountSubType));
                    data.Add("ewalletAccount_" + (i + 1), x.PaymentType?.Ewallet?.EwalletAccount);
                    data.Add("ewalletType_" + (i + 1), "paypal");
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Decrypt Custom Fields
        /// </summary>
        /// <remarks>
        /// decrypt-custom-field/decrypt.md - Decrypting Custom Fields
        /// </remarks>
        /// <param name="transType">The decrypt operation returns the value of the custom field (Format: decrypt)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="fieldName">Custom field name</param>,
        /// <param name="token">This is a unique Data Vault customer identifier or Data Vault payment type identifier (Format: alphanumeric string)</param>
        public async Task<SparrowResponse> DecryptCustomFields(string fieldName, string token)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "decrypt" },
                { "mKey", _apiKey },
                { "fieldName", fieldName },
                { "token", token }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// eWallet Simple Credit
        /// </summary>
        /// <remarks>
        /// ewallet/ewallet-credit.md - eWallet Simple Credit
        /// </remarks>
        /// <param name="transType">credit- funds being pushed to the customer (Format: credit)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="ewallet">Currently PayPal is the only eWallet type supported (Format: PayPal)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="currency">Code of the payment currency. If not currency is specified, the default is USD (Format: ccc)</param>,
        /// <param name="ewallet">Ewallet</param>
        public async Task<SparrowResponse> EWalletSimpleCredit(Ewallet ewallet, decimal amount, string currency = "")
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "credit" },
                { "mKey", _apiKey },
                { "ewallet", "paypal" },
                { "amount", amount.ToString("f2") },
                { "currency", currency }
            };


            if (ewallet != null)
            {
                var x = ewallet;
                data.Add("ewalletAccount", x.EwalletAccount);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced Fiserv Sale
        /// </summary>
        /// <remarks>
        /// fiserv/fiserv-advanced.md - Advanced Fiserv Sale
        /// </remarks>
        /// <param name="transType">Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="currency">Code of the payment currency. If currency is not specified, the default currency (USD) is assumed. (Format: CCC (ISO 4217 alphabetic code))</param>,
        /// <param name="orderDesc">Order Description</param>,
        /// <param name="orderId">Order ID</param>,
        /// <param name="cardIpAddress">IP address of the customer, can be used for fraud prevention in FBI Tools (Format: ddd.ddd.ddd.ddd)</param>,
        /// <param name="tax">Total tax amount (Format: d.dd)</param>,
        /// <param name="shipAmount">Total shipping amount (Format: d.dd)</param>,
        /// <param name="poNumber">Original Purchase Order</param>,
        /// <param name="creditCard">CreditCard</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="product">Product</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>
        public async Task<SparrowResponse> AdvancedFiservSale(CreditCard creditCard, decimal amount, string currency = "", ContactInfo contactInfo = null, IList<Product> product = null, string orderDesc = "", string orderId = "", string cardIpAddress = "", decimal? tax = null, decimal? shipAmount = null, string poNumber = "", ShippingContactInfo shippingContactInfo = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "currency", currency },
                { "orderDesc", orderDesc },
                { "orderId", orderId },
                { "cardIpAddress", cardIpAddress },
                { "tax", tax?.ToString("f2") ?? "" },
                { "shipAmount", shipAmount?.ToString("f2") ?? "" },
                { "poNumber", poNumber }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (product != null)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    var x = product[i];
                    data.Add("skuNumber_" + (i + 1), x.SkuNumber);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("amount_" + (i + 1), x.Amount?.ToString("f2") ?? "");
                    data.Add("quantity_" + (i + 1), "" + x.Quantity);
                }
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Fiserv Simple Sale
        /// </summary>
        /// <remarks>
        /// fiserv/fiserv-simple.md - Fiserv Simple Sale
        /// </remarks>
        /// <param name="transType">sale = Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0711 = 7/2011) (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>
        public async Task<SparrowResponse> FiservSimpleSale(string cardNum, DateTime cardExp, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "cardNum", cardNum },
                { "cardExp", cardExp.ToString("MMyy") },
                { "amount", amount.ToString("f2") }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Cancel Invoice by Customer
        /// </summary>
        /// <remarks>
        /// invoicing/cancel-inv-customer.md - Cancel Invoice by Customer
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: cancelinvoicebycustomer)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>,
        /// <param name="invoiceStatusReason">The reason of canceling the invoice (Format: alphanumeric)</param>
        public async Task<SparrowResponse> CancelInvoiceByCustomer(string invoiceNumber, string invoiceStatusReason)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "cancelinvoicebycustomer" },
                { "invoiceNumber", invoiceNumber },
                { "invoiceStatusReason", invoiceStatusReason }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Cancel Invoice
        /// </summary>
        /// <remarks>
        /// invoicing/cancel-invoice.md - Cancel Invoice
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: cancelinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>,
        /// <param name="invoiceStatusReason">The reason of canceling the invoice (Format: alphanumeric)</param>
        public async Task<SparrowResponse> CancelInvoice(string invoiceNumber, string invoiceStatusReason)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "cancelinvoice" },
                { "invoiceNumber", invoiceNumber },
                { "invoiceStatusReason", invoiceStatusReason }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Create an Invoice
        /// </summary>
        /// <remarks>
        /// invoicing/create-merchant-invoice.md - Creating an Invoice
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: createmerchantinvoice)</param>,
        /// <param name="customerToken">Unique data vault client identifier (Format: alphanumeric string)</param>,
        /// <param name="invoiceDate">The date of the invoice (Format: MM/DD/YYYY)</param>,
        /// <param name="currency">Code of the payment currency (Format: CCC (ISO 4217 alphabetic code))</param>,
        /// <param name="invoiceStatus">The status of the invoice. Only active invoices can be paid (Format: [draft|active])</param>,
        /// <param name="invoiceSource">The source of the invoice. If not specified, the default value is DataVault (Format: [checkoutapi|datavault])</param>,
        /// <param name="invoiceAmount">Total amount of invoice (i.e. 10.00). Required if product list is not specified (Format: d.dd)</param>,
        /// <param name="sendPaymentLinkEmail">If Invoice status is 'Active' email with Pay Invoice URL will be sent to specified email. (Format: email@email.com)</param>,
        /// <param name="invoiceProduct">InvoiceProduct</param>
        public async Task<SparrowResponse> CreateInvoice(DateTime invoiceDate, string currency, InvoiceStatus invoiceStatus, decimal invoiceAmount, string customerToken = "", InvoiceSource invoiceSource = InvoiceSource.Checkoutapi, IList<InvoiceProduct> invoiceProduct = null, string sendPaymentLinkEmail = "")
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "createmerchantinvoice" },
                { "customerToken", customerToken },
                { "invoiceDate", invoiceDate.ToString("MM/dd/yy") },
                { "currency", currency },
                { "invoiceStatus", EnumToString(invoiceStatus) },
                { "invoiceSource", EnumToString(invoiceSource) },
                { "invoiceAmount", invoiceAmount.ToString("f2") },
                { "sendPaymentLinkEmail", sendPaymentLinkEmail }
            };


            if (invoiceProduct != null)
            {
                for (int i = 0; i < invoiceProduct.Count; i++)
                {
                    var x = invoiceProduct[i];
                    data.Add("invoiceItemSku_" + (i + 1), x.InvoiceItemSku);
                    data.Add("invoiceItemDescription_" + (i + 1), x.InvoiceItemDescription);
                    data.Add("invoiceItemPrice_" + (i + 1), x.InvoiceItemPrice?.ToString("f2") ?? "");
                    data.Add("invoiceItemQuantity_" + (i + 1), x.InvoiceItemQuantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Retrieve Invoice
        /// </summary>
        /// <remarks>
        /// invoicing/get-invoice.md - Retrieve Invoice
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: getinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>
        public async Task<SparrowResponse> RetrieveInvoice(string invoiceNumber)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "getinvoice" },
                { "invoiceNumber", invoiceNumber }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Pay an Invoice with a Bank Account
        /// </summary>
        /// <remarks>
        /// invoicing/pay-inv-ach.md - Paying an Invoice with a Bank Account
        /// </remarks>
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="transType"> (Format: payinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv-[0-9])</param>,
        /// <param name="fax">Billing fax number</param>,
        /// <param name="bankAccount">BankAccount</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>
        public async Task<SparrowResponse> PayInvoiceWithBankAccount(string invoiceNumber, BankAccount bankAccount, ContactInfo contactInfo, string fax = "", ShippingContactInfo shippingContactInfo = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "payinvoice" },
                { "invoiceNumber", invoiceNumber },
                { "fax", fax }
            };


            if (bankAccount != null)
            {
                var x = bankAccount;
                data.Add("bankName", x.BankName);
                data.Add("routing", x.Routing);
                data.Add("account", x.Account);
                data.Add("achAccountType", EnumToString(x.AchAccountType));
                data.Add("achAccountSubType", EnumToString(x.AchAccountSubType));
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Pay an Invoice with a Credit Card
        /// </summary>
        /// <remarks>
        /// invoicing/pay-inv-cc.md - Paying an Invoice with a Credit Card
        /// </remarks>
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="transType"> (Format: payinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv-[0-9])</param>,
        /// <param name="fax">Billing fax number</param>,
        /// <param name="creditCard">CreditCard</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>
        public async Task<SparrowResponse> PayInvoiceWithCreditCard(string invoiceNumber, CreditCard creditCard, ContactInfo contactInfo = null, string fax = "", ShippingContactInfo shippingContactInfo = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "payinvoice" },
                { "invoiceNumber", invoiceNumber },
                { "fax", fax }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Update Invoice
        /// </summary>
        /// <remarks>
        /// invoicing/update-invoice.md - Update Invoice
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: updateinvoice)</param>,
        /// <param name="invoiceNumber">Unique invoice identifier (Format: Inv- [0-9])</param>,
        /// <param name="customerToken">Unique data vault client identifier (Format: alphanumeric string)</param>,
        /// <param name="invoiceDate">The date of the invoice (Format: MM/DD/YYYY)</param>,
        /// <param name="currency">Code of the payment currency (Format: CCC (ISO 4217 alphabetic code))</param>,
        /// <param name="invoiceStatus">The status of the invoice. Only active invoices can be paid (Format: [draft|active])</param>,
        /// <param name="invoiceSource">The source of the invoice. If not specified, the default value is DataVault (Format: [checkoutapi|datavault])</param>,
        /// <param name="invoiceAmount">Total amount of invoice (i.e. 10.00). Required if product list is not specified (Format: d.dd)</param>,
        /// <param name="sendPaymentLinkEmail">If Invoice status is 'Active' email with Pay Invoice URL will be sent to specified email. (Format: email@email.com)</param>,
        /// <param name="invoiceProduct">InvoiceProduct</param>
        public async Task<SparrowResponse> UpdateInvoice(string invoiceNumber, string customerToken = "", DateTime? invoiceDate = null, string currency = "", InvoiceStatus invoiceStatus = InvoiceStatus.Draft, InvoiceSource invoiceSource = InvoiceSource.Checkoutapi, decimal? invoiceAmount = null, IList<InvoiceProduct> invoiceProduct = null, string sendPaymentLinkEmail = "")
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updateinvoice" },
                { "invoiceNumber", invoiceNumber },
                { "customerToken", customerToken },
                { "invoiceDate", invoiceDate?.ToString("MM/dd/yy") ?? "" },
                { "currency", currency },
                { "invoiceStatus", EnumToString(invoiceStatus) },
                { "invoiceSource", EnumToString(invoiceSource) },
                { "invoiceAmount", invoiceAmount?.ToString("f2") ?? "" },
                { "sendPaymentLinkEmail", sendPaymentLinkEmail }
            };


            if (invoiceProduct != null)
            {
                for (int i = 0; i < invoiceProduct.Count; i++)
                {
                    var x = invoiceProduct[i];
                    data.Add("invoiceItemSku_" + (i + 1), x.InvoiceItemSku);
                    data.Add("invoiceItemDescription_" + (i + 1), x.InvoiceItemDescription);
                    data.Add("invoiceItemPrice_" + (i + 1), x.InvoiceItemPrice?.ToString("f2") ?? "");
                    data.Add("invoiceItemQuantity_" + (i + 1), x.InvoiceItemQuantity);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Refund
        /// </summary>
        /// <remarks>
        /// issuing-a-refund/Simple-refund.md - Simple Refund
        /// </remarks>
        /// <param name="transType">Refund (Format: refund)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="amount">Total amount to be refunded (Format: d.dd)</param>
        public async Task<SparrowResponse> SimpleRefund(string transId, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "refund" },
                { "mKey", _apiKey },
                { "transId", transId },
                { "amount", amount.ToString("f2") }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced Refund
        /// </summary>
        /// <remarks>
        /// issuing-a-refund/advanced-refund.md - Advanced Refund
        /// </remarks>
        /// <param name="transType">Refund (Format: refund)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="amount">Total amount to be refunded (Format: d.dd)</param>,
        /// <param name="optionalAmount">OptionalAmount</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>
        public async Task<SparrowResponse> AdvancedRefund(string transId, decimal amount, IList<OptionalAmount> optionalAmount = null, SendTransReceiptOptions sendTransReceiptOptions = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "refund" },
                { "mKey", _apiKey },
                { "transId", transId },
                { "amount", amount.ToString("f2") }
            };


            if (optionalAmount != null)
            {
                for (int i = 0; i < optionalAmount.Count; i++)
                {
                    var x = optionalAmount[i];
                    data.Add("optAmountType_" + (i + 1), x.OptAmountType);
                    data.Add("optAmountValue_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("optAmountPercentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced Void
        /// </summary>
        /// <remarks>
        /// issuing-a-void/advanced-void.md - Advanced Void
        /// </remarks>
        /// <param name="transType">Void (Format: void)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>
        public async Task<SparrowResponse> AdvancedVoid(string transId, SendTransReceiptOptions sendTransReceiptOptions = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "void" },
                { "mKey", _apiKey },
                { "transId", transId }
            };


            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Void
        /// </summary>
        /// <remarks>
        /// issuing-a-void/simple-void.md - Simple Void
        /// </remarks>
        /// <param name="transType">Void (Format: void)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original payment gateway transaction ID</param>
        public async Task<SparrowResponse> SimpleVoid(string transId)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "void" },
                { "mKey", _apiKey },
                { "transId", transId }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Assign a Payment Plan to a Customer
        /// </summary>
        /// <remarks>
        /// payment-plans/assign-payment-plan.md - Assigning a Payment Plan to a Customer
        /// </remarks>
        /// <param name="mKey">Secure merchant account key</param>,
        /// <param name="transType"> (Format: assignplan)</param>,
        /// <param name="customerToken">Customer unique identifier (Format: alphanumeric string)</param>,
        /// <param name="planToken">Recurring payment plan unique identifier; used when assigning existing plan to the customer (Format: alphanumeric string)</param>,
        /// <param name="paymentToken">Token of the customer’s payment type, if they have multiple (Format: alphanumeric string)</param>,
        /// <param name="startDate">Day of the first payment of the plan; if not present the plan’s start date (if it exists) is used. (Format: MM/DD/YYYY)</param>,
        /// <param name="productId">External ID for the product (Format: string)</param>,
        /// <param name="description">Description of plan assignment (Format: string)</param>,
        /// <param name="amount">Amount purchased. This field is required for layaway plan assignment and ignored otherwise (Format: d.dd)</param>,
        /// <param name="useRecycling">Specifies whether to reprocess failed transactions for this plan (Format: true/false)</param>,
        /// <param name="retryCount">Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise (Format: positive integer)</param>,
        /// <param name="retryType">Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date (Format: [daily|weekly|monthly])</param>,
        /// <param name="retryPeriod">Number of days between retry attempts. This field is required if retrytype=daily (Format: positive integer)</param>,
        /// <param name="retryDayOfWeek">This field is required if retrytype=weekly (monday, tuesday etc.) (Format: string)</param>,
        /// <param name="retryFirstDayOfMonth">First date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="retrySecondDayOfMonth">Second date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="proratedPayment">Specifies whether to add prorated payment in this plan (Format: true / false)</param>,
        /// <param name="routingKey">Merchant key of account with which plan payments should be processed by default. This account must be of the same type as selected customer’s payment type</param>,
        /// <param name="notificationOptions">NotificationOptions</param>
        public async Task<SparrowResponse> AssignPaymentPlanToCustomer(string customerToken, string planToken, string paymentToken, DateTime? startDate = null, string productId = "", string description = "", decimal? amount = null, NotificationOptions notificationOptions = null, bool? useRecycling = null, int? retryCount = null, RetryType retryType = RetryType.Daily, int? retryPeriod = null, string retryDayOfWeek = "", int? retryFirstDayOfMonth = null, int? retrySecondDayOfMonth = null, bool? proratedPayment = null, string routingKey = "")
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "assignplan" },
                { "customerToken", customerToken },
                { "planToken", planToken },
                { "paymentToken", paymentToken },
                { "startDate", startDate?.ToString("MM/dd/yy") ?? "" },
                { "productId", productId },
                { "description", description },
                { "amount", amount?.ToString("f2") ?? "" },
                { "useRecycling", useRecycling == true ? "true" : "false" },
                { "retryCount", "" + retryCount },
                { "retryType", EnumToString(retryType) },
                { "retryPeriod", "" + retryPeriod },
                { "retryDayOfWeek", retryDayOfWeek },
                { "retryFirstDayOfMonth", "" + retryFirstDayOfMonth },
                { "retrySecondDayOfMonth", "" + retrySecondDayOfMonth },
                { "proratedPayment", proratedPayment == true ? "true" : "false" },
                { "routingKey", routingKey }
            };


            if (notificationOptions != null)
            {
                var x = notificationOptions;
                data.Add("notifyFailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("notifyUpcomingPayment", x.NotifyUpcomingPayment == true ? "true" : "false");
                data.Add("notifyDaysBeforeUpcomingPayment", "" + x.NotifyDaysBeforeUpcomingPayment);
                data.Add("notifyPlanSummary", x.NotifyPlanSummary == true ? "true" : "false");
                data.Add("notifyPlanSummaryInterval", EnumToString(x.NotifyPlanSummaryInterval));
                data.Add("notifyPlanSummaryEmails", x.NotifyPlanSummaryEmails);
                data.Add("notifyDailyStats", x.NotifyDailyStats == true ? "true" : "false");
                data.Add("notifyDailyStatsEmails", x.NotifyDailyStatsEmails);
                data.Add("notifyPlanComplete", x.NotifyPlanComplete == true ? "true" : "false");
                data.Add("notifyPlanCompleteEmails", x.NotifyPlanCompleteEmails);
                data.Add("notifyDecline", x.NotifyDecline == true ? "true" : "false");
                data.Add("notifyDeclineEmails", x.NotifyDeclineEmails);
                data.Add("notifyViaFtp", x.NotifyViaFtp == true ? "true" : "false");
                data.Add("notifyViaFtpUrl", x.NotifyViaFtpUrl == true ? "true" : "false");
                data.Add("notifyViaFtpUserName", x.NotifyViaFtpUserName);
                data.Add("notifyViaFtpPassword", x.NotifyViaFtpPassword);
                data.Add("notifyFlagged", x.NotifyFlagged == true ? "true" : "false");
                data.Add("notifyFlaggedEmails", x.NotifyFlaggedEmails);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Cancel Plan Assignment
        /// </summary>
        /// <remarks>
        /// payment-plans/cancel-plan-assignment.md - Cancel Plan Assignment
        /// </remarks>
        /// <param name="mKey">Secure merchant account key</param>,
        /// <param name="transType"> (Format: cancelassignment)</param>,
        /// <param name="assignmentToken">Unique identifier of payment plan assignment (Format: alphanumeric string)</param>
        public async Task<SparrowResponse> CancelPlanAssignment(string assignmentToken)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "cancelassignment" },
                { "assignmentToken", assignmentToken }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Create a Payment Plan
        /// </summary>
        /// <remarks>
        /// payment-plans/create-plan.md - Creating a Payment Plan
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: addplan)</param>,
        /// <param name="planName">Payment plan name (Format: string)</param>,
        /// <param name="planDesc">Payment plan description (Format: string)</param>,
        /// <param name="startDate">Starting day of the plan (Format: MM/DD/YYYY)</param>,
        /// <param name="reviewOnAssignment">If “true” this will set the payment plan to pending until it is reviewed by the merchant admin (Format: true/false)</param>,
        /// <param name="processImmediately">Specifies if new payments should be processed immediately or end of day (Format: true/false)</param>,
        /// <param name="overrideSender">Specifies whether to override sender email for customers notifications (Format: true/false)</param>,
        /// <param name="senderEmail">Sender email. This field is required if overridesender = true (Format: email)</param>,
        /// <param name="useRecycling">Specifies whether to reprocess failed transactions for this plan (Format: true/false)</param>,
        /// <param name="retryCount">Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise (Format: positive integer)</param>,
        /// <param name="retryType">Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date (Format: [daily|weekly|monthly])</param>,
        /// <param name="retryPeriod">Number of days between retry attempts. This field is required if retrytype=daily (Format: positive integer)</param>,
        /// <param name="retryDayOfWeek">This field is required if retrytype=weekly (monday, tuesday etc.) (Format: string)</param>,
        /// <param name="retryFirstDayOfMonth">First date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="retrySecondDayOfMonth">Second date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="autoCreateClientAccounts">Creates username and password for Client Portal automatically when plan is assigned to the client (Format: true/false)</param>,
        /// <param name="defaultKeys">DefaultKeys</param>,
        /// <param name="notificationOptions">NotificationOptions</param>,
        /// <param name="sequenceSteps">SequenceStep</param>
        public async Task<SparrowResponse> CreatePaymentPlan(string planName, string planDesc, DateTime startDate, IList<SequenceStep> sequenceSteps, DefaultKeys defaultKeys = null, bool? reviewOnAssignment = null, bool? processImmediately = null, bool? overrideSender = null, string senderEmail = "", NotificationOptions notificationOptions = null, bool? useRecycling = null, int? retryCount = null, RetryType retryType = RetryType.Daily, int? retryPeriod = null, string retryDayOfWeek = "", int? retryFirstDayOfMonth = null, int? retrySecondDayOfMonth = null, bool? autoCreateClientAccounts = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "addplan" },
                { "planName", planName },
                { "planDesc", planDesc },
                { "startDate", startDate.ToString("MM/dd/yy") },
                { "reviewOnAssignment", reviewOnAssignment == true ? "true" : "false" },
                { "processImmediately", processImmediately == true ? "true" : "false" },
                { "overrideSender", overrideSender == true ? "true" : "false" },
                { "senderEmail", senderEmail },
                { "useRecycling", useRecycling == true ? "true" : "false" },
                { "retryCount", "" + retryCount },
                { "retryType", EnumToString(retryType) },
                { "retryPeriod", "" + retryPeriod },
                { "retryDayOfWeek", retryDayOfWeek },
                { "retryFirstDayOfMonth", "" + retryFirstDayOfMonth },
                { "retrySecondDayOfMonth", "" + retrySecondDayOfMonth },
                { "autoCreateClientAccounts", autoCreateClientAccounts == true ? "true" : "false" }
            };


            if (defaultKeys != null)
            {
                var x = defaultKeys;
                data.Add("defaultAchMKey", x.DefaultAchMKey);
                data.Add("defaultCreditCardMKey", x.DefaultCreditCardMKey);
                data.Add("defaultEcheckMKey", x.DefaultEcheckMKey);
                data.Add("defaultStartCardMKey", x.DefaultStartCardMKey);
                data.Add("defaultEwalletMKey", x.DefaultEwalletMKey);
            }

            if (notificationOptions != null)
            {
                var x = notificationOptions;
                data.Add("notifyFailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("notifyUpcomingPayment", x.NotifyUpcomingPayment == true ? "true" : "false");
                data.Add("notifyDaysBeforeUpcomingPayment", "" + x.NotifyDaysBeforeUpcomingPayment);
                data.Add("notifyPlanSummary", x.NotifyPlanSummary == true ? "true" : "false");
                data.Add("notifyPlanSummaryInterval", EnumToString(x.NotifyPlanSummaryInterval));
                data.Add("notifyPlanSummaryEmails", x.NotifyPlanSummaryEmails);
                data.Add("notifyDailyStats", x.NotifyDailyStats == true ? "true" : "false");
                data.Add("notifyDailyStatsEmails", x.NotifyDailyStatsEmails);
                data.Add("notifyPlanComplete", x.NotifyPlanComplete == true ? "true" : "false");
                data.Add("notifyPlanCompleteEmails", x.NotifyPlanCompleteEmails);
                data.Add("notifyDecline", x.NotifyDecline == true ? "true" : "false");
                data.Add("notifyDeclineEmails", x.NotifyDeclineEmails);
                data.Add("notifyViaFtp", x.NotifyViaFtp == true ? "true" : "false");
                data.Add("notifyViaFtpUrl", x.NotifyViaFtpUrl == true ? "true" : "false");
                data.Add("notifyViaFtpUserName", x.NotifyViaFtpUserName);
                data.Add("notifyViaFtpPassword", x.NotifyViaFtpPassword);
                data.Add("notifyFlagged", x.NotifyFlagged == true ? "true" : "false");
                data.Add("notifyFlaggedEmails", x.NotifyFlaggedEmails);
            }

            if (sequenceSteps != null)
            {
                for (int i = 0; i < sequenceSteps.Count; i++)
                {
                    var x = sequenceSteps[i];
                    data.Add("sequence_" + (i + 1), "" + x.Sequence);
                    data.Add("amount_" + (i + 1), x.Amount.ToString("f2"));
                    data.Add("scheduleType_" + (i + 1), EnumToString(x.ScheduleType));
                    data.Add("scheduleDay_" + (i + 1), "" + x.ScheduleDay);
                    data.Add("duration_" + (i + 1), "" + x.Duration);
                    data.Add("operationType_" + (i + 1), EnumToString(x.OperationType));
                    data.Add("productId_" + (i + 1), x.ProductId);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("newSequence_" + (i + 1), "" + x.NewSequence);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Delete a Plan
        /// </summary>
        /// <remarks>
        /// payment-plans/delete-plan.md - Deleting a Plan
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: deleteplan)</param>,
        /// <param name="token">Payment plan unique identifier (Format: alphanumeric string)</param>,
        /// <param name="cancelPayments">Specifies whether to cancel pending payments caused by assignments of this plan. Default value is false (Format: true/false)</param>
        public async Task<SparrowResponse> DeletePlan(string token, bool? cancelPayments = null)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "deleteplan" },
                { "token", token },
                { "cancelPayments", cancelPayments == true ? "true" : "false" }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Delete a Sequence
        /// </summary>
        /// <remarks>
        /// payment-plans/delete-sequence.md - Deleting a Sequence
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: updateplan)</param>,
        /// <param name="token">Unique payment plan identifier</param>,
        /// <param name="deleteSequenceSteps">SequenceStepToDelete</param>
        public async Task<SparrowResponse> DeleteSequence(IList<SequenceStepToDelete> deleteSequenceSteps, string token)
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updateplan" },
                { "token", token }
            };


            if (deleteSequenceSteps != null)
            {
                for (int i = 0; i < deleteSequenceSteps.Count; i++)
                {
                    var x = deleteSequenceSteps[i];
                    data.Add("operationType_" + (i + 1), "deletesequence");
                    data.Add("sequence_" + (i + 1), "" + x.Sequence);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Update Payment Plan Assignment
        /// </summary>
        /// <remarks>
        /// payment-plans/update-plan-assignment.md - Update Payment Plan Assignment
        /// </remarks>
        /// <param name="mKey">Secure merchant account key</param>,
        /// <param name="transType"> (Format: updateassignment)</param>,
        /// <param name="assignmentToken">Unique identifier of payment plan assignment (Format: alphanumeric string)</param>,
        /// <param name="paymentToken">Token of the customer’s payment type, if they have multiple (Format: alphanumeric string)</param>,
        /// <param name="startDate">Day of the first payment of the plan; if not present the plan’s start date (if it exists) is used. (Format: MM/DD/YYYY)</param>,
        /// <param name="productId">External ID for the product (Format: string)</param>,
        /// <param name="description">Description of plan assignment (Format: string)</param>,
        /// <param name="useRecycling">Specifies whether to reprocess failed transactions for this plan (Format: true/false)</param>,
        /// <param name="retryCount">Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise (Format: positive integer)</param>,
        /// <param name="retryType">Specifies the type of retry schedule. Supported types are: every month of a specified date, every N days, every year on a specified date (Format: [daily|weekly|monthly])</param>,
        /// <param name="retryPeriod">Number of days between retry attempts. This field is required if retrytype=daily (Format: positive integer)</param>,
        /// <param name="retryDayOfWeek">This field is required if retrytype=weekly (monday, tuesday etc.) (Format: string)</param>,
        /// <param name="retryFirstDayOfMonth">First date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="retrySecondDayOfMonth">Second date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="proratedPayment">Specifies whether to add prorated payment in this plan (Format: true / false)</param>,
        /// <param name="routingKey">Merchant key of account with which plan payments should be processed by default. This account must be of the same type as selected customer’s payment type</param>,
        /// <param name="notificationOptions">NotificationOptions</param>
        public async Task<SparrowResponse> UpdatePaymentPlanAssignment(string assignmentToken, string paymentToken = "", DateTime? startDate = null, string productId = "", string description = "", NotificationOptions notificationOptions = null, bool? useRecycling = null, int? retryCount = null, RetryType retryType = RetryType.Daily, int? retryPeriod = null, string retryDayOfWeek = "", int? retryFirstDayOfMonth = null, int? retrySecondDayOfMonth = null, bool? proratedPayment = null, string routingKey = "")
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updateassignment" },
                { "assignmentToken", assignmentToken },
                { "paymentToken", paymentToken },
                { "startDate", startDate?.ToString("MM/dd/yy") ?? "" },
                { "productId", productId },
                { "description", description },
                { "useRecycling", useRecycling == true ? "true" : "false" },
                { "retryCount", "" + retryCount },
                { "retryType", EnumToString(retryType) },
                { "retryPeriod", "" + retryPeriod },
                { "retryDayOfWeek", retryDayOfWeek },
                { "retryFirstDayOfMonth", "" + retryFirstDayOfMonth },
                { "retrySecondDayOfMonth", "" + retrySecondDayOfMonth },
                { "proratedPayment", proratedPayment == true ? "true" : "false" },
                { "routingKey", routingKey }
            };


            if (notificationOptions != null)
            {
                var x = notificationOptions;
                data.Add("notifyFailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("notifyUpcomingPayment", x.NotifyUpcomingPayment == true ? "true" : "false");
                data.Add("notifyDaysBeforeUpcomingPayment", "" + x.NotifyDaysBeforeUpcomingPayment);
                data.Add("notifyPlanSummary", x.NotifyPlanSummary == true ? "true" : "false");
                data.Add("notifyPlanSummaryInterval", EnumToString(x.NotifyPlanSummaryInterval));
                data.Add("notifyPlanSummaryEmails", x.NotifyPlanSummaryEmails);
                data.Add("notifyDailyStats", x.NotifyDailyStats == true ? "true" : "false");
                data.Add("notifyDailyStatsEmails", x.NotifyDailyStatsEmails);
                data.Add("notifyPlanComplete", x.NotifyPlanComplete == true ? "true" : "false");
                data.Add("notifyPlanCompleteEmails", x.NotifyPlanCompleteEmails);
                data.Add("notifyDecline", x.NotifyDecline == true ? "true" : "false");
                data.Add("notifyDeclineEmails", x.NotifyDeclineEmails);
                data.Add("notifyViaFtp", x.NotifyViaFtp == true ? "true" : "false");
                data.Add("notifyViaFtpUrl", x.NotifyViaFtpUrl == true ? "true" : "false");
                data.Add("notifyViaFtpUserName", x.NotifyViaFtpUserName);
                data.Add("notifyViaFtpPassword", x.NotifyViaFtpPassword);
                data.Add("notifyFlagged", x.NotifyFlagged == true ? "true" : "false");
                data.Add("notifyFlaggedEmails", x.NotifyFlaggedEmails);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Update a Payment Plan
        /// </summary>
        /// <remarks>
        /// payment-plans/update-plan.md - Updating a Payment Plan
        /// </remarks>
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transType"> (Format: updateplan)</param>,
        /// <param name="token">Unique payment plan identifier</param>,
        /// <param name="planName">Payment plan name (Format: string)</param>,
        /// <param name="planDesc">Payment plan description (Format: string)</param>,
        /// <param name="startDate">Starting day of the plan (Format: MM/DD/YYYY)</param>,
        /// <param name="useRecycling">Specifies whether to reprocess failed transactions in this plan (Format: true/false)</param>,
        /// <param name="retryCount">Number of times to retry each failed transaction. This field is required if transaction recycling is activated, and ignored otherwise (Format: positive integer)</param>,
        /// <param name="retryType">Specifies the type of retry schedule (Format: [daily|weekly|monthly])</param>,
        /// <param name="retryPeriod">Number of days between retry attempts. This field is required if retrytype=daily (Format: positive integer)</param>,
        /// <param name="retryDayOfWeek">This field is required if retrytype=weekly (monday, tuesday etc.) (Format: string)</param>,
        /// <param name="retryFirstDayOfMonth">First date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="retrySecondDayOfMonth">Second date of retry schedule. This field is required if retrytype=monthly (Format: positive integer)</param>,
        /// <param name="autoCreateClientAccounts">Creates username and password for Client Portal automatically when plan is assigned to the client (Format: true / false)</param>,
        /// <param name="reviewOnAssignment">If “true” this will set the payment plan to pending until it is reviewed by the merchant admin (Format: true/false)</param>,
        /// <param name="processImmediately">Specifies if new payments should be processed immediately or end of day (Format: true/false)</param>,
        /// <param name="overrideSender">Specifies whether to override sender email for customers notifications (Format: true/false)</param>,
        /// <param name="senderEmail">Sender email. This field is required if overridesender = true (Format: email)</param>,
        /// <param name="defaultKeys">DefaultKeys</param>,
        /// <param name="notificationOptions">NotificationOptions</param>,
        /// <param name="sequenceSteps">SequenceStep</param>
        public async Task<SparrowResponse> UpdatePaymentPlan(string token, IList<SequenceStep> sequenceSteps, string planName = "", string planDesc = "", DateTime? startDate = null, DefaultKeys defaultKeys = null, bool? useRecycling = null, NotificationOptions notificationOptions = null, int? retryCount = null, RetryType retryType = RetryType.Daily, int? retryPeriod = null, string retryDayOfWeek = "", int? retryFirstDayOfMonth = null, int? retrySecondDayOfMonth = null, bool? autoCreateClientAccounts = null, bool? reviewOnAssignment = null, bool? processImmediately = null, bool? overrideSender = null, string senderEmail = "")
        {
            var data = new Dictionary<string, string>
            {
                { "mKey", _apiKey },
                { "transType", "updateplan" },
                { "token", token },
                { "planName", planName },
                { "planDesc", planDesc },
                { "startDate", startDate?.ToString("MM/dd/yy") ?? "" },
                { "useRecycling", useRecycling == true ? "true" : "false" },
                { "retryCount", "" + retryCount },
                { "retryType", EnumToString(retryType) },
                { "retryPeriod", "" + retryPeriod },
                { "retryDayOfWeek", retryDayOfWeek },
                { "retryFirstDayOfMonth", "" + retryFirstDayOfMonth },
                { "retrySecondDayOfMonth", "" + retrySecondDayOfMonth },
                { "autoCreateClientAccounts", autoCreateClientAccounts == true ? "true" : "false" },
                { "reviewOnAssignment", reviewOnAssignment == true ? "true" : "false" },
                { "processImmediately", processImmediately == true ? "true" : "false" },
                { "overrideSender", overrideSender == true ? "true" : "false" },
                { "senderEmail", senderEmail }
            };


            if (defaultKeys != null)
            {
                var x = defaultKeys;
                data.Add("defaultAchMKey", x.DefaultAchMKey);
                data.Add("defaultCreditCardMKey", x.DefaultCreditCardMKey);
                data.Add("defaultEcheckMKey", x.DefaultEcheckMKey);
                data.Add("defaultStartCardMKey", x.DefaultStartCardMKey);
                data.Add("defaultEwalletMKey", x.DefaultEwalletMKey);
            }

            if (notificationOptions != null)
            {
                var x = notificationOptions;
                data.Add("notifyFailures", x.NotifyFailures == true ? "true" : "false");
                data.Add("notifyUpcomingPayment", x.NotifyUpcomingPayment == true ? "true" : "false");
                data.Add("notifyDaysBeforeUpcomingPayment", "" + x.NotifyDaysBeforeUpcomingPayment);
                data.Add("notifyPlanSummary", x.NotifyPlanSummary == true ? "true" : "false");
                data.Add("notifyPlanSummaryInterval", EnumToString(x.NotifyPlanSummaryInterval));
                data.Add("notifyPlanSummaryEmails", x.NotifyPlanSummaryEmails);
                data.Add("notifyDailyStats", x.NotifyDailyStats == true ? "true" : "false");
                data.Add("notifyDailyStatsEmails", x.NotifyDailyStatsEmails);
                data.Add("notifyPlanComplete", x.NotifyPlanComplete == true ? "true" : "false");
                data.Add("notifyPlanCompleteEmails", x.NotifyPlanCompleteEmails);
                data.Add("notifyDecline", x.NotifyDecline == true ? "true" : "false");
                data.Add("notifyDeclineEmails", x.NotifyDeclineEmails);
                data.Add("notifyViaFtp", x.NotifyViaFtp == true ? "true" : "false");
                data.Add("notifyViaFtpUrl", x.NotifyViaFtpUrl == true ? "true" : "false");
                data.Add("notifyViaFtpUserName", x.NotifyViaFtpUserName);
                data.Add("notifyViaFtpPassword", x.NotifyViaFtpPassword);
                data.Add("notifyFlagged", x.NotifyFlagged == true ? "true" : "false");
                data.Add("notifyFlaggedEmails", x.NotifyFlaggedEmails);
            }

            if (sequenceSteps != null)
            {
                for (int i = 0; i < sequenceSteps.Count; i++)
                {
                    var x = sequenceSteps[i];
                    data.Add("sequence_" + (i + 1), "" + x.Sequence);
                    data.Add("amount_" + (i + 1), x.Amount.ToString("f2"));
                    data.Add("scheduleType_" + (i + 1), EnumToString(x.ScheduleType));
                    data.Add("scheduleDay_" + (i + 1), "" + x.ScheduleDay);
                    data.Add("duration_" + (i + 1), "" + x.Duration);
                    data.Add("operationType_" + (i + 1), EnumToString(x.OperationType));
                    data.Add("productId_" + (i + 1), x.ProductId);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("newSequence_" + (i + 1), "" + x.NewSequence);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Offline Capture
        /// </summary>
        /// <remarks>
        /// separate-auth-capture/Offline-Capture.md - Simple Offline Capture
        /// </remarks>
        /// <param name="transType">Offline Capture closes an open authorization which was manually obtained from the card issuer (Format: offline)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="authCode">Auth code received from the issuer (Format: string)</param>,
        /// <param name="authDate">Date that auth code was obtained, required for Chase only (Format: MM/DD/YYYY)</param>,
        /// <param name="creditCard">CreditCard</param>
        public async Task<SparrowResponse> SimpleOfflineCapture(CreditCard creditCard, decimal amount, string authCode, DateTime authDate)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "offline" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") },
                { "authCode", authCode },
                { "authDate", authDate.ToString("MM/dd/yy") }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced Capture
        /// </summary>
        /// <remarks>
        /// separate-auth-capture/advanced-capture.md - Advanced Capture
        /// </remarks>
        /// <param name="transType">Capture = Transaction Capture (Format: capture)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original Payment Gateway Transaction ID</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="shipTrackNum">Shipping Tracking Number</param>,
        /// <param name="shipCarrier">Shipping Carrier (Format: [ups|fedex|dhl|usps])</param>,
        /// <param name="orderId">Order ID</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>,
        /// <param name="optionalAmount">OptionalAmount</param>
        public async Task<SparrowResponse> AdvancedCapture(string transId, decimal amount, SendTransReceiptOptions sendTransReceiptOptions = null, string shipTrackNum = "", ShipCarrier shipCarrier = ShipCarrier.Ups, string orderId = "", IList<OptionalAmount> optionalAmount = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "capture" },
                { "mKey", _apiKey },
                { "transId", transId },
                { "amount", amount.ToString("f2") },
                { "shipTrackNum", shipTrackNum },
                { "shipCarrier", EnumToString(shipCarrier) },
                { "orderId", orderId }
            };


            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            if (optionalAmount != null)
            {
                for (int i = 0; i < optionalAmount.Count; i++)
                {
                    var x = optionalAmount[i];
                    data.Add("optAmountType_" + (i + 1), x.OptAmountType);
                    data.Add("optAmountValue_" + (i + 1), x.OptAmountValue?.ToString("f2") ?? "");
                    data.Add("optAmountPercentage_" + (i + 1), x.OptAmountPercentage);
                }
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Authorization
        /// </summary>
        /// <remarks>
        /// separate-auth-capture/simple-auth.md - Simple Authorization
        /// </remarks>
        /// <param name="transType">Authorization = Transaction Auth (Format: auth)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="creditCard">CreditCard</param>
        public async Task<SparrowResponse> SimpleAuthorization(CreditCard creditCard, decimal amount)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "auth" },
                { "mKey", _apiKey },
                { "amount", amount.ToString("f2") }
            };


            if (creditCard != null)
            {
                var x = creditCard;
                data.Add("cardNum", x.CardNum);
                data.Add("cardExp", x.CardExp.ToString("MMyy"));
                data.Add("cvv", x.Cvv);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Capture
        /// </summary>
        /// <remarks>
        /// separate-auth-capture/simple-capture.md - Simple Capture
        /// </remarks>
        /// <param name="transType">Capture = Transaction Capture (Format: capture)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="transId">Original Payment Gateway Transaction ID</param>,
        /// <param name="amount">Total amount to be charged (i.e. 10.00) (Format: d.dd)</param>,
        /// <param name="sendTransReceiptOptions">SendTransReceiptOptions</param>
        public async Task<SparrowResponse> SimpleCapture(string transId, decimal amount, SendTransReceiptOptions sendTransReceiptOptions = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "capture" },
                { "mKey", _apiKey },
                { "transId", transId },
                { "amount", amount.ToString("f2") }
            };


            if (sendTransReceiptOptions != null)
            {
                var x = sendTransReceiptOptions;
                data.Add("sendTransReceiptToEmails", x.SendTransReceiptToEmails);
                data.Add("sendTransReceiptToBillEmail", x.SendTransReceiptToBillEmail == true ? "true" : "false");
                data.Add("sendTransReceiptToShipEmail", x.SendTransReceiptToShipEmail == true ? "true" : "false");
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Advanced Star Card
        /// </summary>
        /// <remarks>
        /// starcard/advanced-starcard.md - Advanced Star Card
        /// </remarks>
        /// <param name="transType">Transaction Sale (Format: sale)</param>,
        /// <param name="mKey">secured merchant account key</param>,
        /// <param name="cardNum">Credit card number</param>,
        /// <param name="cardExp">Credit card expiration (ie. 0719 = 7/2019 (Format: MMYY)</param>,
        /// <param name="amount">Total amount to be charged (ie. 10.00) (Format: d.dd)</param>,
        /// <param name="CID">11 digit numerical code (CID Format: custom field)</param>,
        /// <param name="currency">Code of the payment currency. If currency is not specified, the default currency (USD) is assumed. (Format: CCC (ISO 4217 alphabetic code))</param>,
        /// <param name="orderDesc">Order Description</param>,
        /// <param name="orderId">Order ID</param>,
        /// <param name="cardIpAddress">IP address of the customer, can be used for fraud prevention in FBI Tools (Format: ddd.ddd.ddd.ddd)</param>,
        /// <param name="tax">Total tax amount (Format: d.dd)</param>,
        /// <param name="shipAmount">Total shipping amount (Format: d.dd)</param>,
        /// <param name="poNumber">Original Purchase Order</param>,
        /// <param name="fax">Billing fax number</param>,
        /// <param name="contactInfo">ContactInfo</param>,
        /// <param name="product">Product</param>,
        /// <param name="shippingContactInfo">ShippingContactInfo</param>
        public async Task<SparrowResponse> AdvancedStarCard(string cardNum, DateTime cardExp, decimal amount, string CID, string currency = "", ContactInfo contactInfo = null, IList<Product> product = null, string orderDesc = "", string orderId = "", string cardIpAddress = "", decimal? tax = null, decimal? shipAmount = null, string poNumber = "", string fax = "", ShippingContactInfo shippingContactInfo = null)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "cardNum", cardNum },
                { "cardExp", cardExp.ToString("MMyy") },
                { "amount", amount.ToString("f2") },
                { "CID", CID },
                { "currency", currency },
                { "orderDesc", orderDesc },
                { "orderId", orderId },
                { "cardIpAddress", cardIpAddress },
                { "tax", tax?.ToString("f2") ?? "" },
                { "shipAmount", shipAmount?.ToString("f2") ?? "" },
                { "poNumber", poNumber },
                { "fax", fax }
            };


            if (contactInfo != null)
            {
                var x = contactInfo;
                data.Add("firstName", x.FirstName);
                data.Add("lastName", x.LastName);
                data.Add("birthDate", x.BirthDate?.ToString("MM/dd/yy") ?? "");
                data.Add("company", x.Company);
                data.Add("address1", x.Address?.Address1);
                data.Add("city", x.Address?.City);
                data.Add("state", x.Address?.State);
                data.Add("zip", x.Address?.Zip);
                data.Add("country", x.Address?.Country);
                data.Add("address2", x.Address?.Address2);
                data.Add("phone", x.Phone);
                data.Add("email", x.Email);
            }

            if (product != null)
            {
                for (int i = 0; i < product.Count; i++)
                {
                    var x = product[i];
                    data.Add("skuNumber_" + (i + 1), x.SkuNumber);
                    data.Add("description_" + (i + 1), x.Description);
                    data.Add("amount_" + (i + 1), x.Amount?.ToString("f2") ?? "");
                    data.Add("quantity_" + (i + 1), "" + x.Quantity);
                }
            }

            if (shippingContactInfo != null)
            {
                var x = shippingContactInfo;
                data.Add("shipFirstName", x.ShipFirstName);
                data.Add("shipLastName", x.ShipLastName);
                data.Add("shipCompany", x.ShipCompany);
                data.Add("shipAddress1", x.ShippingAddress?.ShipAddress1);
                data.Add("shipCity", x.ShippingAddress?.ShipCity);
                data.Add("shipState", x.ShippingAddress?.ShipState);
                data.Add("shipZip", x.ShippingAddress?.ShipZip);
                data.Add("shipCountry", x.ShippingAddress?.ShipCountry);
                data.Add("shipAddress2", x.ShippingAddress?.ShipAddress2);
                data.Add("shipPhone", x.ShipPhone);
                data.Add("shipEmail", x.ShipEmail);
            }

            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

        /// <summary>
        /// Simple Star Card
        /// </summary>
        /// <remarks>
        /// starcard/simple-starcard.md - Simple Star Card
        /// </remarks>
        /// <param name="transType">Transaction sale (Format: sale)</param>,
        /// <param name="mKey">Secured merchant account key</param>,
        /// <param name="cardNum">Card number</param>,
        /// <param name="amount">Total amount to be refunded (Format: d.dd)</param>,
        /// <param name="CID">11 digit numerical code (CID Format: Custom Field)</param>
        public async Task<SparrowResponse> SimpleStarCard(string cardNum, decimal amount, string CID)
        {
            var data = new Dictionary<string, string>
            {
                { "transType", "sale" },
                { "mKey", _apiKey },
                { "cardNum", cardNum },
                { "amount", amount.ToString("f2") },
                { "CID", CID }
            };


            data = data.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value);

            var responseValues = await MakeRequest(data);
            return SparrowResponse.Create(responseValues, data);
        }

    }
}
