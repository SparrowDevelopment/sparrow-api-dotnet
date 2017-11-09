using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace SparrowSdk.Tests
{
    public partial class Tests
    {

        [TestMethod]
        public async Task SimpleSale()
        {
            var result = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedSale()
        {
            var result = await _sparrow_creditcard.AdvancedSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleAuthorization()
        {
            var result = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCapture()
        {
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result = await _sparrow_creditcard.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleOfflineCapture()
        {
            var result = await _sparrow_creditcard.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleRefund()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow_creditcard.SimpleRefund(result_SimpleSale.TransId, 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedRefund()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow_creditcard.AdvancedRefund(result_SimpleSale.TransId, 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleVoid()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow_creditcard.SimpleVoid(result_SimpleSale.TransId);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedVoid()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow_creditcard.AdvancedVoid(result_SimpleSale.TransId);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PassengerSale()
        {
            var result = await _sparrow_creditcard.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleStarCard()
        {
            var result = await _sparrow_starcard.SimpleStarCard("4111111111111111", 9.99m, "12345678901");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedStarCard()
        {
            var result = await _sparrow_starcard.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleACH()
        {
            var result = await _sparrow_ach.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedACH()
        {
            var result = await _sparrow_ach.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task EWalletSimpleCredit()
        {
            var result = await _sparrow_ewallet.EWalletSimpleCredit("user@example.com", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task FiservSimpleSale()
        {
            var result = await _sparrow_creditcard.FiservSimpleSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedFiservSale()
        {
            var result = await _sparrow_creditcard.AdvancedFiservSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task MarkSuccessfulTransactionAsChargeback()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, "Testing for Success");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCardBalance()
        {
            var result = await _sparrow_creditcard.RetrieveCardBalance("4111111111111111");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DecryptCustomFields()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.DecryptCustomFields("customField1", result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task VerifyAccount()
        {
            var result = await _sparrow_creditcard.VerifyAccount("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddCustomer()
        {
            var result = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddCreditCard()
        {
            var result = await _sparrow_creditcard.AddCreditCard("John", "Doe");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddACH()
        {
            var result = await _sparrow_ach.AddACH("John", "Doe", "First Test Bank", "110000000", "1234567890123");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddStarCard()
        {
            var result = await _sparrow_starcard.AddStarCard("John", "Doe", "12345678901");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddEwallet()
        {
            var result = await _sparrow_ewallet.AddEwallet("John", "Doe");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.UpdateCustomer(result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePaymentType()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result = await _sparrow_creditcard.DeletePaymentType(result_AddCustomer.CustomerToken,
                payments: new[] { new Sparrow.DeletePaymentTypePayment { Token = result_AddCustomer.PaymentTokens[0] } });

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteDataVaultCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreatePaymentPlan()
        {
            var result = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlan()
        {
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow_creditcard.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePlan()
        {
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow_creditcard.DeletePlan(result_CreatePaymentPlan.PlanToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AssignPaymentPlanToCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlanAssignment()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken,
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions { StartDate = "02/02/2020" });

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelPlanAssignment()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result = await _sparrow_creditcard.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreateInvoice()
        {
            var result = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result = await _sparrow_creditcard.UpdateInvoice(result_CreateInvoice.InvoiceNumber,
                options: new Sparrow.UpdateInvoiceOptions { InvoiceStatus = "active" });

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow_creditcard.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow_creditcard.CancelInvoice(result_CreateInvoice.InvoiceNumber, "Testing");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoiceByCustomer()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow_creditcard.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, "Testing");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithCreditCard()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow_creditcard.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, "4111111111111111", "1019");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithBankAccount()
        {
            var result_CreateInvoice = await _sparrow_ach.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow_ach.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal",
                billing: new Sparrow.PayInvoiceWithBankAccountBilling { FirstName = "John", LastName = "Doe" });

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

    }
}
