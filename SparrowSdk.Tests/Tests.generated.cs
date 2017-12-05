using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using SparrowSdk.Samples;

namespace SparrowSdk.Tests
{
    public partial class Tests
    {

        [TestMethod]
        public async Task AdvancedECheck()
        {
            var resultAdvancedECheck = await _sparrow_ach.AdvancedECheck(
                bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                amount: 9.99m,
                contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address { Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });

            TestContext.WriteLine(resultAdvancedECheck.CreateRawLog("resultAdvancedECheck"));

            Assert.IsTrue(resultAdvancedECheck.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedECheck.Response);
            // Assert.IsTrue(resultAdvancedECheck.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedECheck.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedACH()
        {
            var resultAdvancedACH = await _sparrow_ach.AdvancedACH(
                bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                amount: 9.99m,
                contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });

            TestContext.WriteLine(resultAdvancedACH.CreateRawLog("resultAdvancedACH"));

            Assert.IsTrue(resultAdvancedACH.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedACH.Response);
            // Assert.IsTrue(resultAdvancedACH.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedACH.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleACH()
        {
            var resultSimpleACH = await _sparrow_ach.SimpleACH(
                bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                amount: 9.99m,
                contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });

            TestContext.WriteLine(resultSimpleACH.CreateRawLog("resultSimpleACH"));

            Assert.IsTrue(resultSimpleACH.IsSuccess);
            // Assert.AreEqual(1, resultSimpleACH.Response);
            // Assert.IsTrue(resultSimpleACH.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleACH.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleECheck()
        {
            var resultSimpleECheck = await _sparrow_ach.SimpleECheck(
                bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                amount: 9.99m,
                contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address { Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });

            TestContext.WriteLine(resultSimpleECheck.CreateRawLog("resultSimpleECheck"));

            Assert.IsTrue(resultSimpleECheck.IsSuccess);
            // Assert.AreEqual(1, resultSimpleECheck.Response);
            // Assert.IsTrue(resultSimpleECheck.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleECheck.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PassengerSale()
        {
            var resultPassengerSale = await _sparrow_creditcard.PassengerSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m,
                passengerName: "John Doe",
                airportCodes: new[] { "" },
                airlineCodeNumber: "AA0",
                ticketNumber: "1234567890",
                flightDateCoupons: new[] { new DateTime(2019, 10, 21) },
                flightDepartureTimeCoupons: new[] { "" },
                approvalCode: "123456",
                authCharIndicator: Sparrow.AuthCharIndicator.A,
                validationCode: "1234",
                authResponseCode: "AB");

            TestContext.WriteLine(resultPassengerSale.CreateRawLog("resultPassengerSale"));

            Assert.IsTrue(resultPassengerSale.IsSuccess);
            // Assert.AreEqual(1, resultPassengerSale.Response);
            // Assert.IsTrue(resultPassengerSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultPassengerSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCardBalance()
        {
            var resultRetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance(
                cardNum: "4111111111111111");

            TestContext.WriteLine(resultRetrieveCardBalance.CreateRawLog("resultRetrieveCardBalance"));

            Assert.IsTrue(resultRetrieveCardBalance.IsSuccess);
            // Assert.AreEqual(1, resultRetrieveCardBalance.Response);
            // Assert.IsTrue(resultRetrieveCardBalance.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultRetrieveCardBalance.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task VerifyAccount()
        {
            var resultVerifyAccount = await _sparrow_creditcard.VerifyAccount(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);

            TestContext.WriteLine(resultVerifyAccount.CreateRawLog("resultVerifyAccount"));

            Assert.IsTrue(resultVerifyAccount.IsSuccess);
            // Assert.AreEqual(1, resultVerifyAccount.Response);
            // Assert.IsTrue(resultVerifyAccount.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultVerifyAccount.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task MarkSuccessfulTransactionAsChargeback()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultMarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(
                transId: resultSimpleSale.TransId,
                reason: "Testing for Success");

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));
            TestContext.WriteLine(resultMarkSuccessfulTransactionAsChargeback.CreateRawLog("resultMarkSuccessfulTransactionAsChargeback"));

            Assert.IsTrue(resultMarkSuccessfulTransactionAsChargeback.IsSuccess);
            // Assert.AreEqual(1, resultMarkSuccessfulTransactionAsChargeback.Response);
            // Assert.IsTrue(resultMarkSuccessfulTransactionAsChargeback.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultMarkSuccessfulTransactionAsChargeback.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCredit()
        {
            var resultSimpleCredit = await _sparrow_creditcard.SimpleCredit(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleCredit.CreateRawLog("resultSimpleCredit"));

            Assert.IsTrue(resultSimpleCredit.IsSuccess);
            // Assert.AreEqual(1, resultSimpleCredit.Response);
            // Assert.IsTrue(resultSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedSale()
        {
            var resultAdvancedSale = await _sparrow_creditcard.AdvancedSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);

            TestContext.WriteLine(resultAdvancedSale.CreateRawLog("resultAdvancedSale"));

            Assert.IsTrue(resultAdvancedSale.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedSale.Response);
            // Assert.IsTrue(resultAdvancedSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleSale()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));

            Assert.IsTrue(resultSimpleSale.IsSuccess);
            // Assert.AreEqual(1, resultSimpleSale.Response);
            // Assert.IsTrue(resultSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddPaymentTypesToCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultAddPaymentTypesToCustomer = await _sparrow_creditcard.AddPaymentTypesToCustomer(
                token: resultAddCustomer.CustomerToken,
                paymentTypeToAdd: new[] { new Sparrow.PaymentTypeToAdd { PaymentType = new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) }, BankAccount = new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, Ewallet = new Sparrow.Ewallet { EwalletAccount = "user@example.com" } } } });

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultAddPaymentTypesToCustomer.CreateRawLog("resultAddPaymentTypesToCustomer"));

            Assert.IsTrue(resultAddPaymentTypesToCustomer.IsSuccess);
            // Assert.AreEqual(1, resultAddPaymentTypesToCustomer.Response);
            // Assert.IsTrue(resultAddPaymentTypesToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAddPaymentTypesToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));

            Assert.IsTrue(resultAddCustomer.IsSuccess);
            // Assert.AreEqual(1, resultAddCustomer.Response);
            // Assert.IsTrue(resultAddCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAddCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteDataVaultCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultDeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(
                token: resultAddCustomer.CustomerToken);

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultDeleteDataVaultCustomer.CreateRawLog("resultDeleteDataVaultCustomer"));

            Assert.IsTrue(resultDeleteDataVaultCustomer.IsSuccess);
            // Assert.AreEqual(1, resultDeleteDataVaultCustomer.Response);
            // Assert.IsTrue(resultDeleteDataVaultCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultDeleteDataVaultCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePaymentType()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultDeletePaymentType = await _sparrow_creditcard.DeletePaymentType(
                token: resultAddCustomer.CustomerToken,
                paymentTypeToDelete: new[] { new Sparrow.PaymentTypeToDelete { Token = resultAddCustomer.PaymentTokens[0] } });

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultDeletePaymentType.CreateRawLog("resultDeletePaymentType"));

            Assert.IsTrue(resultDeletePaymentType.IsSuccess);
            // Assert.AreEqual(1, resultDeletePaymentType.Response);
            // Assert.IsTrue(resultDeletePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultDeletePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultRetrieveCustomer = await _sparrow_creditcard.RetrieveCustomer(
                token: resultAddCustomer.CustomerToken);

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultRetrieveCustomer.CreateRawLog("resultRetrieveCustomer"));

            Assert.IsTrue(resultRetrieveCustomer.IsSuccess);
            // Assert.AreEqual(1, resultRetrieveCustomer.Response);
            // Assert.IsTrue(resultRetrieveCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultRetrieveCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrievePaymentType()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultRetrievePaymentType = await _sparrow_creditcard.RetrievePaymentType(
                token: resultAddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultRetrievePaymentType.CreateRawLog("resultRetrievePaymentType"));

            Assert.IsTrue(resultRetrievePaymentType.IsSuccess);
            // Assert.AreEqual(1, resultRetrievePaymentType.Response);
            // Assert.IsTrue(resultRetrievePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultRetrievePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultUpdateCustomer = await _sparrow_creditcard.UpdateCustomer(
                token: resultAddCustomer.CustomerToken);

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultUpdateCustomer.CreateRawLog("resultUpdateCustomer"));

            Assert.IsTrue(resultUpdateCustomer.IsSuccess);
            // Assert.AreEqual(1, resultUpdateCustomer.Response);
            // Assert.IsTrue(resultUpdateCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultUpdateCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentType()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultUpdatePaymentType = await _sparrow_creditcard.UpdatePaymentType(
                token: resultAddCustomer.CustomerToken,
                paymentTypeToUpdate: new[] { new Sparrow.PaymentTypeToUpdate { Token = resultAddCustomer.PaymentTokens[0], PaymentType = new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } } });

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultUpdatePaymentType.CreateRawLog("resultUpdatePaymentType"));

            Assert.IsTrue(resultUpdatePaymentType.IsSuccess);
            // Assert.AreEqual(1, resultUpdatePaymentType.Response);
            // Assert.IsTrue(resultUpdatePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultUpdatePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DecryptCustomFields()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultDecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields(
                fieldName: "customField1",
                token: resultAddCustomer.CustomerToken);

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultDecryptCustomFields.CreateRawLog("resultDecryptCustomFields"));

            Assert.IsTrue(resultDecryptCustomFields.IsSuccess);
            // Assert.AreEqual(1, resultDecryptCustomFields.Response);
            // Assert.IsTrue(resultDecryptCustomFields.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultDecryptCustomFields.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task EWalletSimpleCredit()
        {
            var resultEWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit(
                ewallet: new Sparrow.Ewallet { EwalletAccount = "user@example.com" },
                amount: 9.99m);

            TestContext.WriteLine(resultEWalletSimpleCredit.CreateRawLog("resultEWalletSimpleCredit"));

            Assert.IsTrue(resultEWalletSimpleCredit.IsSuccess);
            // Assert.AreEqual(1, resultEWalletSimpleCredit.Response);
            // Assert.IsTrue(resultEWalletSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultEWalletSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedFiservSale()
        {
            var resultAdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);

            TestContext.WriteLine(resultAdvancedFiservSale.CreateRawLog("resultAdvancedFiservSale"));

            Assert.IsTrue(resultAdvancedFiservSale.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedFiservSale.Response);
            // Assert.IsTrue(resultAdvancedFiservSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedFiservSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task FiservSimpleSale()
        {
            var resultFiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale(
                cardNum: "4111111111111111",
                cardExp: new DateTime(2019, 10, 21),
                amount: 9.99m);

            TestContext.WriteLine(resultFiservSimpleSale.CreateRawLog("resultFiservSimpleSale"));

            Assert.IsTrue(resultFiservSimpleSale.IsSuccess);
            // Assert.AreEqual(1, resultFiservSimpleSale.Response);
            // Assert.IsTrue(resultFiservSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultFiservSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoiceByCustomer()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Active,
                invoiceAmount: 10.00m);
            var resultCancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(
                invoiceNumber: resultCreateInvoice.InvoiceNumber,
                invoiceStatusReason: "Testing");

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));
            TestContext.WriteLine(resultCancelInvoiceByCustomer.CreateRawLog("resultCancelInvoiceByCustomer"));

            Assert.IsTrue(resultCancelInvoiceByCustomer.IsSuccess);
            // Assert.AreEqual(1, resultCancelInvoiceByCustomer.Response);
            // Assert.IsTrue(resultCancelInvoiceByCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCancelInvoiceByCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoice()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Active,
                invoiceAmount: 10.00m);
            var resultCancelInvoice = await _sparrow_creditcard.CancelInvoice(
                invoiceNumber: resultCreateInvoice.InvoiceNumber,
                invoiceStatusReason: "Testing");

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));
            TestContext.WriteLine(resultCancelInvoice.CreateRawLog("resultCancelInvoice"));

            Assert.IsTrue(resultCancelInvoice.IsSuccess);
            // Assert.AreEqual(1, resultCancelInvoice.Response);
            // Assert.IsTrue(resultCancelInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCancelInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreateInvoice()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Active,
                invoiceAmount: 10.00m);

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));

            Assert.IsTrue(resultCreateInvoice.IsSuccess);
            // Assert.AreEqual(1, resultCreateInvoice.Response);
            // Assert.IsTrue(resultCreateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCreateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveInvoice()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Active,
                invoiceAmount: 10.00m);
            var resultRetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(
                invoiceNumber: resultCreateInvoice.InvoiceNumber);

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));
            TestContext.WriteLine(resultRetrieveInvoice.CreateRawLog("resultRetrieveInvoice"));

            Assert.IsTrue(resultRetrieveInvoice.IsSuccess);
            // Assert.AreEqual(1, resultRetrieveInvoice.Response);
            // Assert.IsTrue(resultRetrieveInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultRetrieveInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithBankAccount()
        {
            var resultCreateInvoice = await _sparrow_ach.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Active,
                invoiceAmount: 10.00m);
            var resultPayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(
                invoiceNumber: resultCreateInvoice.InvoiceNumber,
                bankAccount: new Sparrow.BankAccount { BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal },
                contactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" });

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));
            TestContext.WriteLine(resultPayInvoiceWithBankAccount.CreateRawLog("resultPayInvoiceWithBankAccount"));

            Assert.IsTrue(resultPayInvoiceWithBankAccount.IsSuccess);
            // Assert.AreEqual(1, resultPayInvoiceWithBankAccount.Response);
            // Assert.IsTrue(resultPayInvoiceWithBankAccount.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultPayInvoiceWithBankAccount.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithCreditCard()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Active,
                invoiceAmount: 10.00m);
            var resultPayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(
                invoiceNumber: resultCreateInvoice.InvoiceNumber,
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) });

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));
            TestContext.WriteLine(resultPayInvoiceWithCreditCard.CreateRawLog("resultPayInvoiceWithCreditCard"));

            Assert.IsTrue(resultPayInvoiceWithCreditCard.IsSuccess);
            // Assert.AreEqual(1, resultPayInvoiceWithCreditCard.Response);
            // Assert.IsTrue(resultPayInvoiceWithCreditCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultPayInvoiceWithCreditCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateInvoice()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice(
                invoiceDate: new DateTime(2019, 10, 21),
                currency: "USD",
                invoiceStatus: Sparrow.InvoiceStatus.Draft,
                invoiceAmount: 10.00m);
            var resultUpdateInvoice = await _sparrow_creditcard.UpdateInvoice(
                invoiceNumber: resultCreateInvoice.InvoiceNumber,
                invoiceStatus: Sparrow.InvoiceStatus.Active);

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));
            TestContext.WriteLine(resultUpdateInvoice.CreateRawLog("resultUpdateInvoice"));

            Assert.IsTrue(resultUpdateInvoice.IsSuccess);
            // Assert.AreEqual(1, resultUpdateInvoice.Response);
            // Assert.IsTrue(resultUpdateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultUpdateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleRefund()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultSimpleRefund = await _sparrow_creditcard.SimpleRefund(
                transId: resultSimpleSale.TransId,
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));
            TestContext.WriteLine(resultSimpleRefund.CreateRawLog("resultSimpleRefund"));

            Assert.IsTrue(resultSimpleRefund.IsSuccess);
            // Assert.AreEqual(1, resultSimpleRefund.Response);
            // Assert.IsTrue(resultSimpleRefund.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleRefund.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedRefund()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultAdvancedRefund = await _sparrow_creditcard.AdvancedRefund(
                transId: resultSimpleSale.TransId,
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));
            TestContext.WriteLine(resultAdvancedRefund.CreateRawLog("resultAdvancedRefund"));

            Assert.IsTrue(resultAdvancedRefund.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedRefund.Response);
            // Assert.IsTrue(resultAdvancedRefund.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedRefund.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedVoid()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultAdvancedVoid = await _sparrow_creditcard.AdvancedVoid(
                transId: resultSimpleSale.TransId);

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));
            TestContext.WriteLine(resultAdvancedVoid.CreateRawLog("resultAdvancedVoid"));

            Assert.IsTrue(resultAdvancedVoid.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedVoid.Response);
            // Assert.IsTrue(resultAdvancedVoid.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedVoid.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleVoid()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultSimpleVoid = await _sparrow_creditcard.SimpleVoid(
                transId: resultSimpleSale.TransId);

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));
            TestContext.WriteLine(resultSimpleVoid.CreateRawLog("resultSimpleVoid"));

            Assert.IsTrue(resultSimpleVoid.IsSuccess);
            // Assert.AreEqual(1, resultSimpleVoid.Response);
            // Assert.IsTrue(resultSimpleVoid.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleVoid.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AssignPaymentPlanToCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
            var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(
                customerToken: resultAddCustomer.CustomerToken,
                planToken: resultCreatePaymentPlan.PlanToken,
                paymentToken: resultAddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultAssignPaymentPlanToCustomer.CreateRawLog("resultAssignPaymentPlanToCustomer"));

            Assert.IsTrue(resultAssignPaymentPlanToCustomer.IsSuccess);
            // Assert.AreEqual(1, resultAssignPaymentPlanToCustomer.Response);
            // Assert.IsTrue(resultAssignPaymentPlanToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAssignPaymentPlanToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelPlanAssignment()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
            var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(
                customerToken: resultAddCustomer.CustomerToken,
                planToken: resultCreatePaymentPlan.PlanToken,
                paymentToken: resultAddCustomer.PaymentTokens[0]);
            var resultCancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(
                assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken);

            TestContext.WriteLine(resultAssignPaymentPlanToCustomer.CreateRawLog("resultAssignPaymentPlanToCustomer"));
            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultCancelPlanAssignment.CreateRawLog("resultCancelPlanAssignment"));

            Assert.IsTrue(resultCancelPlanAssignment.IsSuccess);
            // Assert.AreEqual(1, resultCancelPlanAssignment.Response);
            // Assert.IsTrue(resultCancelPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCancelPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreatePaymentPlan()
        {
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });

            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));

            Assert.IsTrue(resultCreatePaymentPlan.IsSuccess);
            // Assert.AreEqual(1, resultCreatePaymentPlan.Response);
            // Assert.IsTrue(resultCreatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCreatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePlan()
        {
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
            var resultDeletePlan = await _sparrow_creditcard.DeletePlan(
                token: resultCreatePaymentPlan.PlanToken);

            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultDeletePlan.CreateRawLog("resultDeletePlan"));

            Assert.IsTrue(resultDeletePlan.IsSuccess);
            // Assert.AreEqual(1, resultDeletePlan.Response);
            // Assert.IsTrue(resultDeletePlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultDeletePlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteSequence()
        {
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
            var resultDeleteSequence = await _sparrow_creditcard.DeleteSequence(
                deleteSequenceSteps: new[] { new Sparrow.SequenceStepToDelete { Sequence = 1 } },
                token: resultCreatePaymentPlan.PlanToken);

            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultDeleteSequence.CreateRawLog("resultDeleteSequence"));

            Assert.IsTrue(resultDeleteSequence.IsSuccess);
            // Assert.AreEqual(1, resultDeleteSequence.Response);
            // Assert.IsTrue(resultDeleteSequence.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultDeleteSequence.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlanAssignment()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer(
                defaultContactInfo: new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" },
                paymentType: new[] { new Sparrow.PaymentType { PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo { FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) } } });
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
            var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(
                customerToken: resultAddCustomer.CustomerToken,
                planToken: resultCreatePaymentPlan.PlanToken,
                paymentToken: resultAddCustomer.PaymentTokens[0]);
            var resultUpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(
                assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken,
                startDate: new DateTime(2019, 10, 21));

            TestContext.WriteLine(resultAssignPaymentPlanToCustomer.CreateRawLog("resultAssignPaymentPlanToCustomer"));
            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));
            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultUpdatePaymentPlanAssignment.CreateRawLog("resultUpdatePaymentPlanAssignment"));

            Assert.IsTrue(resultUpdatePaymentPlanAssignment.IsSuccess);
            // Assert.AreEqual(1, resultUpdatePaymentPlanAssignment.Response);
            // Assert.IsTrue(resultUpdatePaymentPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultUpdatePaymentPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlan()
        {
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(
                planName: "PaymentPlan1",
                planDesc: "1st Payment Plan",
                startDate: new DateTime(2019, 10, 21),
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 10.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
            var resultUpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(
                token: resultCreatePaymentPlan.PlanToken,
                sequenceSteps: new[] { new Sparrow.SequenceStep { Sequence = 1, Amount = 20.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12, OperationType = Sparrow.OperationType.Updatesequence } });

            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultUpdatePaymentPlan.CreateRawLog("resultUpdatePaymentPlan"));

            Assert.IsTrue(resultUpdatePaymentPlan.IsSuccess);
            // Assert.AreEqual(1, resultUpdatePaymentPlan.Response);
            // Assert.IsTrue(resultUpdatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultUpdatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleOfflineCapture()
        {
            var resultSimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m,
                authCode: "123456",
                authDate: new DateTime(2019, 10, 21));

            TestContext.WriteLine(resultSimpleOfflineCapture.CreateRawLog("resultSimpleOfflineCapture"));

            Assert.IsTrue(resultSimpleOfflineCapture.IsSuccess);
            // Assert.AreEqual(1, resultSimpleOfflineCapture.Response);
            // Assert.IsTrue(resultSimpleOfflineCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleOfflineCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedCapture()
        {
            var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultAdvancedCapture = await _sparrow_creditcard.AdvancedCapture(
                transId: resultSimpleAuthorization.TransId,
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleAuthorization.CreateRawLog("resultSimpleAuthorization"));
            TestContext.WriteLine(resultAdvancedCapture.CreateRawLog("resultAdvancedCapture"));

            Assert.IsTrue(resultAdvancedCapture.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedCapture.Response);
            // Assert.IsTrue(resultAdvancedCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleAuthorization()
        {
            var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleAuthorization.CreateRawLog("resultSimpleAuthorization"));

            Assert.IsTrue(resultSimpleAuthorization.IsSuccess);
            // Assert.AreEqual(1, resultSimpleAuthorization.Response);
            // Assert.IsTrue(resultSimpleAuthorization.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleAuthorization.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCapture()
        {
            var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(
                creditCard: new Sparrow.CreditCard { CardNum = "4111111111111111", CardExp = new DateTime(2019, 10, 21) },
                amount: 9.99m);
            var resultSimpleCapture = await _sparrow_creditcard.SimpleCapture(
                transId: resultSimpleAuthorization.TransId,
                amount: 9.99m);

            TestContext.WriteLine(resultSimpleAuthorization.CreateRawLog("resultSimpleAuthorization"));
            TestContext.WriteLine(resultSimpleCapture.CreateRawLog("resultSimpleCapture"));

            Assert.IsTrue(resultSimpleCapture.IsSuccess);
            // Assert.AreEqual(1, resultSimpleCapture.Response);
            // Assert.IsTrue(resultSimpleCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedStarCard()
        {
            var resultAdvancedStarCard = await _sparrow_starcard.AdvancedStarCard(
                cardNum: "4111111111111111",
                cardExp: new DateTime(2019, 10, 21),
                amount: 9.99m,
                CID: "12345678901");

            TestContext.WriteLine(resultAdvancedStarCard.CreateRawLog("resultAdvancedStarCard"));

            Assert.IsTrue(resultAdvancedStarCard.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedStarCard.Response);
            // Assert.IsTrue(resultAdvancedStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleStarCard()
        {
            var resultSimpleStarCard = await _sparrow_starcard.SimpleStarCard(
                cardNum: "4111111111111111",
                amount: 9.99m,
                CID: "12345678901");

            TestContext.WriteLine(resultSimpleStarCard.CreateRawLog("resultSimpleStarCard"));

            Assert.IsTrue(resultSimpleStarCard.IsSuccess);
            // Assert.AreEqual(1, resultSimpleStarCard.Response);
            // Assert.IsTrue(resultSimpleStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

    }
}
