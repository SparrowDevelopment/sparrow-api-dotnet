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
            var result = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedSale()
        {
            var result = await _sparrow_creditcard.AdvancedSale("4005562231212149", "1019", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleAuthorization()
        {
            var result = await _sparrow_creditcard.SimpleAuthorization("4005562231212149", "1019", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCapture()
        {
            var result1 = await _sparrow_creditcard.SimpleAuthorization("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.SimpleCapture(result1.TransId, 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleOfflineCapture()
        {
            var result = await _sparrow_creditcard.SimpleOfflineCapture("4005562231212149", "1019", 9.95m, "123456", "01/31/2017");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleRefund()
        {
            var result1 = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.SimpleRefund(result1.TransId, 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedRefund()
        {
            var result1 = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.AdvancedRefund(result1.TransId, 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleVoid()
        {
            var result1 = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.SimpleVoid(result1.TransId);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedVoid()
        {
            var result1 = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.AdvancedVoid(result1.TransId);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PassengerSale()
        {
            var result = await _sparrow_creditcard.PassengerSale("4005562231212149", "1019", 9.95m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleStarCard()
        {
            var result = await _sparrow_starcard.SimpleStarCard("4005562231212149", 9.95m, "12345678901");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedStarCard()
        {
            var result = await _sparrow_starcard.AdvancedStarCard("4005562231212149", "1019", 9.95m, "12345678901");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleACH()
        {
            var result = await _sparrow_ach.SimpleACH("addcustomer", "First Test Bank", "110000000", "1234567890123", "checking", 9.95m, "John", "Doe");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedACH()
        {
            var result = await _sparrow_ach.AdvancedACH("addcustomer", "First Test Bank", "110000000", "1234567890123", "checking", 9.95m, "John", "Doe");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task EWalletSimpleCredit()
        {
            var result = await _sparrow_ewallet.EWalletSimpleCredit("user@example.com", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task FiservSimpleSale()
        {
            var result = await _sparrow_creditcard.FiservSimpleSale("4005562231212149", "1019", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedFiservSale()
        {
            var result = await _sparrow_creditcard.AdvancedFiservSale("4005562231212149", "1019", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task MarkSuccessfulTransactionAsChargeback()
        {
            var result = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback("10750790", "");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCardBalance()
        {
            var result = await _sparrow_creditcard.RetrieveCardBalance("4005562231212149");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DecryptCustomFields()
        {
            var result = await _sparrow_creditcard.DecryptCustomFields("customField1", "O3BEZTT2UHCS7USA");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task VerifyAccount()
        {
            var result = await _sparrow_creditcard.VerifyAccount("4005562231212149", "1019", 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddCustomer()
        {
            var result = await _sparrow_creditcard.AddCustomer("John", "Doe");

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
            var result1 = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.UpdateCustomer(result1.CustomerToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePaymentType()
        {
            var result1 = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.DeletePaymentType(result1.CustomerToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteDataVaultCustomer()
        {
            var result1 = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.DeleteDataVaultCustomer(result1.CustomerToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreatePaymentPlan()
        {
            var result = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlan()
        {
            var result1 = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow_creditcard.UpdatePaymentPlan(result1.PlanToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task BuildSequence()
        {
            var result = await _sparrow_creditcard.BuildSequence();

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task NotificationSettings()
        {
            var result = await _sparrow_creditcard.NotificationSettings();

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddOrUpdateSequence()
        {
            var result = await _sparrow_creditcard.AddOrUpdateSequence();

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteSequence()
        {
            var result = await _sparrow_creditcard.DeleteSequence();

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePlan()
        {
            var result1 = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow_creditcard.DeletePlan(result1.PlanToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AssignPaymentPlanToCustomer()
        {
            var result1 = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result2 = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result1.CustomerToken, result2.PlanToken, "9K7US80YUQ1LPN27");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlanAssignment()
        {
            var result2 = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result3 = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result1 = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result2.CustomerToken, result3.PlanToken, "9K7US80YUQ1LPN27");
            var result = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result1.AssignmentToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelPlanAssignment()
        {
            var result2 = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result3 = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result1 = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result2.CustomerToken, result3.PlanToken, "9K7US80YUQ1LPN27");
            var result = await _sparrow_creditcard.CancelPlanAssignment(result1.AssignmentToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreateInvoice()
        {
            var result = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateInvoice()
        {
            var result1 = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result = await _sparrow_creditcard.UpdateInvoice(result1.InvoiceNumber);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveInvoice()
        {
            var result = await _sparrow_creditcard.RetrieveInvoice("Inv-39025");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoice()
        {
            var result = await _sparrow_creditcard.CancelInvoice("Inv-39025", "Testing");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoiceByCustomer()
        {
            var result = await _sparrow_creditcard.CancelInvoiceByCustomer("Inv-39025", "Testing");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithCreditCard()
        {
            var result = await _sparrow_creditcard.PayInvoiceWithCreditCard("Inv-39025", "4005562231212149", "1019");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithBankAccount()
        {
            var result = await _sparrow_creditcard.PayInvoiceWithBankAccount("Inv-39025", "First Test Bank", "110000000", "1234567890123", "checking");

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

    }
}
