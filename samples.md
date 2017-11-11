
### ach/advanced-echeck-sale.md: AdvancedECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedECheck = await _sparrow.AdvancedECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, 
                billing: new Sparrow.AdvancedECheckBilling{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedECheck:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedECheck.Status;    // 200
result_AdvancedECheck.TextResponse;    // SUCCESS
result_AdvancedECheck.TransId;    // 10929102
result_AdvancedECheck.XRef;    // 3863565714
result_AdvancedECheck.AuthCode;    // 123456
result_AdvancedECheck.Type;    // sale
result_AdvancedECheck.CodeResponse;    // 100
result_AdvancedECheck.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/advanced-sale.md: AdvancedACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedACH = await _sparrow.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedACH:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedACH.Status;    // 200
result_AdvancedACH.TextResponse;    // SUCCESS
result_AdvancedACH.TransId;    // 10929103
result_AdvancedACH.XRef;    // 3863565748
result_AdvancedACH.AuthCode;    // 123456
result_AdvancedACH.Type;    // sale
result_AdvancedACH.CodeResponse;    // 100
result_AdvancedACH.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-ach.md: SimpleACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleACH = await _sparrow.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleACH:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleACH.Status;    // 200
result_SimpleACH.TextResponse;    // SUCCESS
result_SimpleACH.TransId;    // 10929104
result_SimpleACH.XRef;    // 3863565774
result_SimpleACH.AuthCode;    // 123456
result_SimpleACH.Type;    // sale
result_SimpleACH.CodeResponse;    // 100
result_SimpleACH.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-echeck.md: SimpleECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleECheck = await _sparrow.SimpleECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, 
                billing: new Sparrow.SimpleECheckBilling{ Company = "Sparrow One", FirstName = "John", LastName = "Doe", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleECheck:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleECheck.Status;    // 200
result_SimpleECheck.TextResponse;    // SUCCESS
result_SimpleECheck.TransId;    // 10929105
result_SimpleECheck.XRef;    // 3863565800
result_SimpleECheck.AuthCode;    // 123456
result_SimpleECheck.Type;    // sale
result_SimpleECheck.CodeResponse;    // 100
result_SimpleECheck.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### airline-passenger-sale/passenger-sale.md: PassengerSale (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_PassengerSale = await _sparrow.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT PassengerSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_PassengerSale.Status;    // 500
result_PassengerSale.Response;    // 3
result_PassengerSale.TextResponse;    // Operation type is not supported by payment processor
result_PassengerSale.Type;    // passengersale
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### balance-inquiry/check-balance.md: RetrieveCardBalance (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_RetrieveCardBalance = await _sparrow.RetrieveCardBalance("4111111111111111");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT RetrieveCardBalance:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_RetrieveCardBalance.Status;    // 500
result_RetrieveCardBalance.Response;    // 3
result_RetrieveCardBalance.TextResponse;    // Operation type is not supported by payment processor
result_RetrieveCardBalance.Type;    // balanceinquire
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### cc-verification/card-verification.md: VerifyAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_VerifyAccount = await _sparrow.VerifyAccount("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT VerifyAccount:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_VerifyAccount.Status;    // 200
result_VerifyAccount.Response;    // 1
result_VerifyAccount.TextResponse;    // SUCCESS
result_VerifyAccount.TransId;    // 10929107
result_VerifyAccount.XRef;    // 3863565851
result_VerifyAccount.AuthCode;    // 123456
result_VerifyAccount.Type;    // auth
result_VerifyAccount.CodeResponse;    // 100
result_VerifyAccount.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### chargeback/mark-chargeback.md: MarkSuccessfulTransactionAsChargeback


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_MarkSuccessfulTransactionAsChargeback = await _sparrow.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, "Testing for Success");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10929109
result_SimpleSale.XRef;    // 3863565918
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
result_MarkSuccessfulTransactionAsChargeback.TransId;    // 10929109
result_MarkSuccessfulTransactionAsChargeback.XRef;    // 3863565918
result_MarkSuccessfulTransactionAsChargeback.AuthCode;    // 123456
result_MarkSuccessfulTransactionAsChargeback.Type;    // chargeback
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-credit/simple-credit.md: SimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleCredit = await _sparrow.SimpleCredit("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleCredit:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleCredit.Status;    // 200
result_SimpleCredit.Response;    // 1
result_SimpleCredit.TextResponse;    // SUCCESS
result_SimpleCredit.TransId;    // 10929110
result_SimpleCredit.XRef;    // 3863566020
result_SimpleCredit.Type;    // credit
result_SimpleCredit.CodeResponse;    // 100
result_SimpleCredit.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/advanced-sale.md: AdvancedSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedSale = await _sparrow.AdvancedSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedSale.Status;    // 200
result_AdvancedSale.Response;    // 1
result_AdvancedSale.TextResponse;    // SUCCESS
result_AdvancedSale.TransId;    // 10929111
result_AdvancedSale.XRef;    // 3863566064
result_AdvancedSale.AuthCode;    // 123456
result_AdvancedSale.Type;    // sale
result_AdvancedSale.CodeResponse;    // 100
result_AdvancedSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/simple-sale.md: SimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10929112
result_SimpleSale.XRef;    // 3863566120
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/add-payment-type.md: AddPaymentTypesToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result_AddPaymentTypesToCustomer = await _sparrow.AddPaymentTypesToCustomer(result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'PG31IODZGHZ1NVTZ' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // PG31IODZGHZ1NVTZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddPaymentTypesToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddPaymentTypesToCustomer.Response;    // 1
result_AddPaymentTypesToCustomer.TextResponse;    // Customer with token 'PG31IODZGHZ1NVTZ' successfully updated
result_AddPaymentTypesToCustomer.Type;    // updatecustomer
result_AddPaymentTypesToCustomer.CustomerToken;    // PG31IODZGHZ1NVTZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/adding-a-customer.md: AddCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'OVF7RGGUA6OYBXDZ' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // OVF7RGGUA6OYBXDZ
result_AddCustomer.PaymentTokens[0];    // RF9YBRB1LDDQ87ZN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-customer.md: DeleteDataVaultCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result_DeleteDataVaultCustomer = await _sparrow.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '3IRRFJJEFNJAQXVM' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 3IRRFJJEFNJAQXVM
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DeleteDataVaultCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DeleteDataVaultCustomer.Response;    // 1
result_DeleteDataVaultCustomer.TextResponse;    // SUCCESS
result_DeleteDataVaultCustomer.Type;    // deletecustomer
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-payment-type.md: DeletePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_DeletePaymentType = await _sparrow.DeletePaymentType(result_AddCustomer.CustomerToken, 
                payments: new []{ new Sparrow.DeletePaymentTypePayment{ Token = result_AddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '10VBWOUHF1RXZJ2P' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 10VBWOUHF1RXZJ2P
result_AddCustomer.PaymentTokens[0];    // SBPSIEO8CHGZ9QBK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DeletePaymentType:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DeletePaymentType.Response;    // 1
result_DeletePaymentType.TextResponse;    // Customer with token '10VBWOUHF1RXZJ2P' successfully updated
result_DeletePaymentType.Type;    // updatecustomer
result_DeletePaymentType.CustomerToken;    // 10VBWOUHF1RXZJ2P
result_DeletePaymentType.PaymentTokens[0];    // SBPSIEO8CHGZ9QBK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-customer.md: RetrieveCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result_RetrieveCustomer = await _sparrow.RetrieveCustomer(result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'SW7VSVOOXKMN2WP5' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // SW7VSVOOXKMN2WP5
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT RetrieveCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_RetrieveCustomer.Response;    // 1
result_RetrieveCustomer.TextResponse;    // Processed
result_RetrieveCustomer.CustomerToken;    // SW7VSVOOXKMN2WP5
result_RetrieveCustomer.FirstName;    // John
result_RetrieveCustomer.LastName;    // Doe
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-payment-type.md: RetrievePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_RetrievePaymentType = await _sparrow.RetrievePaymentType(result_AddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'GBW69Q8DL0Y2ZZ16' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // GBW69Q8DL0Y2ZZ16
result_AddCustomer.PaymentTokens[0];    // OUL8XR2HQ1BM2QFJ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT RetrievePaymentType:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_RetrievePaymentType.Response;    // 1
result_RetrievePaymentType.TextResponse;    // Processed
result_RetrievePaymentType.CustomerToken;    // GBW69Q8DL0Y2ZZ16
result_RetrievePaymentType.PayType;    // CreditCard
result_RetrievePaymentType.PayNo;    // 1
result_RetrievePaymentType.CardExp;    // 1019
result_RetrievePaymentType.Account;    // 411111******1111
result_RetrievePaymentType.Token;    // OUL8XR2HQ1BM2QFJ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-type.md: UpdateCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_UpdateCustomer = await _sparrow.UpdateCustomer(result_AddCustomer.CustomerToken, 
                billing: new Sparrow.UpdateCustomerBilling{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'V4SOICEXMW9PI4HZ' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // V4SOICEXMW9PI4HZ
result_AddCustomer.PaymentTokens[0];    // 0GECMG67XA581AGP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdateCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdateCustomer.Response;    // 1
result_UpdateCustomer.TextResponse;    // Customer with token 'V4SOICEXMW9PI4HZ' successfully updated
result_UpdateCustomer.Type;    // updatecustomer
result_UpdateCustomer.CustomerToken;    // V4SOICEXMW9PI4HZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-types.md: UpdatePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_UpdatePaymentType = await _sparrow.UpdatePaymentType(result_AddCustomer.CustomerToken, 
                payments: new []{ new Sparrow.UpdatePaymentTypePayment{ Token = result_AddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '1KEF7WBQSJJ5W8G2' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 1KEF7WBQSJJ5W8G2
result_AddCustomer.PaymentTokens[0];    // CXXVRMTP7V1IGG5L
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdatePaymentType:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdatePaymentType.Response;    // 1
result_UpdatePaymentType.TextResponse;    // Customer with token '1KEF7WBQSJJ5W8G2' successfully updated
result_UpdatePaymentType.Type;    // updatecustomer
result_UpdatePaymentType.CustomerToken;    // 1KEF7WBQSJJ5W8G2
result_UpdatePaymentType.PaymentTokens[0];    // CXXVRMTP7V1IGG5L
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### decrypt-custom-field/decrypt.md: DecryptCustomFields (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result_DecryptCustomFields = await _sparrow.DecryptCustomFields("customField1", result_AddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'QTY70B1DFYUC7AKY' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // QTY70B1DFYUC7AKY
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DecryptCustomFields:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DecryptCustomFields.Response;    // 3
result_DecryptCustomFields.TextResponse;    // Custom field 'customField1' not found.
result_DecryptCustomFields.CustomerToken;    // QTY70B1DFYUC7AKY
result_DecryptCustomFields.Token;    // QTY70B1DFYUC7AKY
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ewallet/ewallet-credit.md: EWalletSimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_EWalletSimpleCredit = await _sparrow.EWalletSimpleCredit("user@example.com", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT EWalletSimpleCredit:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_EWalletSimpleCredit.Status;    // 200
result_EWalletSimpleCredit.Response;    // 1
result_EWalletSimpleCredit.TextResponse;    // Successful
result_EWalletSimpleCredit.TransId;    // 10929114
result_EWalletSimpleCredit.XRef;    // NUJR8JALVZNDW
result_EWalletSimpleCredit.Type;    // credit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-advanced.md: AdvancedFiservSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedFiservSale = await _sparrow.AdvancedFiservSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedFiservSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedFiservSale.Status;    // 200
result_AdvancedFiservSale.Response;    // 1
result_AdvancedFiservSale.TextResponse;    // SUCCESS
result_AdvancedFiservSale.TransId;    // 10929115
result_AdvancedFiservSale.XRef;    // 3863566447
result_AdvancedFiservSale.AuthCode;    // 123456
result_AdvancedFiservSale.Type;    // sale
result_AdvancedFiservSale.CodeResponse;    // 100
result_AdvancedFiservSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-simple.md: FiservSimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_FiservSimpleSale = await _sparrow.FiservSimpleSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT FiservSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_FiservSimpleSale.Status;    // 200
result_FiservSimpleSale.Response;    // 1
result_FiservSimpleSale.TextResponse;    // SUCCESS
result_FiservSimpleSale.TransId;    // 10929116
result_FiservSimpleSale.XRef;    // 3863566487
result_FiservSimpleSale.AuthCode;    // 123456
result_FiservSimpleSale.Type;    // sale
result_FiservSimpleSale.CodeResponse;    // 100
result_FiservSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-inv-customer.md: CancelInvoiceByCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_CancelInvoiceByCustomer = await _sparrow.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39509
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CancelInvoiceByCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CancelInvoiceByCustomer.TextResponse;    // invoice has been successfully canceled
result_CancelInvoiceByCustomer.InvoiceNumber;    // Inv-39509
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-invoice.md: CancelInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_CancelInvoice = await _sparrow.CancelInvoice(result_CreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39510
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CancelInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CancelInvoice.TextResponse;    // invoice has been successfully canceled
result_CancelInvoice.InvoiceNumber;    // Inv-39510
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/create-merchant-invoice.md: CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39511
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/get-invoice.md: RetrieveInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_RetrieveInvoice = await _sparrow.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39512
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT RetrieveInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_RetrieveInvoice.TextResponse;    // Success
result_RetrieveInvoice.InvoiceNumber;    // Inv-39512
result_RetrieveInvoice.InvoiceAmount;    // 10.0000
result_RetrieveInvoice.Currency;    // USD
result_RetrieveInvoice.InvoiceDate;    // 12/01/2017
result_RetrieveInvoice.InvoiceStatus;    // Active
result_RetrieveInvoice.InvoicePaymentLink;    // https://secure.sparrowone.com/Payments/Payment.aspx?token=15693F50EC8DEB7D
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-ach.md: PayInvoiceWithBankAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_PayInvoiceWithBankAccount = await _sparrow.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal", 
                billing: new Sparrow.PayInvoiceWithBankAccountBilling{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39513
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT PayInvoiceWithBankAccount:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_PayInvoiceWithBankAccount.TextResponse;    // Invoice has been successfully paid
result_PayInvoiceWithBankAccount.TransId;    // 10929117
result_PayInvoiceWithBankAccount.InvoiceNumber;    // Inv-39513
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-cc.md: PayInvoiceWithCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result_PayInvoiceWithCreditCard = await _sparrow.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, "4111111111111111", "1019");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39514
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT PayInvoiceWithCreditCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_PayInvoiceWithCreditCard.TextResponse;    // Invoice has been successfully paid
result_PayInvoiceWithCreditCard.TransId;    // 10929118
result_PayInvoiceWithCreditCard.InvoiceNumber;    // Inv-39514
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/update-invoice.md: UpdateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result_UpdateInvoice = await _sparrow.UpdateInvoice(result_CreateInvoice.InvoiceNumber, 
                options: new Sparrow.UpdateInvoiceOptions{ InvoiceStatus = "active" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreateInvoice.TextResponse;    // invoice has been successfully created
result_CreateInvoice.InvoiceNumber;    // Inv-39515
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdateInvoice.TextResponse;    // Invoice has been successfully updated
result_UpdateInvoice.InvoiceNumber;    // Inv-39515
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/Simple-refund.md: SimpleRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_SimpleRefund = await _sparrow.SimpleRefund(result_SimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10929119
result_SimpleSale.XRef;    // 3863566739
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
result_SimpleRefund.TransId;    // 10929119
result_SimpleRefund.XRef;    // 3863566739
result_SimpleRefund.AuthCode;    // 123456
result_SimpleRefund.Type;    // refund
result_SimpleRefund.CodeResponse;    // 100
result_SimpleRefund.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/advanced-refund.md: AdvancedRefund (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_AdvancedRefund = await _sparrow.AdvancedRefund(result_SimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10929120
result_SimpleSale.XRef;    // 3863566840
result_SimpleSale.AuthCode;    // 123456
result_SimpleSale.Type;    // sale
result_SimpleSale.CodeResponse;    // 100
result_SimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedRefund:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedRefund.Status;    // 300
result_AdvancedRefund.Response;    // 3
result_AdvancedRefund.TextResponse;    // Flagged for Review by Velocity and Duplicates Policy (Duplicate Transactions Rule). Original Transaction ID: 10929119
result_AdvancedRefund.TransId;    // 10929120
result_AdvancedRefund.XRef;    // 3863566840
result_AdvancedRefund.AuthCode;    // 123456
result_AdvancedRefund.Type;    // refund
result_AdvancedRefund.OrigTransId;    // 10929119
result_AdvancedRefund.OrigResponse;    // 1
result_AdvancedRefund.OrigTextResponse;    // SUCCESS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/advanced-void.md: AdvancedVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_AdvancedVoid = await _sparrow.AdvancedVoid(result_SimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10929121
result_SimpleSale.XRef;    // 3863566906
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
result_AdvancedVoid.TransId;    // 10929121
result_AdvancedVoid.XRef;    // 3863566906
result_AdvancedVoid.AuthCode;    // 123456
result_AdvancedVoid.Type;    // void
result_AdvancedVoid.CodeResponse;    // 100
result_AdvancedVoid.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/simple-void.md: SimpleVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result_SimpleVoid = await _sparrow.SimpleVoid(result_SimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleSale.Status;    // 200
result_SimpleSale.Response;    // 1
result_SimpleSale.TextResponse;    // SUCCESS
result_SimpleSale.TransId;    // 10929122
result_SimpleSale.XRef;    // 3863566983
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
result_SimpleVoid.TransId;    // 10929122
result_SimpleVoid.XRef;    // 3863566983
result_SimpleVoid.AuthCode;    // 123456
result_SimpleVoid.Type;    // void
result_SimpleVoid.CodeResponse;    // 100
result_SimpleVoid.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/assign-payment-plan.md: AssignPaymentPlanToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token '3C5ENV7O1ZIM53JM' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // 3C5ENV7O1ZIM53JM
result_AddCustomer.PaymentTokens[0];    // N7PCKJCB5TP22QR6
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // XYE832TXBH74F5H4
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AssignPaymentPlanToCustomer.Response;    // 1
result_AssignPaymentPlanToCustomer.TextResponse;    // Success
result_AssignPaymentPlanToCustomer.Type;    // assignplan
result_AssignPaymentPlanToCustomer.AssignmentToken;    // KCODK184WJFB3OIM
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/cancel-plan-assignment.md: CancelPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_CancelPlanAssignment = await _sparrow.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AssignPaymentPlanToCustomer.Response;    // 1
result_AssignPaymentPlanToCustomer.TextResponse;    // Success
result_AssignPaymentPlanToCustomer.Type;    // assignplan
result_AssignPaymentPlanToCustomer.AssignmentToken;    // 6CIZ0GK3WMS007EL
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'WZ9TOXOZJPPHPWK5' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // WZ9TOXOZJPPHPWK5
result_AddCustomer.PaymentTokens[0];    // VPFAU3DWAY6QU7BU
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // TG0CQV49KPZNMLIP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CancelPlanAssignment:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CancelPlanAssignment.Response;    // 1
result_CancelPlanAssignment.TextResponse;    // Success
result_CancelPlanAssignment.Type;    // cancelassignment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/create-plan.md: CreatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // N5YI5IO9VG0FDZKZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/delete-plan.md: DeletePlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result_DeletePlan = await _sparrow.DeletePlan(result_CreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // PIY9UIOUA3J4GEWK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT DeletePlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_DeletePlan.Response;    // 1
result_DeletePlan.TextResponse;    // SUCCESS
result_DeletePlan.Type;    // deleteplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan-assignment.md: UpdatePaymentPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result_UpdatePaymentPlanAssignment = await _sparrow.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken, 
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions{ StartDate = "02/02/2020" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AssignPaymentPlanToCustomer.Response;    // 1
result_AssignPaymentPlanToCustomer.TextResponse;    // Success
result_AssignPaymentPlanToCustomer.Type;    // assignplan
result_AssignPaymentPlanToCustomer.AssignmentToken;    // X54RMP8KHC992OR9
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AddCustomer.Response;    // 1
result_AddCustomer.TextResponse;    // Customer with token 'HLC2OFBW9VQADAIQ' successfully created
result_AddCustomer.Type;    // addcustomer
result_AddCustomer.CustomerToken;    // HLC2OFBW9VQADAIQ
result_AddCustomer.PaymentTokens[0];    // KDNT1SMBX4DRSEYR
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // PRUSZL4N67PDDEIN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdatePaymentPlanAssignment:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdatePaymentPlanAssignment.Response;    // 1
result_UpdatePaymentPlanAssignment.TextResponse;    // Success
result_UpdatePaymentPlanAssignment.Type;    // updateassignment
result_UpdatePaymentPlanAssignment.AssignmentToken;    // X54RMP8KHC992OR9
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan.md: UpdatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 10.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_UpdatePaymentPlan = await _sparrow.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken, 
                sequences: new []{ new Sparrow.AddOrUpdateSequenceSequence{ OperationType = "updatesequence", Sequence = 1, Amount = 20.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_CreatePaymentPlan.Response;    // 1
result_CreatePaymentPlan.TextResponse;    // SUCCESS
result_CreatePaymentPlan.Type;    // addplan
result_CreatePaymentPlan.PlanToken;    // V2TD1CSY9AFUBUE5
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT UpdatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_UpdatePaymentPlan.Response;    // 1
result_UpdatePaymentPlan.TextResponse;    // SUCCESS
result_UpdatePaymentPlan.Type;    // updateplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/Offline-Capture.md: SimpleOfflineCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleOfflineCapture = await _sparrow.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleOfflineCapture:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleOfflineCapture.Status;    // 200
result_SimpleOfflineCapture.Response;    // 1
result_SimpleOfflineCapture.TextResponse;    // SUCCESS
result_SimpleOfflineCapture.TransId;    // 10929123
result_SimpleOfflineCapture.XRef;    // 3863567242
result_SimpleOfflineCapture.AuthCode;    // 123456
result_SimpleOfflineCapture.Type;    // offline
result_SimpleOfflineCapture.CodeResponse;    // 100
result_SimpleOfflineCapture.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/advanced-capture.md: AdvancedCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleAuthorization = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result_AdvancedCapture = await _sparrow.AdvancedCapture(result_SimpleAuthorization.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleAuthorization.Status;    // 200
result_SimpleAuthorization.Response;    // 1
result_SimpleAuthorization.TextResponse;    // SUCCESS
result_SimpleAuthorization.TransId;    // 10929124
result_SimpleAuthorization.XRef;    // 3863567294
result_SimpleAuthorization.AuthCode;    // 123456
result_SimpleAuthorization.Type;    // auth
result_SimpleAuthorization.CodeResponse;    // 100
result_SimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedCapture:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedCapture.Status;    // 200
result_AdvancedCapture.Response;    // 1
result_AdvancedCapture.TextResponse;    // SUCCESS
result_AdvancedCapture.TransId;    // 10929124
result_AdvancedCapture.XRef;    // 3863567294
result_AdvancedCapture.AuthCode;    // 123456
result_AdvancedCapture.Type;    // capture
result_AdvancedCapture.CodeResponse;    // 100
result_AdvancedCapture.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-auth.md: SimpleAuthorization


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleAuthorization = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleAuthorization.Status;    // 200
result_SimpleAuthorization.Response;    // 1
result_SimpleAuthorization.TextResponse;    // SUCCESS
result_SimpleAuthorization.TransId;    // 10929125
result_SimpleAuthorization.XRef;    // 3863567371
result_SimpleAuthorization.AuthCode;    // 123456
result_SimpleAuthorization.Type;    // auth
result_SimpleAuthorization.CodeResponse;    // 100
result_SimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-capture.md: SimpleCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleAuthorization = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result_SimpleCapture = await _sparrow.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleAuthorization.Status;    // 200
result_SimpleAuthorization.Response;    // 1
result_SimpleAuthorization.TextResponse;    // SUCCESS
result_SimpleAuthorization.TransId;    // 10929126
result_SimpleAuthorization.XRef;    // 3863567419
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
result_SimpleCapture.TransId;    // 10929126
result_SimpleCapture.XRef;    // 3863567419
result_SimpleCapture.AuthCode;    // 123456
result_SimpleCapture.Type;    // capture
result_SimpleCapture.CodeResponse;    // 100
result_SimpleCapture.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/advanced-starcard.md: AdvancedStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_AdvancedStarCard = await _sparrow.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AdvancedStarCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_AdvancedStarCard.Status;    // 400
result_AdvancedStarCard.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result_AdvancedStarCard.TransId;    // 10929127
result_AdvancedStarCard.Type;    // sale
result_AdvancedStarCard.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/simple-starcard.md: SimpleStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            var result_SimpleStarCard = await _sparrow.SimpleStarCard("4111111111111111", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleStarCard:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result_SimpleStarCard.Status;    // 400
result_SimpleStarCard.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result_SimpleStarCard.TransId;    // 10929128
result_SimpleStarCard.Type;    // sale
result_SimpleStarCard.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


