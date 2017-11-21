using System;
using System.Threading.Tasks;

namespace SparrowSdk.Samples
{
    public partial class SampleGenerator
    {
        public async Task Generate()
        {

            if (!!true)
            {
                var resultAdvancedECheck = await _sparrow_ach.AdvancedECheck(
                    transType: Sparrow.TransType_SaleRefundCredit.Sale,
                    bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                    amount: 9.99m,
                    contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address { Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });

                Log(SparrowResponseSamples.EnterSample("ach/advanced-echeck-sale.md", "AdvancedECheck", resultAdvancedECheck.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AdvancedECheck(
    transType: Sparrow.TransType_SaleRefundCredit.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = ""First Test Bank"", Routing = ""110000000"", Account = ""1234567890123"", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"", Company = ""Sparrow One"", Address = new Sparrow.Address{ Address1 = ""16100 N 71st Street"", City = ""Scottsdale"", State = ""AZ"", Zip = ""85254"", Country = ""US"" } });"));

                Log(resultAdvancedECheck.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("ach/advanced-echeck-sale.md", "AdvancedECheck", resultAdvancedECheck.IsSuccess));
            }

            if (!!true)
            {
                var resultAdvancedACH = await _sparrow_ach.AdvancedACH(
                    transType: Sparrow.TransType_SaleRefundCredit.Sale,
                    bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                    amount: 9.99m,
                    contactInfo: new Sparrow.ContactInfo { });

                Log(SparrowResponseSamples.EnterSample("ach/advanced-sale.md", "AdvancedACH", resultAdvancedACH.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AdvancedACH(
    transType: Sparrow.TransType_SaleRefundCredit.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = ""First Test Bank"", Routing = ""110000000"", Account = ""1234567890123"", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{  });"));

                Log(resultAdvancedACH.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("ach/advanced-sale.md", "AdvancedACH", resultAdvancedACH.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleACH = await _sparrow_ach.SimpleACH(
                    transType: Sparrow.TransType_SaleRefundCredit.Sale,
                    bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                    amount: 9.99m,
                    contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });

                Log(SparrowResponseSamples.EnterSample("ach/simple-ach.md", "SimpleACH", resultSimpleACH.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleACH(
    transType: Sparrow.TransType_SaleRefundCredit.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = ""First Test Bank"", Routing = ""110000000"", Account = ""1234567890123"", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" });"));

                Log(resultSimpleACH.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("ach/simple-ach.md", "SimpleACH", resultSimpleACH.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleECheck = await _sparrow_ach.SimpleECheck(
                    transType: Sparrow.TransType_SaleRefund.Sale,
                    bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                    amount: 9.99m,
                    contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address { Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });

                Log(SparrowResponseSamples.EnterSample("ach/simple-echeck.md", "SimpleECheck", resultSimpleECheck.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleECheck(
    transType: Sparrow.TransType_SaleRefund.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = ""First Test Bank"", Routing = ""110000000"", Account = ""1234567890123"", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"", Company = ""Sparrow One"", Address = new Sparrow.Address{ Address1 = ""16100 N 71st Street"", City = ""Scottsdale"", State = ""AZ"", Zip = ""85254"", Country = ""US"" } });"));

                Log(resultSimpleECheck.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("ach/simple-echeck.md", "SimpleECheck", resultSimpleECheck.IsSuccess));
            }

            if (!!true)
            {
                var resultPassengerSale = await _sparrow_creditcard.PassengerSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m,
                    passengerName: "John Doe",
                    airportCodes: new[] { "" },
                    airlineCodeNumber: "AA0",
                    ticketNumber: "1234567890",
                    flightDateCoupons: new[] { "" },
                    flightDepartureTimeCoupons: new[] { "" },
                    approvalCode: "123456",
                    authCharIndicator: Sparrow.AuthCharIndicator.A,
                    validationCode: "1234",
                    authResponseCode: "AB");

                Log(SparrowResponseSamples.EnterSample("airline-passenger-sale/passenger-sale.md", "PassengerSale", resultPassengerSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.PassengerSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m, 
    passengerName: ""John Doe"", 
    airportCodes: new []{ """" }, 
    airlineCodeNumber: ""AA0"", 
    ticketNumber: ""1234567890"", 
    flightDateCoupons: new []{ """" }, 
    flightDepartureTimeCoupons: new []{ """" }, 
    approvalCode: ""123456"", 
    authCharIndicator: Sparrow.AuthCharIndicator.A, 
    validationCode: ""1234"", 
    authResponseCode: ""AB"");"));

                Log(resultPassengerSale.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("airline-passenger-sale/passenger-sale.md", "PassengerSale", resultPassengerSale.IsSuccess));
            }

            if (!!true)
            {
                var resultRetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance(
                    cardNum: "4111111111111111");

                Log(SparrowResponseSamples.EnterSample("balance-inquiry/check-balance.md", "RetrieveCardBalance", resultRetrieveCardBalance.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.RetrieveCardBalance(
    cardNum: ""4111111111111111"");"));

                Log(resultRetrieveCardBalance.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("balance-inquiry/check-balance.md", "RetrieveCardBalance", resultRetrieveCardBalance.IsSuccess));
            }

            if (!!true)
            {
                var resultVerifyAccount = await _sparrow_creditcard.VerifyAccount(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("cc-verification/card-verification.md", "VerifyAccount", resultVerifyAccount.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.VerifyAccount(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);"));

                Log(resultVerifyAccount.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("cc-verification/card-verification.md", "VerifyAccount", resultVerifyAccount.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultMarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(
                    transId: resultSimpleSale.TransId,
                    reason: "Testing for Success");

                Log(SparrowResponseSamples.EnterSample("chargeback/mark-chargeback.md", "MarkSuccessfulTransactionAsChargeback", resultMarkSuccessfulTransactionAsChargeback.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.MarkSuccessfulTransactionAsChargeback(
    transId: resultSimpleSale.TransId, 
    reason: ""Testing for Success"");"));

                Log(resultSimpleSale.CreateResponseDemo("resultSimpleSale"));
                Log(resultMarkSuccessfulTransactionAsChargeback.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("chargeback/mark-chargeback.md", "MarkSuccessfulTransactionAsChargeback", resultMarkSuccessfulTransactionAsChargeback.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleCredit = await _sparrow_creditcard.SimpleCredit(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("creating-a-credit/simple-credit.md", "SimpleCredit", resultSimpleCredit.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleCredit(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);"));

                Log(resultSimpleCredit.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("creating-a-credit/simple-credit.md", "SimpleCredit", resultSimpleCredit.IsSuccess));
            }

            if (!!true)
            {
                var resultAdvancedSale = await _sparrow_creditcard.AdvancedSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("creating-a-sale/advanced-sale.md", "AdvancedSale", resultAdvancedSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AdvancedSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);"));

                Log(resultAdvancedSale.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("creating-a-sale/advanced-sale.md", "AdvancedSale", resultAdvancedSale.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("creating-a-sale/simple-sale.md", "SimpleSale", resultSimpleSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);"));

                Log(resultSimpleSale.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("creating-a-sale/simple-sale.md", "SimpleSale", resultSimpleSale.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });
                var resultAddPaymentTypesToCustomer = await _sparrow_creditcard.AddPaymentTypesToCustomer(
                    token: resultAddCustomer.CustomerToken,
                    paymentTypeToAdd: new[] { new Sparrow.PaymentTypeToAdd { } });

                Log(SparrowResponseSamples.EnterSample("datavault/add-payment-type.md", "AddPaymentTypesToCustomer", resultAddPaymentTypesToCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" });
var result = await _sparrow.AddPaymentTypesToCustomer(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToAdd: new []{ new Sparrow.PaymentTypeToAdd{  } });"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultAddPaymentTypesToCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/add-payment-type.md", "AddPaymentTypesToCustomer", resultAddPaymentTypesToCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });

                Log(SparrowResponseSamples.EnterSample("datavault/adding-a-customer.md", "AddCustomer", resultAddCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });"));

                Log(resultAddCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/adding-a-customer.md", "AddCustomer", resultAddCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });
                var resultDeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(
                    token: resultAddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("datavault/delete-customer.md", "DeleteDataVaultCustomer", resultDeleteDataVaultCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" });
var result = await _sparrow.DeleteDataVaultCustomer(
    token: resultAddCustomer.CustomerToken);"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultDeleteDataVaultCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/delete-customer.md", "DeleteDataVaultCustomer", resultDeleteDataVaultCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultDeletePaymentType = await _sparrow_creditcard.DeletePaymentType(
                    token: resultAddCustomer.CustomerToken,
                    paymentTypeToDelete: new[] { new Sparrow.PaymentTypeToDelete { Token = resultAddCustomer.CustomerToken } });

                Log(SparrowResponseSamples.EnterSample("datavault/delete-payment-type.md", "DeletePaymentType", resultDeletePaymentType.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var result = await _sparrow.DeletePaymentType(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToDelete: new []{ new Sparrow.PaymentTypeToDelete{ Token = resultAddCustomer.CustomerToken } });"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultDeletePaymentType.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/delete-payment-type.md", "DeletePaymentType", resultDeletePaymentType.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });
                var resultRetrieveCustomer = await _sparrow_creditcard.RetrieveCustomer(
                    token: resultAddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("datavault/get-customer.md", "RetrieveCustomer", resultRetrieveCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" });
var result = await _sparrow.RetrieveCustomer(
    token: resultAddCustomer.CustomerToken);"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultRetrieveCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/get-customer.md", "RetrieveCustomer", resultRetrieveCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultRetrievePaymentType = await _sparrow_creditcard.RetrievePaymentType(
                    token: resultAddCustomer.PaymentTokens[0]);

                Log(SparrowResponseSamples.EnterSample("datavault/get-payment-type.md", "RetrievePaymentType", resultRetrievePaymentType.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var result = await _sparrow.RetrievePaymentType(
    token: resultAddCustomer.PaymentTokens[0]);"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultRetrievePaymentType.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/get-payment-type.md", "RetrievePaymentType", resultRetrievePaymentType.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultUpdateCustomer = await _sparrow_creditcard.UpdateCustomer(
                    token: resultAddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("datavault/update-payment-type.md", "UpdateCustomer", resultUpdateCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var result = await _sparrow.UpdateCustomer(
    token: resultAddCustomer.CustomerToken);"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultUpdateCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/update-payment-type.md", "UpdateCustomer", resultUpdateCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultUpdatePaymentType = await _sparrow_creditcard.UpdatePaymentType(
                    token: resultAddCustomer.CustomerToken,
                    paymentTypeToUpdate: new[] { new Sparrow.PaymentTypeToUpdate { Token = resultAddCustomer.CustomerToken, PaymentType = new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } } });

                Log(SparrowResponseSamples.EnterSample("datavault/update-payment-types.md", "UpdatePaymentType", resultUpdatePaymentType.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var result = await _sparrow.UpdatePaymentType(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToUpdate: new []{ new Sparrow.PaymentTypeToUpdate{ Token = resultAddCustomer.CustomerToken, PaymentType = new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } } });"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultUpdatePaymentType.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("datavault/update-payment-types.md", "UpdatePaymentType", resultUpdatePaymentType.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });
                var resultDecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields(
                    fieldName: "customField1",
                    token: resultAddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("decrypt-custom-field/decrypt.md", "DecryptCustomFields", resultDecryptCustomFields.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" });
var result = await _sparrow.DecryptCustomFields(
    fieldName: ""customField1"", 
    token: resultAddCustomer.CustomerToken);"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultDecryptCustomFields.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("decrypt-custom-field/decrypt.md", "DecryptCustomFields", resultDecryptCustomFields.IsSuccess));
            }

            if (!!true)
            {
                var resultEWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit(
                    ewallet: new Sparrow.Ewallet { EwalletAccount = "user@example.com" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("ewallet/ewallet-credit.md", "EWalletSimpleCredit", resultEWalletSimpleCredit.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.EWalletSimpleCredit(
    ewallet: new Sparrow.Ewallet{ EwalletAccount = ""user@example.com"" }, 
    amount: 9.99m);"));

                Log(resultEWalletSimpleCredit.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("ewallet/ewallet-credit.md", "EWalletSimpleCredit", resultEWalletSimpleCredit.IsSuccess));
            }

            if (!!true)
            {
                var resultAdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("fiserv/fiserv-advanced.md", "AdvancedFiservSale", resultAdvancedFiservSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AdvancedFiservSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);"));

                Log(resultAdvancedFiservSale.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("fiserv/fiserv-advanced.md", "AdvancedFiservSale", resultAdvancedFiservSale.IsSuccess));
            }

            if (!!true)
            {
                var resultFiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale(
                    cardNum: "4111111111111111",
                    cardExp: "1019",
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("fiserv/fiserv-simple.md", "FiservSimpleSale", resultFiservSimpleSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.FiservSimpleSale(
    cardNum: ""4111111111111111"", 
    cardExp: ""1019"", 
    amount: 9.99m);"));

                Log(resultFiservSimpleSale.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("fiserv/fiserv-simple.md", "FiservSimpleSale", resultFiservSimpleSale.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Active,
                    invoiceAmount: 10.00m);
                var resultCancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(
                    invoiceNumber: resultCreateInvoice.InvoiceNumber,
                    invoiceStatusReason: "Testing");

                Log(SparrowResponseSamples.EnterSample("invoicing/cancel-inv-customer.md", "CancelInvoiceByCustomer", resultCancelInvoiceByCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.CancelInvoiceByCustomer(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    invoiceStatusReason: ""Testing"");"));

                Log(resultCreateInvoice.CreateResponseDemo("resultCreateInvoice"));
                Log(resultCancelInvoiceByCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/cancel-inv-customer.md", "CancelInvoiceByCustomer", resultCancelInvoiceByCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Active,
                    invoiceAmount: 10.00m);
                var resultCancelInvoice = await _sparrow_creditcard.CancelInvoice(
                    invoiceNumber: resultCreateInvoice.InvoiceNumber,
                    invoiceStatusReason: "Testing");

                Log(SparrowResponseSamples.EnterSample("invoicing/cancel-invoice.md", "CancelInvoice", resultCancelInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.CancelInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    invoiceStatusReason: ""Testing"");"));

                Log(resultCreateInvoice.CreateResponseDemo("resultCreateInvoice"));
                Log(resultCancelInvoice.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/cancel-invoice.md", "CancelInvoice", resultCancelInvoice.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Active,
                    invoiceAmount: 10.00m);

                Log(SparrowResponseSamples.EnterSample("invoicing/create-merchant-invoice.md", "CreateInvoice", resultCreateInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);"));

                Log(resultCreateInvoice.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/create-merchant-invoice.md", "CreateInvoice", resultCreateInvoice.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Active,
                    invoiceAmount: 10.00m);
                var resultRetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(
                    invoiceNumber: resultCreateInvoice.InvoiceNumber);

                Log(SparrowResponseSamples.EnterSample("invoicing/get-invoice.md", "RetrieveInvoice", resultRetrieveInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.RetrieveInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber);"));

                Log(resultCreateInvoice.CreateResponseDemo("resultCreateInvoice"));
                Log(resultRetrieveInvoice.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/get-invoice.md", "RetrieveInvoice", resultRetrieveInvoice.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_ach.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Active,
                    invoiceAmount: 10.00m);
                var resultPayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(
                    invoiceNumber: resultCreateInvoice.InvoiceNumber,
                    bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                    contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });

                Log(SparrowResponseSamples.EnterSample("invoicing/pay-inv-ach.md", "PayInvoiceWithBankAccount", resultPayInvoiceWithBankAccount.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.PayInvoiceWithBankAccount(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    bankAccount: new Sparrow.BankAccount{ BankName = ""First Test Bank"", Routing = ""110000000"", Account = ""1234567890123"", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" });"));

                Log(resultCreateInvoice.CreateResponseDemo("resultCreateInvoice"));
                Log(resultPayInvoiceWithBankAccount.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/pay-inv-ach.md", "PayInvoiceWithBankAccount", resultPayInvoiceWithBankAccount.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Active,
                    invoiceAmount: 10.00m);
                var resultPayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(
                    invoiceNumber: resultCreateInvoice.InvoiceNumber,
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" });

                Log(SparrowResponseSamples.EnterSample("invoicing/pay-inv-cc.md", "PayInvoiceWithCreditCard", resultPayInvoiceWithCreditCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.PayInvoiceWithCreditCard(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" });"));

                Log(resultCreateInvoice.CreateResponseDemo("resultCreateInvoice"));
                Log(resultPayInvoiceWithCreditCard.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/pay-inv-cc.md", "PayInvoiceWithCreditCard", resultPayInvoiceWithCreditCard.IsSuccess));
            }

            if (!!true)
            {
                var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                    invoiceDate: "12/01/2017",
                    currency: "USD",
                    invoiceStatus: Sparrow.InvoiceStatus.Draft,
                    invoiceAmount: 10.00m);
                var resultUpdateInvoice = await _sparrow_creditcard.UpdateInvoice(
                    invoiceNumber: resultCreateInvoice.InvoiceNumber,
                    invoiceStatus: Sparrow.InvoiceStatus.Active);

                Log(SparrowResponseSamples.EnterSample("invoicing/update-invoice.md", "UpdateInvoice", resultUpdateInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: ""12/01/2017"", 
    currency: ""USD"", 
    invoiceStatus: Sparrow.InvoiceStatus.Draft, 
    invoiceAmount: 10.00m);
var result = await _sparrow.UpdateInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    invoiceStatus: Sparrow.InvoiceStatus.Active);"));

                Log(resultCreateInvoice.CreateResponseDemo("resultCreateInvoice"));
                Log(resultUpdateInvoice.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("invoicing/update-invoice.md", "UpdateInvoice", resultUpdateInvoice.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultSimpleRefund = await _sparrow_creditcard.SimpleRefund(
                    transId: resultSimpleSale.TransId,
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("issuing-a-refund/Simple-refund.md", "SimpleRefund", resultSimpleRefund.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.SimpleRefund(
    transId: resultSimpleSale.TransId, 
    amount: 9.99m);"));

                Log(resultSimpleSale.CreateResponseDemo("resultSimpleSale"));
                Log(resultSimpleRefund.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("issuing-a-refund/Simple-refund.md", "SimpleRefund", resultSimpleRefund.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultAdvancedRefund = await _sparrow_creditcard.AdvancedRefund(
                    transId: resultSimpleSale.TransId,
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("issuing-a-refund/advanced-refund.md", "AdvancedRefund", resultAdvancedRefund.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedRefund(
    transId: resultSimpleSale.TransId, 
    amount: 9.99m);"));

                Log(resultSimpleSale.CreateResponseDemo("resultSimpleSale"));
                Log(resultAdvancedRefund.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("issuing-a-refund/advanced-refund.md", "AdvancedRefund", resultAdvancedRefund.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultAdvancedVoid = await _sparrow_creditcard.AdvancedVoid(
                    transId: resultSimpleSale.TransId);

                Log(SparrowResponseSamples.EnterSample("issuing-a-void/advanced-void.md", "AdvancedVoid", resultAdvancedVoid.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedVoid(
    transId: resultSimpleSale.TransId);"));

                Log(resultSimpleSale.CreateResponseDemo("resultSimpleSale"));
                Log(resultAdvancedVoid.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("issuing-a-void/advanced-void.md", "AdvancedVoid", resultAdvancedVoid.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultSimpleVoid = await _sparrow_creditcard.SimpleVoid(
                    transId: resultSimpleSale.TransId);

                Log(SparrowResponseSamples.EnterSample("issuing-a-void/simple-void.md", "SimpleVoid", resultSimpleVoid.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.SimpleVoid(
    transId: resultSimpleSale.TransId);"));

                Log(resultSimpleSale.CreateResponseDemo("resultSimpleSale"));
                Log(resultSimpleVoid.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("issuing-a-void/simple-void.md", "SimpleVoid", resultSimpleVoid.IsSuccess));
            }

            if (!!true)
            {
                var resultAddOrUpdateSequence = await _sparrow_creditcard.AddOrUpdateSequence(
                    sequenceSteps: new[] { new Sparrow.SequenceStep { } });

                Log(SparrowResponseSamples.EnterSample("payment-plans/add-update-sequence.md", "AddOrUpdateSequence", resultAddOrUpdateSequence.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AddOrUpdateSequence(
    sequenceSteps: new []{ new Sparrow.SequenceStep{  } });"));

                Log(resultAddOrUpdateSequence.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/add-update-sequence.md", "AddOrUpdateSequence", resultAddOrUpdateSequence.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                    planName: "PaymentPlan1",
                    planDesc: "1st Payment Plan",
                    startDate: "01/31/2017",
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
                var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(
                    customerToken: resultAddCustomer.CustomerToken,
                    planToken: resultCreatePaymentPlan.PlanToken,
                    paymentToken: resultAddCustomer.PaymentTokens[0]);

                Log(SparrowResponseSamples.EnterSample("payment-plans/assign-payment-plan.md", "AssignPaymentPlanToCustomer", resultAssignPaymentPlanToCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: ""PaymentPlan1"", 
    planDesc: ""1st Payment Plan"", 
    startDate: ""01/31/2017"", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);"));

                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultCreatePaymentPlan.CreateResponseDemo("resultCreatePaymentPlan"));
                Log(resultAssignPaymentPlanToCustomer.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/assign-payment-plan.md", "AssignPaymentPlanToCustomer", resultAssignPaymentPlanToCustomer.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                    planName: "PaymentPlan1",
                    planDesc: "1st Payment Plan",
                    startDate: "01/31/2017",
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
                var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(
                    customerToken: resultAddCustomer.CustomerToken,
                    planToken: resultCreatePaymentPlan.PlanToken,
                    paymentToken: resultAddCustomer.PaymentTokens[0]);
                var resultCancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(
                    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken);

                Log(SparrowResponseSamples.EnterSample("payment-plans/cancel-plan-assignment.md", "CancelPlanAssignment", resultCancelPlanAssignment.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: ""PaymentPlan1"", 
    planDesc: ""1st Payment Plan"", 
    startDate: ""01/31/2017"", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.CancelPlanAssignment(
    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken);"));

                Log(resultAssignPaymentPlanToCustomer.CreateResponseDemo("resultAssignPaymentPlanToCustomer"));
                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultCreatePaymentPlan.CreateResponseDemo("resultCreatePaymentPlan"));
                Log(resultCancelPlanAssignment.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/cancel-plan-assignment.md", "CancelPlanAssignment", resultCancelPlanAssignment.IsSuccess));
            }

            if (!!true)
            {
                var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                    planName: "PaymentPlan1",
                    planDesc: "1st Payment Plan",
                    startDate: "01/31/2017",
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });

                Log(SparrowResponseSamples.EnterSample("payment-plans/create-plan.md", "CreatePaymentPlan", resultCreatePaymentPlan.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.CreatePaymentPlan(
    planName: ""PaymentPlan1"", 
    planDesc: ""1st Payment Plan"", 
    startDate: ""01/31/2017"", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });"));

                Log(resultCreatePaymentPlan.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/create-plan.md", "CreatePaymentPlan", resultCreatePaymentPlan.IsSuccess));
            }

            if (!!true)
            {
                var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                    planName: "PaymentPlan1",
                    planDesc: "1st Payment Plan",
                    startDate: "01/31/2017",
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
                var resultDeletePlan = await _sparrow_creditcard.DeletePlan(
                    token: resultCreatePaymentPlan.PlanToken);

                Log(SparrowResponseSamples.EnterSample("payment-plans/delete-plan.md", "DeletePlan", resultDeletePlan.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: ""PaymentPlan1"", 
    planDesc: ""1st Payment Plan"", 
    startDate: ""01/31/2017"", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.DeletePlan(
    token: resultCreatePaymentPlan.PlanToken);"));

                Log(resultCreatePaymentPlan.CreateResponseDemo("resultCreatePaymentPlan"));
                Log(resultDeletePlan.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/delete-plan.md", "DeletePlan", resultDeletePlan.IsSuccess));
            }

            if (!!true)
            {
                var resultDeleteSequence = await _sparrow_creditcard.DeleteSequence(
                    deleteSequenceSteps: new[] { new Sparrow.SequenceStepToDelete { } });

                Log(SparrowResponseSamples.EnterSample("payment-plans/delete-sequence.md", "DeleteSequence", resultDeleteSequence.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.DeleteSequence(
    deleteSequenceSteps: new []{ new Sparrow.SequenceStepToDelete{  } });"));

                Log(resultDeleteSequence.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/delete-sequence.md", "DeleteSequence", resultDeleteSequence.IsSuccess));
            }

            if (!!true)
            {
                var resultNotificationSettings = await _sparrow_creditcard.NotificationSettings();

                Log(SparrowResponseSamples.EnterSample("payment-plans/notifications.md", "NotificationSettings", resultNotificationSettings.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.NotificationSettings();"));

                Log(resultNotificationSettings.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/notifications.md", "NotificationSettings", resultNotificationSettings.IsSuccess));
            }

            if (!!true)
            {
                var resultBuildSequence = await _sparrow_creditcard.BuildSequence(
                    sequenceSteps: new[] { new Sparrow.SequenceStep { } });

                Log(SparrowResponseSamples.EnterSample("payment-plans/sequences.md", "BuildSequence", resultBuildSequence.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.BuildSequence(
    sequenceSteps: new []{ new Sparrow.SequenceStep{  } });"));

                Log(resultBuildSequence.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/sequences.md", "BuildSequence", resultBuildSequence.IsSuccess));
            }

            if (!!true)
            {
                var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                    defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                    paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" } } });
                var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                    planName: "PaymentPlan1",
                    planDesc: "1st Payment Plan",
                    startDate: "01/01/2018",
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
                var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(
                    customerToken: resultAddCustomer.CustomerToken,
                    planToken: resultCreatePaymentPlan.PlanToken,
                    paymentToken: resultAddCustomer.PaymentTokens[0]);
                var resultUpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(
                    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken,
                    startDate: "02/02/2020");

                Log(SparrowResponseSamples.EnterSample("payment-plans/update-plan-assignment.md", "UpdatePaymentPlanAssignment", resultUpdatePaymentPlanAssignment.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = ""John"", LastName = ""Doe"" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: ""PaymentPlan1"", 
    planDesc: ""1st Payment Plan"", 
    startDate: ""01/01/2018"", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.UpdatePaymentPlanAssignment(
    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken, 
    startDate: ""02/02/2020"");"));

                Log(resultAssignPaymentPlanToCustomer.CreateResponseDemo("resultAssignPaymentPlanToCustomer"));
                Log(resultAddCustomer.CreateResponseDemo("resultAddCustomer"));
                Log(resultCreatePaymentPlan.CreateResponseDemo("resultCreatePaymentPlan"));
                Log(resultUpdatePaymentPlanAssignment.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/update-plan-assignment.md", "UpdatePaymentPlanAssignment", resultUpdatePaymentPlanAssignment.IsSuccess));
            }

            if (!!true)
            {
                var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                    planName: "PaymentPlan1",
                    planDesc: "1st Payment Plan",
                    startDate: "01/31/2017",
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 10.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
                var resultUpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(
                    token: resultCreatePaymentPlan.PlanToken,
                    sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 20.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12, OperationType = Sparrow.OperationType_AddsequenceUpdatesequenceDeletesequence.Updatesequence } });

                Log(SparrowResponseSamples.EnterSample("payment-plans/update-plan.md", "UpdatePaymentPlan", resultUpdatePaymentPlan.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: ""PaymentPlan1"", 
    planDesc: ""1st Payment Plan"", 
    startDate: ""01/31/2017"", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 10.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.UpdatePaymentPlan(
    token: resultCreatePaymentPlan.PlanToken, 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 20.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12, OperationType = Sparrow.OperationType_AddsequenceUpdatesequenceDeletesequence.Updatesequence } });"));

                Log(resultCreatePaymentPlan.CreateResponseDemo("resultCreatePaymentPlan"));
                Log(resultUpdatePaymentPlan.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("payment-plans/update-plan.md", "UpdatePaymentPlan", resultUpdatePaymentPlan.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m,
                    authCode: "123456",
                    authDate: "01/31/2017");

                Log(SparrowResponseSamples.EnterSample("separate-auth-capture/Offline-Capture.md", "SimpleOfflineCapture", resultSimpleOfflineCapture.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleOfflineCapture(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m, 
    authCode: ""123456"", 
    authDate: ""01/31/2017"");"));

                Log(resultSimpleOfflineCapture.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("separate-auth-capture/Offline-Capture.md", "SimpleOfflineCapture", resultSimpleOfflineCapture.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultAdvancedCapture = await _sparrow_creditcard.AdvancedCapture(
                    transId: resultSimpleAuthorization.TransId,
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("separate-auth-capture/advanced-capture.md", "AdvancedCapture", resultAdvancedCapture.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedCapture(
    transId: resultSimpleAuthorization.TransId, 
    amount: 9.99m);"));

                Log(resultSimpleAuthorization.CreateResponseDemo("resultSimpleAuthorization"));
                Log(resultAdvancedCapture.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("separate-auth-capture/advanced-capture.md", "AdvancedCapture", resultAdvancedCapture.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("separate-auth-capture/simple-auth.md", "SimpleAuthorization", resultSimpleAuthorization.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);"));

                Log(resultSimpleAuthorization.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("separate-auth-capture/simple-auth.md", "SimpleAuthorization", resultSimpleAuthorization.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(
                    creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = "1019" },
                    amount: 9.99m);
                var resultSimpleCapture = await _sparrow_creditcard.SimpleCapture(
                    transId: resultSimpleAuthorization.TransId,
                    amount: 9.99m);

                Log(SparrowResponseSamples.EnterSample("separate-auth-capture/simple-capture.md", "SimpleCapture", resultSimpleCapture.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = ""4111111111111111"", CardExp = ""1019"" }, 
    amount: 9.99m);
var result = await _sparrow.SimpleCapture(
    transId: resultSimpleAuthorization.TransId, 
    amount: 9.99m);"));

                Log(resultSimpleAuthorization.CreateResponseDemo("resultSimpleAuthorization"));
                Log(resultSimpleCapture.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("separate-auth-capture/simple-capture.md", "SimpleCapture", resultSimpleCapture.IsSuccess));
            }

            if (!!true)
            {
                var resultAdvancedStarCard = await _sparrow_starcard.AdvancedStarCard(
                    cardNum: "4111111111111111",
                    cardExp: "1019",
                    amount: 9.99m,
                    CID: "12345678901");

                Log(SparrowResponseSamples.EnterSample("starcard/advanced-starcard.md", "AdvancedStarCard", resultAdvancedStarCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.AdvancedStarCard(
    cardNum: ""4111111111111111"", 
    cardExp: ""1019"", 
    amount: 9.99m, 
    CID: ""12345678901"");"));

                Log(resultAdvancedStarCard.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("starcard/advanced-starcard.md", "AdvancedStarCard", resultAdvancedStarCard.IsSuccess));
            }

            if (!!true)
            {
                var resultSimpleStarCard = await _sparrow_starcard.SimpleStarCard(
                    cardNum: "4111111111111111",
                    amount: 9.99m,
                    CID: "12345678901");

                Log(SparrowResponseSamples.EnterSample("starcard/simple-starcard.md", "SimpleStarCard", resultSimpleStarCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
var result = await _sparrow.SimpleStarCard(
    cardNum: ""4111111111111111"", 
    amount: 9.99m, 
    CID: ""12345678901"");"));

                Log(resultSimpleStarCard.CreateResponseDemo("result"));

                Log(SparrowResponseSamples.ExitSample("starcard/simple-starcard.md", "SimpleStarCard", resultSimpleStarCard.IsSuccess));
            }

        }
    }
}
