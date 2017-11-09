﻿using System;
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
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.SimpleCapture(result_SimpleAuthorization.TransId, 9.95m);

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
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.SimpleRefund(result_SimpleSale.TransId, 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedRefund()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.AdvancedRefund(result_SimpleSale.TransId, 9.95m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleVoid()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.SimpleVoid(result_SimpleSale.TransId);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedVoid()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4005562231212149", "1019", 9.95m);
            var result = await _sparrow_creditcard.AdvancedVoid(result_SimpleSale.TransId);

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
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result = await _sparrow_creditcard.DeletePaymentType(result_AddCustomer.CustomerToken);

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
            var result = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");

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
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4005562231212149", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                buildSequenceSequences: new[] { new Sparrow.CreatePaymentPlanBuildSequenceSequence() { Sequence = "1", Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = "5", Duration = "12" } });
            var result = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlanAssignment()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelPlanAssignment()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
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
            var result = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result = await _sparrow_creditcard.UpdateInvoice(result_CreateInvoice.InvoiceNumber);

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
