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
            var resultAdvancedECheck = await _sparrow_ach.AdvancedECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m,
                billing: new Sparrow.AdvancedECheckBilling { FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });

            TestContext.WriteLine(resultAdvancedECheck.CreateRawLog("resultAdvancedECheck"));

            Assert.IsTrue(resultAdvancedECheck.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedECheck.Response);
            // Assert.IsTrue(resultAdvancedECheck.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedECheck.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedACH()
        {
            var resultAdvancedACH = await _sparrow_ach.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            TestContext.WriteLine(resultAdvancedACH.CreateRawLog("resultAdvancedACH"));

            Assert.IsTrue(resultAdvancedACH.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedACH.Response);
            // Assert.IsTrue(resultAdvancedACH.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedACH.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleACH()
        {
            var resultSimpleACH = await _sparrow_ach.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            TestContext.WriteLine(resultSimpleACH.CreateRawLog("resultSimpleACH"));

            Assert.IsTrue(resultSimpleACH.IsSuccess);
            // Assert.AreEqual(1, resultSimpleACH.Response);
            // Assert.IsTrue(resultSimpleACH.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleACH.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleECheck()
        {
            var resultSimpleECheck = await _sparrow_ach.SimpleECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m,
                billing: new Sparrow.SimpleECheckBilling { Company = "Sparrow One", FirstName = "John", LastName = "Doe", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });

            TestContext.WriteLine(resultSimpleECheck.CreateRawLog("resultSimpleECheck"));

            Assert.IsTrue(resultSimpleECheck.IsSuccess);
            // Assert.AreEqual(1, resultSimpleECheck.Response);
            // Assert.IsTrue(resultSimpleECheck.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleECheck.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PassengerSale()
        {
            var resultPassengerSale = await _sparrow_creditcard.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");

            TestContext.WriteLine(resultPassengerSale.CreateRawLog("resultPassengerSale"));

            Assert.IsTrue(resultPassengerSale.IsSuccess);
            // Assert.AreEqual(1, resultPassengerSale.Response);
            // Assert.IsTrue(resultPassengerSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultPassengerSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCardBalance()
        {
            var resultRetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance("4111111111111111");

            TestContext.WriteLine(resultRetrieveCardBalance.CreateRawLog("resultRetrieveCardBalance"));

            Assert.IsTrue(resultRetrieveCardBalance.IsSuccess);
            // Assert.AreEqual(1, resultRetrieveCardBalance.Response);
            // Assert.IsTrue(resultRetrieveCardBalance.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultRetrieveCardBalance.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task VerifyAccount()
        {
            var resultVerifyAccount = await _sparrow_creditcard.VerifyAccount("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultVerifyAccount.CreateRawLog("resultVerifyAccount"));

            Assert.IsTrue(resultVerifyAccount.IsSuccess);
            // Assert.AreEqual(1, resultVerifyAccount.Response);
            // Assert.IsTrue(resultVerifyAccount.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultVerifyAccount.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task MarkSuccessfulTransactionAsChargeback()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var resultMarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(resultSimpleSale.TransId, "Testing for Success");

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
            var resultSimpleCredit = await _sparrow_creditcard.SimpleCredit("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultSimpleCredit.CreateRawLog("resultSimpleCredit"));

            Assert.IsTrue(resultSimpleCredit.IsSuccess);
            // Assert.AreEqual(1, resultSimpleCredit.Response);
            // Assert.IsTrue(resultSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedSale()
        {
            var resultAdvancedSale = await _sparrow_creditcard.AdvancedSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultAdvancedSale.CreateRawLog("resultAdvancedSale"));

            Assert.IsTrue(resultAdvancedSale.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedSale.Response);
            // Assert.IsTrue(resultAdvancedSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleSale()
        {
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultSimpleSale.CreateRawLog("resultSimpleSale"));

            Assert.IsTrue(resultSimpleSale.IsSuccess);
            // Assert.AreEqual(1, resultSimpleSale.Response);
            // Assert.IsTrue(resultSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddPaymentTypesToCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var resultAddPaymentTypesToCustomer = await _sparrow_creditcard.AddPaymentTypesToCustomer(resultAddCustomer.CustomerToken);

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });

            TestContext.WriteLine(resultAddCustomer.CreateRawLog("resultAddCustomer"));

            Assert.IsTrue(resultAddCustomer.IsSuccess);
            // Assert.AreEqual(1, resultAddCustomer.Response);
            // Assert.IsTrue(resultAddCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAddCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteDataVaultCustomer()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var resultDeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(resultAddCustomer.CustomerToken);

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultDeletePaymentType = await _sparrow_creditcard.DeletePaymentType(resultAddCustomer.CustomerToken,
                payments: new[] { new Sparrow.DeletePaymentTypePayment { Token = resultAddCustomer.PaymentTokens[0] } });

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var resultRetrieveCustomer = await _sparrow_creditcard.RetrieveCustomer(resultAddCustomer.CustomerToken);

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultRetrievePaymentType = await _sparrow_creditcard.RetrievePaymentType(resultAddCustomer.PaymentTokens[0]);

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultUpdateCustomer = await _sparrow_creditcard.UpdateCustomer(resultAddCustomer.CustomerToken,
                billing: new Sparrow.UpdateCustomerBilling { Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254" });

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultUpdatePaymentType = await _sparrow_creditcard.UpdatePaymentType(resultAddCustomer.CustomerToken,
                payments: new[] { new Sparrow.UpdatePaymentTypePayment { Token = resultAddCustomer.PaymentTokens[0] } });

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var resultDecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields("customField1", resultAddCustomer.CustomerToken);

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
            var resultEWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit("user@example.com", 9.99m);

            TestContext.WriteLine(resultEWalletSimpleCredit.CreateRawLog("resultEWalletSimpleCredit"));

            Assert.IsTrue(resultEWalletSimpleCredit.IsSuccess);
            // Assert.AreEqual(1, resultEWalletSimpleCredit.Response);
            // Assert.IsTrue(resultEWalletSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultEWalletSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedFiservSale()
        {
            var resultAdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultAdvancedFiservSale.CreateRawLog("resultAdvancedFiservSale"));

            Assert.IsTrue(resultAdvancedFiservSale.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedFiservSale.Response);
            // Assert.IsTrue(resultAdvancedFiservSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedFiservSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task FiservSimpleSale()
        {
            var resultFiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultFiservSimpleSale.CreateRawLog("resultFiservSimpleSale"));

            Assert.IsTrue(resultFiservSimpleSale.IsSuccess);
            // Assert.AreEqual(1, resultFiservSimpleSale.Response);
            // Assert.IsTrue(resultFiservSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultFiservSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoiceByCustomer()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var resultCancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(resultCreateInvoice.InvoiceNumber, "Testing");

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
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var resultCancelInvoice = await _sparrow_creditcard.CancelInvoice(resultCreateInvoice.InvoiceNumber, "Testing");

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
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);

            TestContext.WriteLine(resultCreateInvoice.CreateRawLog("resultCreateInvoice"));

            Assert.IsTrue(resultCreateInvoice.IsSuccess);
            // Assert.AreEqual(1, resultCreateInvoice.Response);
            // Assert.IsTrue(resultCreateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCreateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveInvoice()
        {
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var resultRetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(resultCreateInvoice.InvoiceNumber);

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
            var resultCreateInvoice = await _sparrow_ach.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var resultPayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(resultCreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal",
                billing: new Sparrow.PayInvoiceWithBankAccountBilling { FirstName = "John", LastName = "Doe" });

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
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var resultPayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(resultCreateInvoice.InvoiceNumber, "4111111111111111", "1019");

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
            var resultCreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var resultUpdateInvoice = await _sparrow_creditcard.UpdateInvoice(resultCreateInvoice.InvoiceNumber,
                options: new Sparrow.UpdateInvoiceOptions { InvoiceStatus = "active" });

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
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var resultSimpleRefund = await _sparrow_creditcard.SimpleRefund(resultSimpleSale.TransId, 9.99m);

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
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var resultAdvancedRefund = await _sparrow_creditcard.AdvancedRefund(resultSimpleSale.TransId, 9.99m);

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
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var resultAdvancedVoid = await _sparrow_creditcard.AdvancedVoid(resultSimpleSale.TransId);

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
            var resultSimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var resultSimpleVoid = await _sparrow_creditcard.SimpleVoid(resultSimpleSale.TransId);

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(resultAddCustomer.CustomerToken, resultCreatePaymentPlan.PlanToken, resultAddCustomer.PaymentTokens[0]);

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
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(resultAddCustomer.CustomerToken, resultCreatePaymentPlan.PlanToken, resultAddCustomer.PaymentTokens[0]);
            var resultCancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(resultAssignPaymentPlanToCustomer.AssignmentToken);

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
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));

            Assert.IsTrue(resultCreatePaymentPlan.IsSuccess);
            // Assert.AreEqual(1, resultCreatePaymentPlan.Response);
            // Assert.IsTrue(resultCreatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultCreatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePlan()
        {
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var resultDeletePlan = await _sparrow_creditcard.DeletePlan(resultCreatePaymentPlan.PlanToken);

            TestContext.WriteLine(resultCreatePaymentPlan.CreateRawLog("resultCreatePaymentPlan"));
            TestContext.WriteLine(resultDeletePlan.CreateRawLog("resultDeletePlan"));

            Assert.IsTrue(resultDeletePlan.IsSuccess);
            // Assert.AreEqual(1, resultDeletePlan.Response);
            // Assert.IsTrue(resultDeletePlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultDeletePlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlanAssignment()
        {
            var resultAddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var resultAssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(resultAddCustomer.CustomerToken, resultCreatePaymentPlan.PlanToken, resultAddCustomer.PaymentTokens[0]);
            var resultUpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(resultAssignPaymentPlanToCustomer.AssignmentToken,
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions { StartDate = "02/02/2020" });

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
            var resultCreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 10.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var resultUpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(resultCreatePaymentPlan.PlanToken,
                sequences: new[] { new Sparrow.AddOrUpdateSequenceSequence { OperationType = "updatesequence", Sequence = 1, Amount = 20.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

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
            var resultSimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");

            TestContext.WriteLine(resultSimpleOfflineCapture.CreateRawLog("resultSimpleOfflineCapture"));

            Assert.IsTrue(resultSimpleOfflineCapture.IsSuccess);
            // Assert.AreEqual(1, resultSimpleOfflineCapture.Response);
            // Assert.IsTrue(resultSimpleOfflineCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleOfflineCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedCapture()
        {
            var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var resultAdvancedCapture = await _sparrow_creditcard.AdvancedCapture(resultSimpleAuthorization.TransId, 9.99m);

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
            var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(resultSimpleAuthorization.CreateRawLog("resultSimpleAuthorization"));

            Assert.IsTrue(resultSimpleAuthorization.IsSuccess);
            // Assert.AreEqual(1, resultSimpleAuthorization.Response);
            // Assert.IsTrue(resultSimpleAuthorization.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleAuthorization.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCapture()
        {
            var resultSimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var resultSimpleCapture = await _sparrow_creditcard.SimpleCapture(resultSimpleAuthorization.TransId, 9.99m);

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
            var resultAdvancedStarCard = await _sparrow_starcard.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");

            TestContext.WriteLine(resultAdvancedStarCard.CreateRawLog("resultAdvancedStarCard"));

            Assert.IsTrue(resultAdvancedStarCard.IsSuccess);
            // Assert.AreEqual(1, resultAdvancedStarCard.Response);
            // Assert.IsTrue(resultAdvancedStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultAdvancedStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleStarCard()
        {
            var resultSimpleStarCard = await _sparrow_starcard.SimpleStarCard("4111111111111111", 9.99m, "12345678901");

            TestContext.WriteLine(resultSimpleStarCard.CreateRawLog("resultSimpleStarCard"));

            Assert.IsTrue(resultSimpleStarCard.IsSuccess);
            // Assert.AreEqual(1, resultSimpleStarCard.Response);
            // Assert.IsTrue(resultSimpleStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(resultSimpleStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

    }
}
