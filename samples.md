
### SimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10924157
result_SimpleSale.XRef;    // 3862369065
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AdvancedSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedSale = await _sparrow_creditcard.AdvancedSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedSale.Status;    // 200
result_AdvancedSale.Response;    // 1
result_AdvancedSale.TextResponse;    // SUCCESS
result_AdvancedSale.TransId;    // 10924159
result_AdvancedSale.XRef;    // 3862369166
result_AdvancedSale.AuthCode;    // 123456
result_AdvancedSale.Type;    // sale
result_AdvancedSale.CodeResponse;    // 100
result_AdvancedSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleAuthorization


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleAuthorization.Status;    // 200
result_SimpleAuthorization.Response;    // 1
result_SimpleAuthorization.TextResponse;    // SUCCESS
result_SimpleAuthorization.TransId;    // 10924160
result_SimpleAuthorization.XRef;    // 3862369245
result_SimpleAuthorization.AuthCode;    // 123456
result_SimpleAuthorization.Type;    // auth
result_SimpleAuthorization.CodeResponse;    // 100
result_SimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleAuthorization = await _sparrow_creditcard.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result_SimpleCapture = await _sparrow_creditcard.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleAuthorization.Status;    // 200
result_SimpleAuthorization.Response;    // 1
result_SimpleAuthorization.TextResponse;    // SUCCESS
result_SimpleAuthorization.TransId;    // 10924161
result_SimpleAuthorization.XRef;    // 3862369310
result_SimpleAuthorization.AuthCode;    // 123456
result_SimpleAuthorization.Type;    // auth
result_SimpleAuthorization.CodeResponse;    // 100
result_SimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleCapture:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleCapture.Status;    // 200
result_SimpleCapture.Response;    // 1
result_SimpleCapture.TextResponse;    // SUCCESS
result_SimpleCapture.TransId;    // 10924161
result_SimpleCapture.XRef;    // 3862369310
result_SimpleCapture.AuthCode;    // 123456
result_SimpleCapture.Type;    // capture
result_SimpleCapture.CodeResponse;    // 100
result_SimpleCapture.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleOfflineCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleOfflineCapture = await _sparrow_creditcard.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleOfflineCapture:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleOfflineCapture.Status;    // 200
result_SimpleOfflineCapture.Response;    // 1
result_SimpleOfflineCapture.TextResponse;    // SUCCESS
result_SimpleOfflineCapture.TransId;    // 10924162
result_SimpleOfflineCapture.XRef;    // 3862369458
result_SimpleOfflineCapture.AuthCode;    // 123456
result_SimpleOfflineCapture.Type;    // offline
result_SimpleOfflineCapture.CodeResponse;    // 100
result_SimpleOfflineCapture.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_SimpleRefund = await _sparrow_creditcard.SimpleRefund(result_SimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10924163
result_SimpleSale.XRef;    // 3862369497
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleRefund:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleRefund.Status;    // 200
result_SimpleRefund.Response;    // 1
result_SimpleRefund.TextResponse;    // SUCCESS
result_SimpleRefund.TransId;    // 10924163
result_SimpleRefund.XRef;    // 3862369497
result_SimpleRefund.AuthCode;    // 123456
result_SimpleRefund.Type;    // refund
result_SimpleRefund.CodeResponse;    // 100
result_SimpleRefund.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AdvancedRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_AdvancedRefund = await _sparrow_creditcard.AdvancedRefund(result_SimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10924164
result_SimpleSale.XRef;    // 3862369652
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedRefund:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedRefund.Status;    // 300
result_AdvancedRefund.Response;    // 3
result_AdvancedRefund.TextResponse;    // Flagged for Review by Velocity and Duplicates Policy (Duplicate Transactions Rule). Original Transaction ID: 10924163
result_AdvancedRefund.TransId;    // 10924164
result_AdvancedRefund.XRef;    // 3862369652
result_AdvancedRefund.AuthCode;    // 123456
result_AdvancedRefund.Type;    // refund
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_SimpleVoid = await _sparrow_creditcard.SimpleVoid(result_SimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10924165
result_SimpleSale.XRef;    // 3862369733
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleVoid:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleVoid.Status;    // 200
result_SimpleVoid.Response;    // 1
result_SimpleVoid.TextResponse;    // Transaction Void Successful
result_SimpleVoid.TransId;    // 10924165
result_SimpleVoid.XRef;    // 3862369733
result_SimpleVoid.AuthCode;    // 123456
result_SimpleVoid.Type;    // void
result_SimpleVoid.CodeResponse;    // 100
result_SimpleVoid.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AdvancedVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_AdvancedVoid = await _sparrow_creditcard.AdvancedVoid(result_SimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10924167
result_SimpleSale.XRef;    // 3862369846
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedVoid:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedVoid.Status;    // 200
result_AdvancedVoid.Response;    // 1
result_AdvancedVoid.TextResponse;    // Transaction Void Successful
result_AdvancedVoid.TransId;    // 10924167
result_AdvancedVoid.XRef;    // 3862369846
result_AdvancedVoid.AuthCode;    // 123456
result_AdvancedVoid.Type;    // void
result_AdvancedVoid.CodeResponse;    // 100
result_AdvancedVoid.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### PassengerSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_PassengerSale = await _sparrow_creditcard.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT PassengerSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_PassengerSale.Status;    // 500
result_PassengerSale.Response;    // 3
result_PassengerSale.TextResponse;    // Operation type is not supported by payment processor
result_PassengerSale.Type;    // passengersale
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleStarCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleStarCard = await _sparrow_starcard.SimpleStarCard("4111111111111111", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleStarCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleStarCard.Status;    // 400
result_SimpleStarCard.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result_SimpleStarCard.TransId;    // 10924168
result_SimpleStarCard.Type;    // sale
result_SimpleStarCard.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AdvancedStarCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedStarCard = await _sparrow_starcard.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedStarCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedStarCard.Status;    // 400
result_AdvancedStarCard.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result_AdvancedStarCard.TransId;    // 10924169
result_AdvancedStarCard.Type;    // sale
result_AdvancedStarCard.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### SimpleACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleACH = await _sparrow_ach.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleACH:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleACH.Status;    // 200
result_SimpleACH.TextResponse;    // SUCCESS
result_SimpleACH.TransId;    // 10924170
result_SimpleACH.XRef;    // 3862370081
result_SimpleACH.AuthCode;    // 123456
result_SimpleACH.Type;    // sale
result_SimpleACH.CodeResponse;    // 100
result_SimpleACH.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AdvancedACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedACH = await _sparrow_ach.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedACH:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedACH.Status;    // 200
result_AdvancedACH.TextResponse;    // SUCCESS
result_AdvancedACH.TransId;    // 10924172
result_AdvancedACH.XRef;    // 3862370117
result_AdvancedACH.AuthCode;    // 123456
result_AdvancedACH.Type;    // sale
result_AdvancedACH.CodeResponse;    // 100
result_AdvancedACH.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### EWalletSimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_EWalletSimpleCredit = await _sparrow_ewallet.EWalletSimpleCredit("user@example.com", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT EWalletSimpleCredit:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_EWalletSimpleCredit.Status;    // 200
result_EWalletSimpleCredit.Response;    // 1
result_EWalletSimpleCredit.TextResponse;    // Successful
result_EWalletSimpleCredit.TransId;    // 10924173
result_EWalletSimpleCredit.XRef;    // 7U3AQNNZD6PNC
result_EWalletSimpleCredit.Type;    // credit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### FiservSimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_FiservSimpleSale = await _sparrow_creditcard.FiservSimpleSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT FiservSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_FiservSimpleSale.Status;    // 200
result_FiservSimpleSale.Response;    // 1
result_FiservSimpleSale.TextResponse;    // SUCCESS
result_FiservSimpleSale.TransId;    // 10924174
result_FiservSimpleSale.XRef;    // 3862370341
result_FiservSimpleSale.AuthCode;    // 123456
result_FiservSimpleSale.Type;    // sale
result_FiservSimpleSale.CodeResponse;    // 100
result_FiservSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AdvancedFiservSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedFiservSale = await _sparrow_creditcard.AdvancedFiservSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedFiservSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedFiservSale.Status;    // 200
result_AdvancedFiservSale.Response;    // 1
result_AdvancedFiservSale.TextResponse;    // SUCCESS
result_AdvancedFiservSale.TransId;    // 10924176
result_AdvancedFiservSale.XRef;    // 3862370432
result_AdvancedFiservSale.AuthCode;    // 123456
result_AdvancedFiservSale.Type;    // sale
result_AdvancedFiservSale.CodeResponse;    // 100
result_AdvancedFiservSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### MarkSuccessfulTransactionAsChargeback


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow_creditcard.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_MarkSuccessfulTransactionAsChargeback = await _sparrow_creditcard.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, "Testing for Success");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10924177
result_SimpleSale.XRef;    // 3862370480
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT MarkSuccessfulTransactionAsChargeback:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_MarkSuccessfulTransactionAsChargeback.Status;    // 200
result_MarkSuccessfulTransactionAsChargeback.Response;    // 1
result_MarkSuccessfulTransactionAsChargeback.TextResponse;    // Testing for Success
result_MarkSuccessfulTransactionAsChargeback.TransId;    // 10924177
result_MarkSuccessfulTransactionAsChargeback.XRef;    // 3862370480
result_MarkSuccessfulTransactionAsChargeback.AuthCode;    // 123456
result_MarkSuccessfulTransactionAsChargeback.Type;    // chargeback
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### RetrieveCardBalance


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_RetrieveCardBalance = await _sparrow_creditcard.RetrieveCardBalance("4111111111111111");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT RetrieveCardBalance:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_RetrieveCardBalance.Status;    // 500
result_RetrieveCardBalance.Response;    // 3
result_RetrieveCardBalance.TextResponse;    // Operation type is not supported by payment processor
result_RetrieveCardBalance.Type;    // balanceinquire
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### DecryptCustomFields


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_DecryptCustomFields = await _sparrow_creditcard.DecryptCustomFields("customField1", result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '4EIV6O3EX5UQADLR' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 4EIV6O3EX5UQADLR
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DecryptCustomFields:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DecryptCustomFields.Response;    // 3
result_DecryptCustomFields.TextResponse;    // Custom field 'customField1' not found.
result_DecryptCustomFields.CustomerToken;    // 4EIV6O3EX5UQADLR
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### VerifyAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_VerifyAccount = await _sparrow_creditcard.VerifyAccount("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT VerifyAccount:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_VerifyAccount.Status;    // 200
result_VerifyAccount.Response;    // 1
result_VerifyAccount.TextResponse;    // SUCCESS
result_VerifyAccount.TransId;    // 10924178
result_VerifyAccount.XRef;    // 3862370592
result_VerifyAccount.AuthCode;    // 123456
result_VerifyAccount.Type;    // auth
result_VerifyAccount.CodeResponse;    // 100
result_VerifyAccount.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AddCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '9WLRTT7N7PFFQ291' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 9WLRTT7N7PFFQ291
result_AddCustomer.PaymentTokens[0];    // ZTJEG5X1ZT5J7MEO
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AddCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCreditCard = await _sparrow_creditcard.AddCreditCard("John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCreditCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCreditCard.Response;    // 1
result_AddCreditCard.TextResponse;    // Customer with token '4OWF313VF6MSX9X3' successfully created
result_AddCreditCard.Type;    // addcustomer
result_AddCreditCard.CustomerToken;    // 4OWF313VF6MSX9X3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AddACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddACH = await _sparrow_ach.AddACH("John", "Doe", "First Test Bank", "110000000", "1234567890123");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddACH:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddACH.TextResponse;    // Customer with token '9O789JCULJH6EE5V' successfully created
result_AddACH.Type;    // addcustomer
result_AddACH.CustomerToken;    // 9O789JCULJH6EE5V
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AddStarCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddStarCard = await _sparrow_starcard.AddStarCard("John", "Doe", "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddStarCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddStarCard.TextResponse;    // Customer with token 'TZ58HFPLMNUMXC4V' successfully created
result_AddStarCard.Type;    // addcustomer
result_AddStarCard.CustomerToken;    // TZ58HFPLMNUMXC4V
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AddEwallet


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddEwallet = await _sparrow_ewallet.AddEwallet("John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddEwallet:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddEwallet.Response;    // 1
result_AddEwallet.TextResponse;    // Customer with token '1U2Y4F7E9T1AXXQU' successfully created
result_AddEwallet.Type;    // addcustomer
result_AddEwallet.CustomerToken;    // 1U2Y4F7E9T1AXXQU
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### UpdateCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_UpdateCustomer = await _sparrow_creditcard.UpdateCustomer(result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'PYROPNJDLWQ9CLRX' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // PYROPNJDLWQ9CLRX
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdateCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdateCustomer.Response;    // 1
result_UpdateCustomer.TextResponse;    // Customer with token 'PYROPNJDLWQ9CLRX' successfully updated
result_UpdateCustomer.Type;    // updatecustomer
result_UpdateCustomer.CustomerToken;    // PYROPNJDLWQ9CLRX
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### DeletePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_DeletePaymentType = await _sparrow_creditcard.DeletePaymentType(result_AddCustomer.CustomerToken, 
                payments: new []{ new Sparrow.DeletePaymentTypePayment{ Token = result_AddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'I16LINKZ8L3QGQ7C' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // I16LINKZ8L3QGQ7C
result_AddCustomer.PaymentTokens[0];    // C1C8RINGQ2WVYQIB
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DeletePaymentType:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DeletePaymentType.Response;    // 1
result_DeletePaymentType.TextResponse;    // Customer with token 'I16LINKZ8L3QGQ7C' successfully updated
result_DeletePaymentType.Type;    // updatecustomer
result_DeletePaymentType.CustomerToken;    // I16LINKZ8L3QGQ7C
result_DeletePaymentType.PaymentTokens[0];    // C1C8RINGQ2WVYQIB
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### DeleteDataVaultCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe");
            var result_DeleteDataVaultCustomer = await _sparrow_creditcard.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '57E6GSNBO2PET264' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 57E6GSNBO2PET264
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DeleteDataVaultCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DeleteDataVaultCustomer.Response;    // 1
result_DeleteDataVaultCustomer.TextResponse;    // SUCCESS
result_DeleteDataVaultCustomer.Type;    // deletecustomer
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### CreatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // K1GB4B1PRZ26X1XV
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### UpdatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result_UpdatePaymentPlan = await _sparrow_creditcard.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // YO6LISF9O05Q0ZAS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdatePaymentPlan.Response;    // 1
result_UpdatePaymentPlan.TextResponse;    // SUCCESS
result_UpdatePaymentPlan.Type;    // updateplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### DeletePlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result_DeletePlan = await _sparrow_creditcard.DeletePlan(result_CreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // C2UIMB5UNATY2IWX
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DeletePlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DeletePlan.Response;    // 1
result_DeletePlan.TextResponse;    // SUCCESS
result_DeletePlan.Type;    // deleteplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### AssignPaymentPlanToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '526KT72N1ERQX7LZ' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 526KT72N1ERQX7LZ
result_AddCustomer.PaymentTokens[0];    // 27C1HXSXSM7H8RGF
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // XKSNUQU3Q39PRB6Y
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AssignPaymentPlanToCustomer.Response;    // 1
result_AssignPaymentPlanToCustomer.TextResponse;    // Success
result_AssignPaymentPlanToCustomer.Type;    // assignplan
result_AssignPaymentPlanToCustomer.AssignmentToken;    // DHU82Z8E9HRHTO6Q
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### UpdatePaymentPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_UpdatePaymentPlanAssignment = await _sparrow_creditcard.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken, 
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions{ StartDate = "02/02/2020" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AssignPaymentPlanToCustomer.Response;    // 1
result_AssignPaymentPlanToCustomer.TextResponse;    // Success
result_AssignPaymentPlanToCustomer.Type;    // assignplan
result_AssignPaymentPlanToCustomer.AssignmentToken;    // 2EC9FKY2T2UHKPRP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '3XVM740Z3MGEMBRH' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 3XVM740Z3MGEMBRH
result_AddCustomer.PaymentTokens[0];    // 6FNMEDA4HMUABL7Q
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // Z465G4PHJJ1HAUOK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdatePaymentPlanAssignment:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdatePaymentPlanAssignment.Response;    // 1
result_UpdatePaymentPlanAssignment.TextResponse;    // Success
result_UpdatePaymentPlanAssignment.Type;    // updateassignment
result_UpdatePaymentPlanAssignment.AssignmentToken;    // 2EC9FKY2T2UHKPRP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### CancelPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_CancelPlanAssignment = await _sparrow_creditcard.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AssignPaymentPlanToCustomer.Response;    // 1
result_AssignPaymentPlanToCustomer.TextResponse;    // Success
result_AssignPaymentPlanToCustomer.Type;    // assignplan
result_AssignPaymentPlanToCustomer.AssignmentToken;    // 5FYK2V1IUMMOFDS3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'M1SMYTU0X1FUJ0XR' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // M1SMYTU0X1FUJ0XR
result_AddCustomer.PaymentTokens[0];    // PZMI8RBWRU3LS2T2
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // 7MMQMM7C971AGKDD
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CancelPlanAssignment:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CancelPlanAssignment.Response;    // 1
result_CancelPlanAssignment.TextResponse;    // Success
result_CancelPlanAssignment.Type;    // cancelassignment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39405
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### UpdateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result_UpdateInvoice = await _sparrow_creditcard.UpdateInvoice(result_CreateInvoice.InvoiceNumber, 
                options: new Sparrow.UpdateInvoiceOptions{ InvoiceStatus = "active" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39406
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdateInvoice.TextResponse;    // Invoice has been successfully updated
result_UpdateInvoice.InvoiceNumber;    // Inv-39406
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### RetrieveInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_RetrieveInvoice = await _sparrow_creditcard.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39407
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT RetrieveInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_RetrieveInvoice.TextResponse;    // Success
result_RetrieveInvoice.InvoiceNumber;    // Inv-39407
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### CancelInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_CancelInvoice = await _sparrow_creditcard.CancelInvoice(result_CreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39408
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CancelInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CancelInvoice.TextResponse;    // invoice has been successfully canceled
result_CancelInvoice.InvoiceNumber;    // Inv-39408
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### CancelInvoiceByCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_CancelInvoiceByCustomer = await _sparrow_creditcard.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39409
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CancelInvoiceByCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CancelInvoiceByCustomer.TextResponse;    // invoice has been successfully canceled
result_CancelInvoiceByCustomer.InvoiceNumber;    // Inv-39409
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### PayInvoiceWithCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_creditcard.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_PayInvoiceWithCreditCard = await _sparrow_creditcard.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, "4111111111111111", "1019");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39410
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT PayInvoiceWithCreditCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_PayInvoiceWithCreditCard.TextResponse;    // Invoice has been successfully paid
result_PayInvoiceWithCreditCard.TransId;    // 10924182
result_PayInvoiceWithCreditCard.InvoiceNumber;    // Inv-39410
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### PayInvoiceWithBankAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow_ach.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_PayInvoiceWithBankAccount = await _sparrow_ach.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal", 
                billing: new Sparrow.PayInvoiceWithBankAccountBilling{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39411
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT PayInvoiceWithBankAccount:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_PayInvoiceWithBankAccount.TextResponse;    // Invoice has been successfully paid
result_PayInvoiceWithBankAccount.TransId;    // 10924184
result_PayInvoiceWithBankAccount.InvoiceNumber;    // Inv-39411
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


