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
                var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_SimpleSale", result_SimpleSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale(""4111111111111111"", ""1019"", 9.99m);"));

                Log(result_SimpleSale.CreateResponseDemo("result_SimpleSale"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleSale", result_SimpleSale.IsSuccess));
            }

            if (!!true)
            {
                var result_AdvancedSale = await _sparrow_creditcard.AdvancedSale("4111111111111111", "1019", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_AdvancedSale", result_AdvancedSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AdvancedSale = await _sparrow_creditcard.AdvancedSale(""4111111111111111"", ""1019"", 9.99m);"));

                Log(result_AdvancedSale.CreateResponseDemo("result_AdvancedSale"));

                Log(SparrowResponseSamples.ExitSample("result_AdvancedSale", result_AdvancedSale.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_SimpleAuthorization", result_SimpleAuthorization.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(""4111111111111111"", ""1019"", 9.99m);"));

                Log(result_SimpleAuthorization.CreateResponseDemo("result_SimpleAuthorization"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleAuthorization", result_SimpleAuthorization.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
                var result_SimpleCapture = await _sparrow_creditcard.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_SimpleCapture", result_SimpleCapture.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization(""4111111111111111"", ""1019"", 9.99m);
            var result_SimpleCapture = await _sparrow_creditcard.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);"));

                Log(result_SimpleAuthorization.CreateResponseDemo("result_SimpleAuthorization"));
                Log(result_SimpleCapture.CreateResponseDemo("result_SimpleCapture"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleCapture", result_SimpleCapture.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");

                Log(SparrowResponseSamples.EnterSample("result_SimpleOfflineCapture", result_SimpleOfflineCapture.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture(""4111111111111111"", ""1019"", 9.99m, ""123456"", ""01/31/2017"");"));

                Log(result_SimpleOfflineCapture.CreateResponseDemo("result_SimpleOfflineCapture"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleOfflineCapture", result_SimpleOfflineCapture.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
                var result_SimpleRefund = await _sparrow_creditcard.SimpleRefund(result_SimpleSale.TransId, 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_SimpleRefund", result_SimpleRefund.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale(""4111111111111111"", ""1019"", 9.99m);
            var result_SimpleRefund = await _sparrow_creditcard.SimpleRefund(result_SimpleSale.TransId, 9.99m);"));

                Log(result_SimpleSale.CreateResponseDemo("result_SimpleSale"));
                Log(result_SimpleRefund.CreateResponseDemo("result_SimpleRefund"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleRefund", result_SimpleRefund.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
                var result_AdvancedRefund = await _sparrow_creditcard.AdvancedRefund(result_SimpleSale.TransId, 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_AdvancedRefund", result_AdvancedRefund.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale(""4111111111111111"", ""1019"", 9.99m);
            var result_AdvancedRefund = await _sparrow_creditcard.AdvancedRefund(result_SimpleSale.TransId, 9.99m);"));

                Log(result_SimpleSale.CreateResponseDemo("result_SimpleSale"));
                Log(result_AdvancedRefund.CreateResponseDemo("result_AdvancedRefund"));

                Log(SparrowResponseSamples.ExitSample("result_AdvancedRefund", result_AdvancedRefund.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
                var result_SimpleVoid = await _sparrow_creditcard.SimpleVoid(result_SimpleSale.TransId);

                Log(SparrowResponseSamples.EnterSample("result_SimpleVoid", result_SimpleVoid.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale(""4111111111111111"", ""1019"", 9.99m);
            var result_SimpleVoid = await _sparrow_creditcard.SimpleVoid(result_SimpleSale.TransId);"));

                Log(result_SimpleSale.CreateResponseDemo("result_SimpleSale"));
                Log(result_SimpleVoid.CreateResponseDemo("result_SimpleVoid"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleVoid", result_SimpleVoid.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
                var result_AdvancedVoid = await _sparrow_creditcard.AdvancedVoid(result_SimpleSale.TransId);

                Log(SparrowResponseSamples.EnterSample("result_AdvancedVoid", result_AdvancedVoid.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale(""4111111111111111"", ""1019"", 9.99m);
            var result_AdvancedVoid = await _sparrow_creditcard.AdvancedVoid(result_SimpleSale.TransId);"));

                Log(result_SimpleSale.CreateResponseDemo("result_SimpleSale"));
                Log(result_AdvancedVoid.CreateResponseDemo("result_AdvancedVoid"));

                Log(SparrowResponseSamples.ExitSample("result_AdvancedVoid", result_AdvancedVoid.IsSuccess));
            }

            if (!!true)
            {
                var result_PassengerSale = await _sparrow_creditcard.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");

                Log(SparrowResponseSamples.EnterSample("result_PassengerSale", result_PassengerSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_PassengerSale = await _sparrow_creditcard.PassengerSale(""4111111111111111"", ""1019"", 9.99m, ""John Doe"", ""LAS"", ""AA0"", ""1234567890"", """", """", ""123456"", ""A"", ""1234"", ""AB"");"));

                Log(result_PassengerSale.CreateResponseDemo("result_PassengerSale"));

                Log(SparrowResponseSamples.ExitSample("result_PassengerSale", result_PassengerSale.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleStarCard = await _sparrow_starcard.SimpleStarCard("4111111111111111", 9.99m, "12345678901");

                Log(SparrowResponseSamples.EnterSample("result_SimpleStarCard", result_SimpleStarCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleStarCard = await _sparrow_starcard.SimpleStarCard(""4111111111111111"", 9.99m, ""12345678901"");"));

                Log(result_SimpleStarCard.CreateResponseDemo("result_SimpleStarCard"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleStarCard", result_SimpleStarCard.IsSuccess));
            }

            if (!!true)
            {
                var result_AdvancedStarCard = await _sparrow_starcard.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");

                Log(SparrowResponseSamples.EnterSample("result_AdvancedStarCard", result_AdvancedStarCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AdvancedStarCard = await _sparrow_starcard.AdvancedStarCard(""4111111111111111"", ""1019"", 9.99m, ""12345678901"");"));

                Log(result_AdvancedStarCard.CreateResponseDemo("result_AdvancedStarCard"));

                Log(SparrowResponseSamples.ExitSample("result_AdvancedStarCard", result_AdvancedStarCard.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleACH = await _sparrow_ach.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

                Log(SparrowResponseSamples.EnterSample("result_SimpleACH", result_SimpleACH.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleACH = await _sparrow_ach.SimpleACH(""sale"", ""First Test Bank"", ""110000000"", ""1234567890123"", ""checking"", ""personal"", 9.99m, ""John"", ""Doe"");"));

                Log(result_SimpleACH.CreateResponseDemo("result_SimpleACH"));

                Log(SparrowResponseSamples.ExitSample("result_SimpleACH", result_SimpleACH.IsSuccess));
            }

            if (!!true)
            {
                var result_AdvancedACH = await _sparrow_ach.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

                Log(SparrowResponseSamples.EnterSample("result_AdvancedACH", result_AdvancedACH.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AdvancedACH = await _sparrow_ach.AdvancedACH(""sale"", ""First Test Bank"", ""110000000"", ""1234567890123"", ""checking"", ""personal"", 9.99m, ""John"", ""Doe"");"));

                Log(result_AdvancedACH.CreateResponseDemo("result_AdvancedACH"));

                Log(SparrowResponseSamples.ExitSample("result_AdvancedACH", result_AdvancedACH.IsSuccess));
            }

            if (!!true)
            {
                var result_EWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit("user@example.com", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_EWalletSimpleCredit", result_EWalletSimpleCredit.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_EWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit(""user@example.com"", 9.99m);"));

                Log(result_EWalletSimpleCredit.CreateResponseDemo("result_EWalletSimpleCredit"));

                Log(SparrowResponseSamples.ExitSample("result_EWalletSimpleCredit", result_EWalletSimpleCredit.IsSuccess));
            }

            if (!!true)
            {
                var result_FiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale("4111111111111111", "1019", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_FiservSimpleSale", result_FiservSimpleSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_FiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale(""4111111111111111"", ""1019"", 9.99m);"));

                Log(result_FiservSimpleSale.CreateResponseDemo("result_FiservSimpleSale"));

                Log(SparrowResponseSamples.ExitSample("result_FiservSimpleSale", result_FiservSimpleSale.IsSuccess));
            }

            if (!!true)
            {
                var result_AdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale("4111111111111111", "1019", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_AdvancedFiservSale", result_AdvancedFiservSale.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale(""4111111111111111"", ""1019"", 9.99m);"));

                Log(result_AdvancedFiservSale.CreateResponseDemo("result_AdvancedFiservSale"));

                Log(SparrowResponseSamples.ExitSample("result_AdvancedFiservSale", result_AdvancedFiservSale.IsSuccess));
            }

            if (!!true)
            {
                var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
                var result_MarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, "Testing for Success");

                Log(SparrowResponseSamples.EnterSample("result_MarkSuccessfulTransactionAsChargeback", result_MarkSuccessfulTransactionAsChargeback.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_SimpleSale = await _sparrow_creditcard.SimpleSale(""4111111111111111"", ""1019"", 9.99m);
            var result_MarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, ""Testing for Success"");"));

                Log(result_SimpleSale.CreateResponseDemo("result_SimpleSale"));
                Log(result_MarkSuccessfulTransactionAsChargeback.CreateResponseDemo("result_MarkSuccessfulTransactionAsChargeback"));

                Log(SparrowResponseSamples.ExitSample("result_MarkSuccessfulTransactionAsChargeback", result_MarkSuccessfulTransactionAsChargeback.IsSuccess));
            }

            if (!!true)
            {
                var result_RetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance("4111111111111111");

                Log(SparrowResponseSamples.EnterSample("result_RetrieveCardBalance", result_RetrieveCardBalance.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_RetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance(""4111111111111111"");"));

                Log(result_RetrieveCardBalance.CreateResponseDemo("result_RetrieveCardBalance"));

                Log(SparrowResponseSamples.ExitSample("result_RetrieveCardBalance", result_RetrieveCardBalance.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
                var result_DecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields("customField1", result_AddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("result_DecryptCustomFields", result_DecryptCustomFields.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"");
            var result_DecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields(""customField1"", result_AddCustomer.CustomerToken);"));

                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_DecryptCustomFields.CreateResponseDemo("result_DecryptCustomFields"));

                Log(SparrowResponseSamples.ExitSample("result_DecryptCustomFields", result_DecryptCustomFields.IsSuccess));
            }

            if (!!true)
            {
                var result_VerifyAccount = await _sparrow_creditcard.VerifyAccount("4111111111111111", "1019", 9.99m);

                Log(SparrowResponseSamples.EnterSample("result_VerifyAccount", result_VerifyAccount.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_VerifyAccount = await _sparrow_creditcard.VerifyAccount(""4111111111111111"", ""1019"", 9.99m);"));

                Log(result_VerifyAccount.CreateResponseDemo("result_VerifyAccount"));

                Log(SparrowResponseSamples.ExitSample("result_VerifyAccount", result_VerifyAccount.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                    payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });

                Log(SparrowResponseSamples.EnterSample("result_AddCustomer", result_AddCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = ""creditcard"", CardNum = ""4111111111111111"", CardExp = ""1019"" } });"));

                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));

                Log(SparrowResponseSamples.ExitSample("result_AddCustomer", result_AddCustomer.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCreditCard = await _sparrow_creditcard.AddCreditCard("John", "Doe");

                Log(SparrowResponseSamples.EnterSample("result_AddCreditCard", result_AddCreditCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCreditCard = await _sparrow_creditcard.AddCreditCard(""John"", ""Doe"");"));

                Log(result_AddCreditCard.CreateResponseDemo("result_AddCreditCard"));

                Log(SparrowResponseSamples.ExitSample("result_AddCreditCard", result_AddCreditCard.IsSuccess));
            }

            if (!!true)
            {
                var result_AddACH = await _sparrow_ach.AddACH("John", "Doe", "First Test Bank", "110000000", "1234567890123");

                Log(SparrowResponseSamples.EnterSample("result_AddACH", result_AddACH.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddACH = await _sparrow_ach.AddACH(""John"", ""Doe"", ""First Test Bank"", ""110000000"", ""1234567890123"");"));

                Log(result_AddACH.CreateResponseDemo("result_AddACH"));

                Log(SparrowResponseSamples.ExitSample("result_AddACH", result_AddACH.IsSuccess));
            }

            if (!!true)
            {
                var result_AddStarCard = await _sparrow_starcard.AddStarCard("John", "Doe", "12345678901");

                Log(SparrowResponseSamples.EnterSample("result_AddStarCard", result_AddStarCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddStarCard = await _sparrow_starcard.AddStarCard(""John"", ""Doe"", ""12345678901"");"));

                Log(result_AddStarCard.CreateResponseDemo("result_AddStarCard"));

                Log(SparrowResponseSamples.ExitSample("result_AddStarCard", result_AddStarCard.IsSuccess));
            }

            if (!!true)
            {
                var result_AddEwallet = await _sparrow_ewallet.AddEwallet("John", "Doe");

                Log(SparrowResponseSamples.EnterSample("result_AddEwallet", result_AddEwallet.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddEwallet = await _sparrow_ewallet.AddEwallet(""John"", ""Doe"");"));

                Log(result_AddEwallet.CreateResponseDemo("result_AddEwallet"));

                Log(SparrowResponseSamples.ExitSample("result_AddEwallet", result_AddEwallet.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
                var result_UpdateCustomer = await _sparrow_creditcard.UpdateCustomer(result_AddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("result_UpdateCustomer", result_UpdateCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"");
            var result_UpdateCustomer = await _sparrow_creditcard.UpdateCustomer(result_AddCustomer.CustomerToken);"));

                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_UpdateCustomer.CreateResponseDemo("result_UpdateCustomer"));

                Log(SparrowResponseSamples.ExitSample("result_UpdateCustomer", result_UpdateCustomer.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                    payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
                var result_DeletePaymentType = await _sparrow_creditcard.DeletePaymentType(result_AddCustomer.CustomerToken,
                    payments: new[] { new Sparrow.DeletePaymentTypePayment { Token = result_AddCustomer.PaymentTokens[0] } });

                Log(SparrowResponseSamples.EnterSample("result_DeletePaymentType", result_DeletePaymentType.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = ""creditcard"", CardNum = ""4111111111111111"", CardExp = ""1019"" } });
            var result_DeletePaymentType = await _sparrow_creditcard.DeletePaymentType(result_AddCustomer.CustomerToken, 
                payments: new []{ new Sparrow.DeletePaymentTypePayment{ Token = result_AddCustomer.PaymentTokens[0] } });"));

                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_DeletePaymentType.CreateResponseDemo("result_DeletePaymentType"));

                Log(SparrowResponseSamples.ExitSample("result_DeletePaymentType", result_DeletePaymentType.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
                var result_DeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);

                Log(SparrowResponseSamples.EnterSample("result_DeleteDataVaultCustomer", result_DeleteDataVaultCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"");
            var result_DeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);"));

                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_DeleteDataVaultCustomer.CreateResponseDemo("result_DeleteDataVaultCustomer"));

                Log(SparrowResponseSamples.ExitSample("result_DeleteDataVaultCustomer", result_DeleteDataVaultCustomer.IsSuccess));
            }

            if (!!true)
            {
                var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                    sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

                Log(SparrowResponseSamples.EnterSample("result_CreatePaymentPlan", result_CreatePaymentPlan.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(""PaymentPlan1"", ""1st Payment Plan"", ""01/31/2017"", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = ""monthly"", ScheduleDay = 5, Duration = 12 } });"));

                Log(result_CreatePaymentPlan.CreateResponseDemo("result_CreatePaymentPlan"));

                Log(SparrowResponseSamples.ExitSample("result_CreatePaymentPlan", result_CreatePaymentPlan.IsSuccess));
            }

            if (!!true)
            {
                var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
                var result_UpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken);

                Log(SparrowResponseSamples.EnterSample("result_UpdatePaymentPlan", result_UpdatePaymentPlan.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(""PaymentPlan1"", ""1st Payment Plan"", ""01/31/2017"");
            var result_UpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken);"));

                Log(result_CreatePaymentPlan.CreateResponseDemo("result_CreatePaymentPlan"));
                Log(result_UpdatePaymentPlan.CreateResponseDemo("result_UpdatePaymentPlan"));

                Log(SparrowResponseSamples.ExitSample("result_UpdatePaymentPlan", result_UpdatePaymentPlan.IsSuccess));
            }

            if (!!true)
            {
                var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
                var result_DeletePlan = await _sparrow_creditcard.DeletePlan(result_CreatePaymentPlan.PlanToken);

                Log(SparrowResponseSamples.EnterSample("result_DeletePlan", result_DeletePlan.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(""PaymentPlan1"", ""1st Payment Plan"", ""01/31/2017"");
            var result_DeletePlan = await _sparrow_creditcard.DeletePlan(result_CreatePaymentPlan.PlanToken);"));

                Log(result_CreatePaymentPlan.CreateResponseDemo("result_CreatePaymentPlan"));
                Log(result_DeletePlan.CreateResponseDemo("result_DeletePlan"));

                Log(SparrowResponseSamples.ExitSample("result_DeletePlan", result_DeletePlan.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                    payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
                var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                    sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
                var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);

                Log(SparrowResponseSamples.EnterSample("result_AssignPaymentPlanToCustomer", result_AssignPaymentPlanToCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = ""creditcard"", CardNum = ""4111111111111111"", CardExp = ""1019"" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(""PaymentPlan1"", ""1st Payment Plan"", ""01/31/2017"", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = ""monthly"", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);"));

                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_CreatePaymentPlan.CreateResponseDemo("result_CreatePaymentPlan"));
                Log(result_AssignPaymentPlanToCustomer.CreateResponseDemo("result_AssignPaymentPlanToCustomer"));

                Log(SparrowResponseSamples.ExitSample("result_AssignPaymentPlanToCustomer", result_AssignPaymentPlanToCustomer.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                    payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
                var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018",
                    sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
                var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
                var result_UpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken,
                    options: new Sparrow.UpdatePaymentPlanAssignmentOptions { StartDate = "02/02/2020" });

                Log(SparrowResponseSamples.EnterSample("result_UpdatePaymentPlanAssignment", result_UpdatePaymentPlanAssignment.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = ""creditcard"", CardNum = ""4111111111111111"", CardExp = ""1019"" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(""PaymentPlan1"", ""1st Payment Plan"", ""01/01/2018"", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = ""monthly"", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_UpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken, 
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions{ StartDate = ""02/02/2020"" });"));

                Log(result_AssignPaymentPlanToCustomer.CreateResponseDemo("result_AssignPaymentPlanToCustomer"));
                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_CreatePaymentPlan.CreateResponseDemo("result_CreatePaymentPlan"));
                Log(result_UpdatePaymentPlanAssignment.CreateResponseDemo("result_UpdatePaymentPlanAssignment"));

                Log(SparrowResponseSamples.ExitSample("result_UpdatePaymentPlanAssignment", result_UpdatePaymentPlanAssignment.IsSuccess));
            }

            if (!!true)
            {
                var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                    payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
                var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                    sequences: new[] { new Sparrow.BuildSequenceSequence { Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
                var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
                var result_CancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);

                Log(SparrowResponseSamples.EnterSample("result_CancelPlanAssignment", result_CancelPlanAssignment.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer(""John"", ""Doe"", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = ""creditcard"", CardNum = ""4111111111111111"", CardExp = ""1019"" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan(""PaymentPlan1"", ""1st Payment Plan"", ""01/31/2017"", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = ""monthly"", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_CancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);"));

                Log(result_AssignPaymentPlanToCustomer.CreateResponseDemo("result_AssignPaymentPlanToCustomer"));
                Log(result_AddCustomer.CreateResponseDemo("result_AddCustomer"));
                Log(result_CreatePaymentPlan.CreateResponseDemo("result_CreatePaymentPlan"));
                Log(result_CancelPlanAssignment.CreateResponseDemo("result_CancelPlanAssignment"));

                Log(SparrowResponseSamples.ExitSample("result_CancelPlanAssignment", result_CancelPlanAssignment.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);

                Log(SparrowResponseSamples.EnterSample("result_CreateInvoice", result_CreateInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice(""12/01/2017"", ""USD"", ""active"", 10.00m);"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));

                Log(SparrowResponseSamples.ExitSample("result_CreateInvoice", result_CreateInvoice.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
                var result_UpdateInvoice = await _sparrow_creditcard.UpdateInvoice(result_CreateInvoice.InvoiceNumber,
                    options: new Sparrow.UpdateInvoiceOptions { InvoiceStatus = "active" });

                Log(SparrowResponseSamples.EnterSample("result_UpdateInvoice", result_UpdateInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice(""12/01/2017"", ""USD"", ""draft"", 10.00m);
            var result_UpdateInvoice = await _sparrow_creditcard.UpdateInvoice(result_CreateInvoice.InvoiceNumber, 
                options: new Sparrow.UpdateInvoiceOptions{ InvoiceStatus = ""active"" });"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));
                Log(result_UpdateInvoice.CreateResponseDemo("result_UpdateInvoice"));

                Log(SparrowResponseSamples.ExitSample("result_UpdateInvoice", result_UpdateInvoice.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
                var result_RetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);

                Log(SparrowResponseSamples.EnterSample("result_RetrieveInvoice", result_RetrieveInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice(""12/01/2017"", ""USD"", ""active"", 10.00m);
            var result_RetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));
                Log(result_RetrieveInvoice.CreateResponseDemo("result_RetrieveInvoice"));

                Log(SparrowResponseSamples.ExitSample("result_RetrieveInvoice", result_RetrieveInvoice.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
                var result_CancelInvoice = await _sparrow_creditcard.CancelInvoice(result_CreateInvoice.InvoiceNumber, "Testing");

                Log(SparrowResponseSamples.EnterSample("result_CancelInvoice", result_CancelInvoice.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice(""12/01/2017"", ""USD"", ""active"", 10.00m);
            var result_CancelInvoice = await _sparrow_creditcard.CancelInvoice(result_CreateInvoice.InvoiceNumber, ""Testing"");"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));
                Log(result_CancelInvoice.CreateResponseDemo("result_CancelInvoice"));

                Log(SparrowResponseSamples.ExitSample("result_CancelInvoice", result_CancelInvoice.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
                var result_CancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, "Testing");

                Log(SparrowResponseSamples.EnterSample("result_CancelInvoiceByCustomer", result_CancelInvoiceByCustomer.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice(""12/01/2017"", ""USD"", ""active"", 10.00m);
            var result_CancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, ""Testing"");"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));
                Log(result_CancelInvoiceByCustomer.CreateResponseDemo("result_CancelInvoiceByCustomer"));

                Log(SparrowResponseSamples.ExitSample("result_CancelInvoiceByCustomer", result_CancelInvoiceByCustomer.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
                var result_PayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, "4111111111111111", "1019");

                Log(SparrowResponseSamples.EnterSample("result_PayInvoiceWithCreditCard", result_PayInvoiceWithCreditCard.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice(""12/01/2017"", ""USD"", ""active"", 10.00m);
            var result_PayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, ""4111111111111111"", ""1019"");"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));
                Log(result_PayInvoiceWithCreditCard.CreateResponseDemo("result_PayInvoiceWithCreditCard"));

                Log(SparrowResponseSamples.ExitSample("result_PayInvoiceWithCreditCard", result_PayInvoiceWithCreditCard.IsSuccess));
            }

            if (!!true)
            {
                var result_CreateInvoice = await _sparrow_ach.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
                var result_PayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal",
                    billing: new Sparrow.PayInvoiceWithBankAccountBilling { FirstName = "John", LastName = "Doe" });

                Log(SparrowResponseSamples.EnterSample("result_PayInvoiceWithBankAccount", result_PayInvoiceWithBankAccount.IsSuccess));

                Log(SparrowResponseSamples.CreateCodeSample(@"
            var result_CreateInvoice = await _sparrow_ach.CreateInvoice(""12/01/2017"", ""USD"", ""active"", 10.00m);
            var result_PayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, ""First Test Bank"", ""110000000"", ""1234567890123"", ""checking"", ""personal"", 
                billing: new Sparrow.PayInvoiceWithBankAccountBilling{ FirstName = ""John"", LastName = ""Doe"" });"));

                Log(result_CreateInvoice.CreateResponseDemo("result_CreateInvoice"));
                Log(result_PayInvoiceWithBankAccount.CreateResponseDemo("result_PayInvoiceWithBankAccount"));

                Log(SparrowResponseSamples.ExitSample("result_PayInvoiceWithBankAccount", result_PayInvoiceWithBankAccount.IsSuccess));
            }

        }
    }
}
