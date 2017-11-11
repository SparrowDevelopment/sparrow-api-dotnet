
### ach/advanced-echeck-sale.md: AdvancedECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, 
    billing: new Sparrow.AdvancedECheckBilling{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929467
result.XRef;    // 3863642397
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/advanced-sale.md: AdvancedACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929468
result.XRef;    // 3863642422
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-ach.md: SimpleACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929469
result.XRef;    // 3863642445
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-echeck.md: SimpleECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, 
    billing: new Sparrow.SimpleECheckBilling{ Company = "Sparrow One", FirstName = "John", LastName = "Doe", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929470
result.XRef;    // 3863642469
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### airline-passenger-sale/passenger-sale.md: PassengerSale (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 500
result.Response;    // 3
result.TextResponse;    // Operation type is not supported by payment processor
result.Type;    // passengersale
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### balance-inquiry/check-balance.md: RetrieveCardBalance (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.RetrieveCardBalance("4111111111111111");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 500
result.Response;    // 3
result.TextResponse;    // Operation type is not supported by payment processor
result.Type;    // balanceinquire
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### cc-verification/card-verification.md: VerifyAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.VerifyAccount("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929471
result.XRef;    // 3863642526
result.AuthCode;    // 123456
result.Type;    // auth
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### chargeback/mark-chargeback.md: MarkSuccessfulTransactionAsChargeback


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.MarkSuccessfulTransactionAsChargeback(resultSimpleSale.TransId, "Testing for Success");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929472
resultSimpleSale.XRef;    // 3863642568
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Testing for Success
result.TransId;    // 10929472
result.XRef;    // 3863642568
result.AuthCode;    // 123456
result.Type;    // chargeback
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-credit/simple-credit.md: SimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleCredit("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929473
result.XRef;    // 3863642618
result.Type;    // credit
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/advanced-sale.md: AdvancedSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929475
result.XRef;    // 3863642645
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/simple-sale.md: SimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929477
result.XRef;    // 3863642673
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/add-payment-type.md: AddPaymentTypesToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.AddPaymentTypesToCustomer(resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '2EBAGW8A3YJ5Z77U' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 2EBAGW8A3YJ5Z77U
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '2EBAGW8A3YJ5Z77U' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 2EBAGW8A3YJ5Z77U
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/adding-a-customer.md: AddCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'RUAKLFZ72K9X2PB4' successfully created
result.Type;    // addcustomer
result.CustomerToken;    // RUAKLFZ72K9X2PB4
result.PaymentTokens[0];    // DGPKWF3928QT5UP2
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-customer.md: DeleteDataVaultCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.DeleteDataVaultCustomer(resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'H85AETOH02DB9BQI' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // H85AETOH02DB9BQI
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // deletecustomer
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-payment-type.md: DeletePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var result = await _sparrow.DeletePaymentType(resultAddCustomer.CustomerToken, 
    payments: new []{ new Sparrow.DeletePaymentTypePayment{ Token = resultAddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '9DURLJ9RYINKMR8Q' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 9DURLJ9RYINKMR8Q
resultAddCustomer.PaymentTokens[0];    // UK50K35XWAXILNUN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '9DURLJ9RYINKMR8Q' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 9DURLJ9RYINKMR8Q
resultAddCustomer.PaymentTokens[0];    // UK50K35XWAXILNUN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '9DURLJ9RYINKMR8Q' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 9DURLJ9RYINKMR8Q
result.PaymentTokens[0];    // UK50K35XWAXILNUN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-customer.md: RetrieveCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.RetrieveCustomer(resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'UO7S65Y78NM5FD5J' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // UO7S65Y78NM5FD5J
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // UO7S65Y78NM5FD5J
result.FirstName;    // John
result.LastName;    // Doe
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-payment-type.md: RetrievePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var result = await _sparrow.RetrievePaymentType(resultAddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '4WRYGZ7GH75LV1FK' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 4WRYGZ7GH75LV1FK
resultAddCustomer.PaymentTokens[0];    // X908TPUYW727R9RS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // 4WRYGZ7GH75LV1FK
result.PayType;    // CreditCard
result.PayNo;    // 1
result.CardExp;    // 1019
result.Account;    // 411111******1111
result.Token;    // X908TPUYW727R9RS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-type.md: UpdateCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var result = await _sparrow.UpdateCustomer(resultAddCustomer.CustomerToken, 
    billing: new Sparrow.UpdateCustomerBilling{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'FOOY66H4Q1K8ANMH' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // FOOY66H4Q1K8ANMH
resultAddCustomer.PaymentTokens[0];    // HBHFM7ZOC2CI7AYI
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'FOOY66H4Q1K8ANMH' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // FOOY66H4Q1K8ANMH
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-types.md: UpdatePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var result = await _sparrow.UpdatePaymentType(resultAddCustomer.CustomerToken, 
    payments: new []{ new Sparrow.UpdatePaymentTypePayment{ Token = resultAddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'PMGGMQN126R2FWYI' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // PMGGMQN126R2FWYI
resultAddCustomer.PaymentTokens[0];    // VUZP1LGIYAWE397Q
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'PMGGMQN126R2FWYI' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // PMGGMQN126R2FWYI
resultAddCustomer.PaymentTokens[0];    // VUZP1LGIYAWE397Q
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'PMGGMQN126R2FWYI' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // PMGGMQN126R2FWYI
result.PaymentTokens[0];    // VUZP1LGIYAWE397Q
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### decrypt-custom-field/decrypt.md: DecryptCustomFields (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.DecryptCustomFields("customField1", resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '1BA9WKJXODH6XLIN' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 1BA9WKJXODH6XLIN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 3
result.TextResponse;    // Custom field 'customField1' not found.
result.CustomerToken;    // 1BA9WKJXODH6XLIN
result.Token;    // 1BA9WKJXODH6XLIN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ewallet/ewallet-credit.md: EWalletSimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.EWalletSimpleCredit("user@example.com", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Successful
result.TransId;    // 10929479
result.XRef;    // NGMMDYCVK9P9W
result.Type;    // credit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-advanced.md: AdvancedFiservSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedFiservSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929480
result.XRef;    // 3863642902
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-simple.md: FiservSimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.FiservSimpleSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929482
result.XRef;    // 3863642936
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-inv-customer.md: CancelInvoiceByCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.CancelInvoiceByCustomer(resultCreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39516
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39516
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-invoice.md: CancelInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.CancelInvoice(resultCreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39517
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39517
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/create-merchant-invoice.md: CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully created
result.InvoiceNumber;    // Inv-39518
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/get-invoice.md: RetrieveInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.RetrieveInvoice(resultCreateInvoice.InvoiceNumber);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39519
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Success
result.InvoiceNumber;    // Inv-39519
result.InvoiceAmount;    // 10.0000
result.Currency;    // USD
result.InvoiceDate;    // 12/01/2017
result.InvoiceStatus;    // Active
result.InvoicePaymentLink;    // https://secure.sparrowone.com/Payments/Payment.aspx?token=5BDAEBCF4AB46D71
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-ach.md: PayInvoiceWithBankAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.PayInvoiceWithBankAccount(resultCreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal", 
    billing: new Sparrow.PayInvoiceWithBankAccountBilling{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39520
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 10929483
result.InvoiceNumber;    // Inv-39520
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-cc.md: PayInvoiceWithCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.PayInvoiceWithCreditCard(resultCreateInvoice.InvoiceNumber, "4111111111111111", "1019");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39521
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 10929485
result.InvoiceNumber;    // Inv-39521
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/update-invoice.md: UpdateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
var result = await _sparrow.UpdateInvoice(resultCreateInvoice.InvoiceNumber, 
    options: new Sparrow.UpdateInvoiceOptions{ InvoiceStatus = "active" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39522
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully updated
result.InvoiceNumber;    // Inv-39522
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/Simple-refund.md: SimpleRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.SimpleRefund(resultSimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929487
resultSimpleSale.XRef;    // 3863643079
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929487
result.XRef;    // 3863643079
result.AuthCode;    // 123456
result.Type;    // refund
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/advanced-refund.md: AdvancedRefund (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.AdvancedRefund(resultSimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929488
resultSimpleSale.XRef;    // 3863643151
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 300
result.Response;    // 3
result.TextResponse;    // Flagged for Review by Velocity and Duplicates Policy (Duplicate Transactions Rule). Original Transaction ID: 10929487
result.TransId;    // 10929488
result.XRef;    // 3863643151
result.AuthCode;    // 123456
result.Type;    // refund
result.OrigTransId;    // 10929487
result.OrigResponse;    // 1
result.OrigTextResponse;    // SUCCESS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/advanced-void.md: AdvancedVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.AdvancedVoid(resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929489
resultSimpleSale.XRef;    // 3863643192
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Transaction Void Successful
result.TransId;    // 10929489
result.XRef;    // 3863643192
result.AuthCode;    // 123456
result.Type;    // void
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/simple-void.md: SimpleVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.SimpleVoid(resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929490
resultSimpleSale.XRef;    // 3863643246
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Transaction Void Successful
result.TransId;    // 10929490
result.XRef;    // 3863643246
result.AuthCode;    // 123456
result.Type;    // void
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/assign-payment-plan.md: AssignPaymentPlanToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
    sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.AssignPaymentPlanToCustomer(resultAddCustomer.CustomerToken, resultCreatePaymentPlan.PlanToken, resultAddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'CCSYHF41YQNQP7JQ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // CCSYHF41YQNQP7JQ
resultAddCustomer.PaymentTokens[0];    // E3WMLJRDG7SM4I82
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'CCSYHF41YQNQP7JQ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // CCSYHF41YQNQP7JQ
resultAddCustomer.PaymentTokens[0];    // E3WMLJRDG7SM4I82
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 4G51PBI3626T77LQ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // assignplan
result.AssignmentToken;    // 8BZCD9BQZ81L8Z21
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/cancel-plan-assignment.md: CancelPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
    sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(resultAddCustomer.CustomerToken, resultCreatePaymentPlan.PlanToken, resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.CancelPlanAssignment(resultAssignPaymentPlanToCustomer.AssignmentToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // 1G9AMUE3VORJWS7P
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '0D6Q37KFDXJV268I' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 0D6Q37KFDXJV268I
resultAddCustomer.PaymentTokens[0];    // A9BQQQ7VG8WZZNO3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '0D6Q37KFDXJV268I' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 0D6Q37KFDXJV268I
resultAddCustomer.PaymentTokens[0];    // A9BQQQ7VG8WZZNO3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // YBXVJWO75ZY22WAA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // cancelassignment
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/create-plan.md: CreatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
    sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // addplan
result.PlanToken;    // SUROHGME2FXNRGFQ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/delete-plan.md: DeletePlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
var result = await _sparrow.DeletePlan(resultCreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 3YT854AJFLK4KUPZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // deleteplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan-assignment.md: UpdatePaymentPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018", 
    sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(resultAddCustomer.CustomerToken, resultCreatePaymentPlan.PlanToken, resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.UpdatePaymentPlanAssignment(resultAssignPaymentPlanToCustomer.AssignmentToken, 
    options: new Sparrow.UpdatePaymentPlanAssignmentOptions{ StartDate = "02/02/2020" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // BM2NHNUU35IH71LP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'IP61JN9NUEV02F2T' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // IP61JN9NUEV02F2T
resultAddCustomer.PaymentTokens[0];    // 8W6B4Q74ANP7MTWK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultAddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'IP61JN9NUEV02F2T' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // IP61JN9NUEV02F2T
resultAddCustomer.PaymentTokens[0];    // 8W6B4Q74ANP7MTWK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // F0VXJ7QN66RYR13H
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // updateassignment
result.AssignmentToken;    // BM2NHNUU35IH71LP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan.md: UpdatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
    sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 10.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.UpdatePaymentPlan(resultCreatePaymentPlan.PlanToken, 
    sequences: new []{ new Sparrow.AddOrUpdateSequenceSequence{ OperationType = "updatesequence", Sequence = 1, Amount = 20.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultCreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // K8TMZJ0PZFN1JJR9
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // updateplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/Offline-Capture.md: SimpleOfflineCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929492
result.XRef;    // 3863643375
result.AuthCode;    // 123456
result.Type;    // offline
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/advanced-capture.md: AdvancedCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
var result = await _sparrow.AdvancedCapture(resultSimpleAuthorization.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleAuthorization.Status;    // 200
resultSimpleAuthorization.Response;    // 1
resultSimpleAuthorization.TextResponse;    // SUCCESS
resultSimpleAuthorization.TransId;    // 10929493
resultSimpleAuthorization.XRef;    // 3863643400
resultSimpleAuthorization.AuthCode;    // 123456
resultSimpleAuthorization.Type;    // auth
resultSimpleAuthorization.CodeResponse;    // 100
resultSimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929493
result.XRef;    // 3863643400
result.AuthCode;    // 123456
result.Type;    // capture
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-auth.md: SimpleAuthorization


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929496
result.XRef;    // 3863643475
result.AuthCode;    // 123456
result.Type;    // auth
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-capture.md: SimpleCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
var result = await _sparrow.SimpleCapture(resultSimpleAuthorization.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT resultSimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleAuthorization.Status;    // 200
resultSimpleAuthorization.Response;    // 1
resultSimpleAuthorization.TextResponse;    // SUCCESS
resultSimpleAuthorization.TransId;    // 10929497
resultSimpleAuthorization.XRef;    // 3863643513
resultSimpleAuthorization.AuthCode;    // 123456
resultSimpleAuthorization.Type;    // auth
resultSimpleAuthorization.CodeResponse;    // 100
resultSimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929497
result.XRef;    // 3863643513
result.AuthCode;    // 123456
result.Type;    // capture
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/advanced-starcard.md: AdvancedStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 10929498
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/simple-starcard.md: SimpleStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleStarCard("4111111111111111", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT result:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 10929499
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


