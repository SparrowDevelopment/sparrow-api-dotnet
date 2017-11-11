﻿using System;
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
            var result_AdvancedECheck = await _sparrow_ach.AdvancedECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m,
                billing: new Sparrow.AdvancedECheckBilling { FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });

            TestContext.WriteLine(result_AdvancedECheck.CreateRawLog("result_AdvancedECheck"));

            Assert.IsTrue(result_AdvancedECheck.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedECheck.Response);
            // Assert.IsTrue(result_AdvancedECheck.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedECheck.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedACH()
        {
            var result_AdvancedACH = await _sparrow_ach.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            TestContext.WriteLine(result_AdvancedACH.CreateRawLog("result_AdvancedACH"));

            Assert.IsTrue(result_AdvancedACH.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedACH.Response);
            // Assert.IsTrue(result_AdvancedACH.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedACH.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleACH()
        {
            var result_SimpleACH = await _sparrow_ach.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            TestContext.WriteLine(result_SimpleACH.CreateRawLog("result_SimpleACH"));

            Assert.IsTrue(result_SimpleACH.IsSuccess);
            // Assert.AreEqual(1, result_SimpleACH.Response);
            // Assert.IsTrue(result_SimpleACH.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleACH.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleECheck()
        {
            var result_SimpleECheck = await _sparrow_ach.SimpleECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m,
                billing: new Sparrow.SimpleECheckBilling { Company = "Sparrow One", FirstName = "John", LastName = "Doe", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });

            TestContext.WriteLine(result_SimpleECheck.CreateRawLog("result_SimpleECheck"));

            Assert.IsTrue(result_SimpleECheck.IsSuccess);
            // Assert.AreEqual(1, result_SimpleECheck.Response);
            // Assert.IsTrue(result_SimpleECheck.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleECheck.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PassengerSale()
        {
            var result_PassengerSale = await _sparrow_creditcard.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");

            TestContext.WriteLine(result_PassengerSale.CreateRawLog("result_PassengerSale"));

            Assert.IsTrue(result_PassengerSale.IsSuccess);
            // Assert.AreEqual(1, result_PassengerSale.Response);
            // Assert.IsTrue(result_PassengerSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_PassengerSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCardBalance()
        {
            var result_RetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance("4111111111111111");

            TestContext.WriteLine(result_RetrieveCardBalance.CreateRawLog("result_RetrieveCardBalance"));

            Assert.IsTrue(result_RetrieveCardBalance.IsSuccess);
            // Assert.AreEqual(1, result_RetrieveCardBalance.Response);
            // Assert.IsTrue(result_RetrieveCardBalance.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_RetrieveCardBalance.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task VerifyAccount()
        {
            var result_VerifyAccount = await _sparrow_creditcard.VerifyAccount("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_VerifyAccount.CreateRawLog("result_VerifyAccount"));

            Assert.IsTrue(result_VerifyAccount.IsSuccess);
            // Assert.AreEqual(1, result_VerifyAccount.Response);
            // Assert.IsTrue(result_VerifyAccount.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_VerifyAccount.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task MarkSuccessfulTransactionAsChargeback()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_MarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, "Testing for Success");

            TestContext.WriteLine(result_SimpleSale.CreateRawLog("result_SimpleSale"));
            TestContext.WriteLine(result_MarkSuccessfulTransactionAsChargeback.CreateRawLog("result_MarkSuccessfulTransactionAsChargeback"));

            Assert.IsTrue(result_MarkSuccessfulTransactionAsChargeback.IsSuccess);
            // Assert.AreEqual(1, result_MarkSuccessfulTransactionAsChargeback.Response);
            // Assert.IsTrue(result_MarkSuccessfulTransactionAsChargeback.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_MarkSuccessfulTransactionAsChargeback.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCredit()
        {
            var result_SimpleCredit = await _sparrow_creditcard.SimpleCredit("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_SimpleCredit.CreateRawLog("result_SimpleCredit"));

            Assert.IsTrue(result_SimpleCredit.IsSuccess);
            // Assert.AreEqual(1, result_SimpleCredit.Response);
            // Assert.IsTrue(result_SimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedSale()
        {
            var result_AdvancedSale = await _sparrow_creditcard.AdvancedSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_AdvancedSale.CreateRawLog("result_AdvancedSale"));

            Assert.IsTrue(result_AdvancedSale.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedSale.Response);
            // Assert.IsTrue(result_AdvancedSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleSale()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_SimpleSale.CreateRawLog("result_SimpleSale"));

            Assert.IsTrue(result_SimpleSale.IsSuccess);
            // Assert.AreEqual(1, result_SimpleSale.Response);
            // Assert.IsTrue(result_SimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddPaymentTypesToCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_AddPaymentTypesToCustomer = await _sparrow_creditcard.AddPaymentTypesToCustomer(result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_AddPaymentTypesToCustomer.CreateRawLog("result_AddPaymentTypesToCustomer"));

            Assert.IsTrue(result_AddPaymentTypesToCustomer.IsSuccess);
            // Assert.AreEqual(1, result_AddPaymentTypesToCustomer.Response);
            // Assert.IsTrue(result_AddPaymentTypesToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AddPaymentTypesToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AddCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));

            Assert.IsTrue(result_AddCustomer.IsSuccess);
            // Assert.AreEqual(1, result_AddCustomer.Response);
            // Assert.IsTrue(result_AddCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AddCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeleteDataVaultCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_DeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_DeleteDataVaultCustomer.CreateRawLog("result_DeleteDataVaultCustomer"));

            Assert.IsTrue(result_DeleteDataVaultCustomer.IsSuccess);
            // Assert.AreEqual(1, result_DeleteDataVaultCustomer.Response);
            // Assert.IsTrue(result_DeleteDataVaultCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_DeleteDataVaultCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePaymentType()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_DeletePaymentType = await _sparrow_creditcard.DeletePaymentType(result_AddCustomer.CustomerToken,
                payments: new[] { new Sparrow.DeletePaymentTypePayment { Token = result_AddCustomer.PaymentTokens[0] } });

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_DeletePaymentType.CreateRawLog("result_DeletePaymentType"));

            Assert.IsTrue(result_DeletePaymentType.IsSuccess);
            // Assert.AreEqual(1, result_DeletePaymentType.Response);
            // Assert.IsTrue(result_DeletePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_DeletePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_RetrieveCustomer = await _sparrow_creditcard.RetrieveCustomer(result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_RetrieveCustomer.CreateRawLog("result_RetrieveCustomer"));

            Assert.IsTrue(result_RetrieveCustomer.IsSuccess);
            // Assert.AreEqual(1, result_RetrieveCustomer.Response);
            // Assert.IsTrue(result_RetrieveCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_RetrieveCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrievePaymentType()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_RetrievePaymentType = await _sparrow_creditcard.RetrievePaymentType(result_AddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_RetrievePaymentType.CreateRawLog("result_RetrievePaymentType"));

            Assert.IsTrue(result_RetrievePaymentType.IsSuccess);
            // Assert.AreEqual(1, result_RetrievePaymentType.Response);
            // Assert.IsTrue(result_RetrievePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_RetrievePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_UpdateCustomer = await _sparrow_creditcard.UpdateCustomer(result_AddCustomer.CustomerToken,
                billing: new Sparrow.UpdateCustomerBilling { Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254" });

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_UpdateCustomer.CreateRawLog("result_UpdateCustomer"));

            Assert.IsTrue(result_UpdateCustomer.IsSuccess);
            // Assert.AreEqual(1, result_UpdateCustomer.Response);
            // Assert.IsTrue(result_UpdateCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_UpdateCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentType()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_UpdatePaymentType = await _sparrow_creditcard.UpdatePaymentType(result_AddCustomer.CustomerToken,
                payments: new[] { new Sparrow.UpdatePaymentTypePayment { Token = result_AddCustomer.PaymentTokens[0] } });

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_UpdatePaymentType.CreateRawLog("result_UpdatePaymentType"));

            Assert.IsTrue(result_UpdatePaymentType.IsSuccess);
            // Assert.AreEqual(1, result_UpdatePaymentType.Response);
            // Assert.IsTrue(result_UpdatePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_UpdatePaymentType.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DecryptCustomFields()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_DecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields("customField1", result_AddCustomer.CustomerToken);

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_DecryptCustomFields.CreateRawLog("result_DecryptCustomFields"));

            Assert.IsTrue(result_DecryptCustomFields.IsSuccess);
            // Assert.AreEqual(1, result_DecryptCustomFields.Response);
            // Assert.IsTrue(result_DecryptCustomFields.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_DecryptCustomFields.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task EWalletSimpleCredit()
        {
            var result_EWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit("user@example.com", 9.99m);

            TestContext.WriteLine(result_EWalletSimpleCredit.CreateRawLog("result_EWalletSimpleCredit"));

            Assert.IsTrue(result_EWalletSimpleCredit.IsSuccess);
            // Assert.AreEqual(1, result_EWalletSimpleCredit.Response);
            // Assert.IsTrue(result_EWalletSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_EWalletSimpleCredit.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedFiservSale()
        {
            var result_AdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_AdvancedFiservSale.CreateRawLog("result_AdvancedFiservSale"));

            Assert.IsTrue(result_AdvancedFiservSale.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedFiservSale.Response);
            // Assert.IsTrue(result_AdvancedFiservSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedFiservSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task FiservSimpleSale()
        {
            var result_FiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_FiservSimpleSale.CreateRawLog("result_FiservSimpleSale"));

            Assert.IsTrue(result_FiservSimpleSale.IsSuccess);
            // Assert.AreEqual(1, result_FiservSimpleSale.Response);
            // Assert.IsTrue(result_FiservSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_FiservSimpleSale.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoiceByCustomer()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_CancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, "Testing");

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));
            TestContext.WriteLine(result_CancelInvoiceByCustomer.CreateRawLog("result_CancelInvoiceByCustomer"));

            Assert.IsTrue(result_CancelInvoiceByCustomer.IsSuccess);
            // Assert.AreEqual(1, result_CancelInvoiceByCustomer.Response);
            // Assert.IsTrue(result_CancelInvoiceByCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_CancelInvoiceByCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_CancelInvoice = await _sparrow_creditcard.CancelInvoice(result_CreateInvoice.InvoiceNumber, "Testing");

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));
            TestContext.WriteLine(result_CancelInvoice.CreateRawLog("result_CancelInvoice"));

            Assert.IsTrue(result_CancelInvoice.IsSuccess);
            // Assert.AreEqual(1, result_CancelInvoice.Response);
            // Assert.IsTrue(result_CancelInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_CancelInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreateInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));

            Assert.IsTrue(result_CreateInvoice.IsSuccess);
            // Assert.AreEqual(1, result_CreateInvoice.Response);
            // Assert.IsTrue(result_CreateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_CreateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task RetrieveInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_RetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));
            TestContext.WriteLine(result_RetrieveInvoice.CreateRawLog("result_RetrieveInvoice"));

            Assert.IsTrue(result_RetrieveInvoice.IsSuccess);
            // Assert.AreEqual(1, result_RetrieveInvoice.Response);
            // Assert.IsTrue(result_RetrieveInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_RetrieveInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithBankAccount()
        {
            var result_CreateInvoice = await _sparrow_ach.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_PayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal",
                billing: new Sparrow.PayInvoiceWithBankAccountBilling { FirstName = "John", LastName = "Doe" });

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));
            TestContext.WriteLine(result_PayInvoiceWithBankAccount.CreateRawLog("result_PayInvoiceWithBankAccount"));

            Assert.IsTrue(result_PayInvoiceWithBankAccount.IsSuccess);
            // Assert.AreEqual(1, result_PayInvoiceWithBankAccount.Response);
            // Assert.IsTrue(result_PayInvoiceWithBankAccount.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_PayInvoiceWithBankAccount.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task PayInvoiceWithCreditCard()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_PayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, "4111111111111111", "1019");

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));
            TestContext.WriteLine(result_PayInvoiceWithCreditCard.CreateRawLog("result_PayInvoiceWithCreditCard"));

            Assert.IsTrue(result_PayInvoiceWithCreditCard.IsSuccess);
            // Assert.AreEqual(1, result_PayInvoiceWithCreditCard.Response);
            // Assert.IsTrue(result_PayInvoiceWithCreditCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_PayInvoiceWithCreditCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdateInvoice()
        {
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result_UpdateInvoice = await _sparrow_creditcard.UpdateInvoice(result_CreateInvoice.InvoiceNumber,
                options: new Sparrow.UpdateInvoiceOptions { InvoiceStatus = "active" });

            TestContext.WriteLine(result_CreateInvoice.CreateRawLog("result_CreateInvoice"));
            TestContext.WriteLine(result_UpdateInvoice.CreateRawLog("result_UpdateInvoice"));

            Assert.IsTrue(result_UpdateInvoice.IsSuccess);
            // Assert.AreEqual(1, result_UpdateInvoice.Response);
            // Assert.IsTrue(result_UpdateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_UpdateInvoice.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleRefund()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_SimpleRefund = await _sparrow_creditcard.SimpleRefund(result_SimpleSale.TransId, 9.99m);

            TestContext.WriteLine(result_SimpleSale.CreateRawLog("result_SimpleSale"));
            TestContext.WriteLine(result_SimpleRefund.CreateRawLog("result_SimpleRefund"));

            Assert.IsTrue(result_SimpleRefund.IsSuccess);
            // Assert.AreEqual(1, result_SimpleRefund.Response);
            // Assert.IsTrue(result_SimpleRefund.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleRefund.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedRefund()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_AdvancedRefund = await _sparrow_creditcard.AdvancedRefund(result_SimpleSale.TransId, 9.99m);

            TestContext.WriteLine(result_SimpleSale.CreateRawLog("result_SimpleSale"));
            TestContext.WriteLine(result_AdvancedRefund.CreateRawLog("result_AdvancedRefund"));

            Assert.IsTrue(result_AdvancedRefund.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedRefund.Response);
            // Assert.IsTrue(result_AdvancedRefund.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedRefund.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedVoid()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_AdvancedVoid = await _sparrow_creditcard.AdvancedVoid(result_SimpleSale.TransId);

            TestContext.WriteLine(result_SimpleSale.CreateRawLog("result_SimpleSale"));
            TestContext.WriteLine(result_AdvancedVoid.CreateRawLog("result_AdvancedVoid"));

            Assert.IsTrue(result_AdvancedVoid.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedVoid.Response);
            // Assert.IsTrue(result_AdvancedVoid.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedVoid.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleVoid()
        {
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_SimpleVoid = await _sparrow_creditcard.SimpleVoid(result_SimpleSale.TransId);

            TestContext.WriteLine(result_SimpleSale.CreateRawLog("result_SimpleSale"));
            TestContext.WriteLine(result_SimpleVoid.CreateRawLog("result_SimpleVoid"));

            Assert.IsTrue(result_SimpleVoid.IsSuccess);
            // Assert.AreEqual(1, result_SimpleVoid.Response);
            // Assert.IsTrue(result_SimpleVoid.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleVoid.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AssignPaymentPlanToCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_CreatePaymentPlan.CreateRawLog("result_CreatePaymentPlan"));
            TestContext.WriteLine(result_AssignPaymentPlanToCustomer.CreateRawLog("result_AssignPaymentPlanToCustomer"));

            Assert.IsTrue(result_AssignPaymentPlanToCustomer.IsSuccess);
            // Assert.AreEqual(1, result_AssignPaymentPlanToCustomer.Response);
            // Assert.IsTrue(result_AssignPaymentPlanToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AssignPaymentPlanToCustomer.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CancelPlanAssignment()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_CancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);

            TestContext.WriteLine(result_AssignPaymentPlanToCustomer.CreateRawLog("result_AssignPaymentPlanToCustomer"));
            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_CreatePaymentPlan.CreateRawLog("result_CreatePaymentPlan"));
            TestContext.WriteLine(result_CancelPlanAssignment.CreateRawLog("result_CancelPlanAssignment"));

            Assert.IsTrue(result_CancelPlanAssignment.IsSuccess);
            // Assert.AreEqual(1, result_CancelPlanAssignment.Response);
            // Assert.IsTrue(result_CancelPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_CancelPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task CreatePaymentPlan()
        {
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

            TestContext.WriteLine(result_CreatePaymentPlan.CreateRawLog("result_CreatePaymentPlan"));

            Assert.IsTrue(result_CreatePaymentPlan.IsSuccess);
            // Assert.AreEqual(1, result_CreatePaymentPlan.Response);
            // Assert.IsTrue(result_CreatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_CreatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task DeletePlan()
        {
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result_DeletePlan = await _sparrow_creditcard.DeletePlan(result_CreatePaymentPlan.PlanToken);

            TestContext.WriteLine(result_CreatePaymentPlan.CreateRawLog("result_CreatePaymentPlan"));
            TestContext.WriteLine(result_DeletePlan.CreateRawLog("result_DeletePlan"));

            Assert.IsTrue(result_DeletePlan.IsSuccess);
            // Assert.AreEqual(1, result_DeletePlan.Response);
            // Assert.IsTrue(result_DeletePlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_DeletePlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlanAssignment()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_UpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken,
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions { StartDate = "02/02/2020" });

            TestContext.WriteLine(result_AssignPaymentPlanToCustomer.CreateRawLog("result_AssignPaymentPlanToCustomer"));
            TestContext.WriteLine(result_AddCustomer.CreateRawLog("result_AddCustomer"));
            TestContext.WriteLine(result_CreatePaymentPlan.CreateRawLog("result_CreatePaymentPlan"));
            TestContext.WriteLine(result_UpdatePaymentPlanAssignment.CreateRawLog("result_UpdatePaymentPlanAssignment"));

            Assert.IsTrue(result_UpdatePaymentPlanAssignment.IsSuccess);
            // Assert.AreEqual(1, result_UpdatePaymentPlanAssignment.Response);
            // Assert.IsTrue(result_UpdatePaymentPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_UpdatePaymentPlanAssignment.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task UpdatePaymentPlan()
        {
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 10.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_UpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken,
                sequences: new[] { new Sparrow.AddOrUpdateSequenceSequence { OperationType = "updatesequence", Sequence = 1, Amount = 20.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

            TestContext.WriteLine(result_CreatePaymentPlan.CreateRawLog("result_CreatePaymentPlan"));
            TestContext.WriteLine(result_UpdatePaymentPlan.CreateRawLog("result_UpdatePaymentPlan"));

            Assert.IsTrue(result_UpdatePaymentPlan.IsSuccess);
            // Assert.AreEqual(1, result_UpdatePaymentPlan.Response);
            // Assert.IsTrue(result_UpdatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_UpdatePaymentPlan.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleOfflineCapture()
        {
            var result_SimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");

            TestContext.WriteLine(result_SimpleOfflineCapture.CreateRawLog("result_SimpleOfflineCapture"));

            Assert.IsTrue(result_SimpleOfflineCapture.IsSuccess);
            // Assert.AreEqual(1, result_SimpleOfflineCapture.Response);
            // Assert.IsTrue(result_SimpleOfflineCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleOfflineCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedCapture()
        {
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result_AdvancedCapture = await _sparrow_creditcard.AdvancedCapture(result_SimpleAuthorization.TransId, 9.99m);

            TestContext.WriteLine(result_SimpleAuthorization.CreateRawLog("result_SimpleAuthorization"));
            TestContext.WriteLine(result_AdvancedCapture.CreateRawLog("result_AdvancedCapture"));

            Assert.IsTrue(result_AdvancedCapture.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedCapture.Response);
            // Assert.IsTrue(result_AdvancedCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleAuthorization()
        {
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);

            TestContext.WriteLine(result_SimpleAuthorization.CreateRawLog("result_SimpleAuthorization"));

            Assert.IsTrue(result_SimpleAuthorization.IsSuccess);
            // Assert.AreEqual(1, result_SimpleAuthorization.Response);
            // Assert.IsTrue(result_SimpleAuthorization.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleAuthorization.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleCapture()
        {
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result_SimpleCapture = await _sparrow_creditcard.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);

            TestContext.WriteLine(result_SimpleAuthorization.CreateRawLog("result_SimpleAuthorization"));
            TestContext.WriteLine(result_SimpleCapture.CreateRawLog("result_SimpleCapture"));

            Assert.IsTrue(result_SimpleCapture.IsSuccess);
            // Assert.AreEqual(1, result_SimpleCapture.Response);
            // Assert.IsTrue(result_SimpleCapture.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleCapture.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task AdvancedStarCard()
        {
            var result_AdvancedStarCard = await _sparrow_starcard.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");

            TestContext.WriteLine(result_AdvancedStarCard.CreateRawLog("result_AdvancedStarCard"));

            Assert.IsTrue(result_AdvancedStarCard.IsSuccess);
            // Assert.AreEqual(1, result_AdvancedStarCard.Response);
            // Assert.IsTrue(result_AdvancedStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_AdvancedStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

        [TestMethod]
        public async Task SimpleStarCard()
        {
            var result_SimpleStarCard = await _sparrow_starcard.SimpleStarCard("4111111111111111", 9.99m, "12345678901");

            TestContext.WriteLine(result_SimpleStarCard.CreateRawLog("result_SimpleStarCard"));

            Assert.IsTrue(result_SimpleStarCard.IsSuccess);
            // Assert.AreEqual(1, result_SimpleStarCard.Response);
            // Assert.IsTrue(result_SimpleStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
            // Assert.IsTrue(result_SimpleStarCard.TextResponse.ToUpper().Contains("SUCCESS"));
        }

    }
}