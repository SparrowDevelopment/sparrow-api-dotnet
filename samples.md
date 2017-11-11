
### ach/advanced-echeck-sale.md: AdvancedECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedECheck("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, 
    billing: new Sparrow.AdvancedECheckBilling{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929553
result.XRef;    // 3863651486
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929554
result.XRef;    // 3863651498
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929555
result.XRef;    // 3863651509
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 10929556
result.XRef;    // 3863651519
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


RESULT:

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


RESULT:

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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929557
result.XRef;    // 3863651550
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


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929558
resultSimpleSale.XRef;    // 3863651589
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Testing for Success
result.TransId;    // 10929558
result.XRef;    // 3863651589
result.AuthCode;    // 123456
result.Type;    // chargeback
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-credit/simple-credit.md: SimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleCredit("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929559
result.XRef;    // 3863651615
result.Type;    // credit
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/advanced-sale.md: AdvancedSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929560
result.XRef;    // 3863651649
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929561
result.XRef;    // 3863651668
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


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'H23P4BF41SRQHYJA' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // H23P4BF41SRQHYJA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'H23P4BF41SRQHYJA' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // H23P4BF41SRQHYJA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/adding-a-customer.md: AddCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'SITXRX6K7I6TU1XD' successfully created
result.Type;    // addcustomer
result.CustomerToken;    // SITXRX6K7I6TU1XD
result.PaymentTokens[0];    // SYZDC2JPKUIAP3NK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-customer.md: DeleteDataVaultCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.DeleteDataVaultCustomer(resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '8OZFFEHGS6J04FUK' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 8OZFFEHGS6J04FUK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

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


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'JYWL6RPNJ5JRB9KX' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // JYWL6RPNJ5JRB9KX
resultAddCustomer.PaymentTokens[0];    // TMTJ73X652A1UQ1E
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'JYWL6RPNJ5JRB9KX' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // JYWL6RPNJ5JRB9KX
resultAddCustomer.PaymentTokens[0];    // TMTJ73X652A1UQ1E
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'JYWL6RPNJ5JRB9KX' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // JYWL6RPNJ5JRB9KX
result.PaymentTokens[0];    // TMTJ73X652A1UQ1E
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-customer.md: RetrieveCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.RetrieveCustomer(resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '9HPNURN0NQG91Y21' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 9HPNURN0NQG91Y21
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // 9HPNURN0NQG91Y21
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


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'H375F9CQB0QDRX33' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // H375F9CQB0QDRX33
resultAddCustomer.PaymentTokens[0];    // DFR3T6CB826RWXEG
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // H375F9CQB0QDRX33
result.PayType;    // CreditCard
result.PayNo;    // 1
result.CardExp;    // 1019
result.Account;    // 411111******1111
result.Token;    // DFR3T6CB826RWXEG
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-type.md: UpdateCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var result = await _sparrow.UpdateCustomer(resultAddCustomer.CustomerToken, 
    billing: new Sparrow.UpdateCustomerBilling{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '9IU0S599F9M4BJJZ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 9IU0S599F9M4BJJZ
resultAddCustomer.PaymentTokens[0];    // WN5WG9HL156MDV4N
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '9IU0S599F9M4BJJZ' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 9IU0S599F9M4BJJZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-types.md: UpdatePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe", 
    payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
var result = await _sparrow.UpdatePaymentType(resultAddCustomer.CustomerToken, 
    payments: new []{ new Sparrow.UpdatePaymentTypePayment{ Token = resultAddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'VJEIDDKIFSYUTIAZ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // VJEIDDKIFSYUTIAZ
resultAddCustomer.PaymentTokens[0];    // TG4I2SAAAJ8X8X6T
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'VJEIDDKIFSYUTIAZ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // VJEIDDKIFSYUTIAZ
resultAddCustomer.PaymentTokens[0];    // TG4I2SAAAJ8X8X6T
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'VJEIDDKIFSYUTIAZ' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // VJEIDDKIFSYUTIAZ
result.PaymentTokens[0];    // TG4I2SAAAJ8X8X6T
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### decrypt-custom-field/decrypt.md: DecryptCustomFields (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer("John", "Doe");
var result = await _sparrow.DecryptCustomFields("customField1", resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'E9J1FAWTDXQYKX1T' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // E9J1FAWTDXQYKX1T
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 3
result.TextResponse;    // Custom field 'customField1' not found.
result.CustomerToken;    // E9J1FAWTDXQYKX1T
result.Token;    // E9J1FAWTDXQYKX1T
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ewallet/ewallet-credit.md: EWalletSimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.EWalletSimpleCredit("user@example.com", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Successful
result.TransId;    // 10929562
result.XRef;    // 8JFJATZEYXV4G
result.Type;    // credit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-advanced.md: AdvancedFiservSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedFiservSale("4111111111111111", "1019", 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929563
result.XRef;    // 3863651823
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929564
result.XRef;    // 3863651857
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


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39530
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39530
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-invoice.md: CancelInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.CancelInvoice(resultCreateInvoice.InvoiceNumber, "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39531
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39531
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/create-merchant-invoice.md: CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully created
result.InvoiceNumber;    // Inv-39532
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/get-invoice.md: RetrieveInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.RetrieveInvoice(resultCreateInvoice.InvoiceNumber);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39533
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Success
result.InvoiceNumber;    // Inv-39533
result.InvoiceAmount;    // 10.0000
result.Currency;    // USD
result.InvoiceDate;    // 12/01/2017
result.InvoiceStatus;    // Active
result.InvoicePaymentLink;    // https://secure.sparrowone.com/Payments/Payment.aspx?token=1DB1C4F494D9B343
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-ach.md: PayInvoiceWithBankAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.PayInvoiceWithBankAccount(resultCreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal", 
    billing: new Sparrow.PayInvoiceWithBankAccountBilling{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39534
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 10929565
result.InvoiceNumber;    // Inv-39534
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-cc.md: PayInvoiceWithCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
var result = await _sparrow.PayInvoiceWithCreditCard(resultCreateInvoice.InvoiceNumber, "4111111111111111", "1019");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39535
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 10929567
result.InvoiceNumber;    // Inv-39535
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/update-invoice.md: UpdateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
var result = await _sparrow.UpdateInvoice(resultCreateInvoice.InvoiceNumber, 
    options: new Sparrow.UpdateInvoiceOptions{ InvoiceStatus = "active" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39536
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully updated
result.InvoiceNumber;    // Inv-39536
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/Simple-refund.md: SimpleRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.SimpleRefund(resultSimpleSale.TransId, 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929568
resultSimpleSale.XRef;    // 3863651984
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929568
result.XRef;    // 3863651984
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


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929569
resultSimpleSale.XRef;    // 3863652029
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 300
result.Response;    // 3
result.TextResponse;    // Flagged for Review by Velocity and Duplicates Policy (Duplicate Transactions Rule). Original Transaction ID: 10929568
result.TransId;    // 10929569
result.XRef;    // 3863652029
result.AuthCode;    // 123456
result.Type;    // refund
result.OrigTransId;    // 10929568
result.OrigResponse;    // 1
result.OrigTextResponse;    // SUCCESS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/advanced-void.md: AdvancedVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
var result = await _sparrow.AdvancedVoid(resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929570
resultSimpleSale.XRef;    // 3863652062
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Transaction Void Successful
result.TransId;    // 10929570
result.XRef;    // 3863652062
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


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 10929571
resultSimpleSale.XRef;    // 3863652140
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Transaction Void Successful
result.TransId;    // 10929571
result.XRef;    // 3863652140
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


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'UI6Q8MW08EGCL7WF' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // UI6Q8MW08EGCL7WF
resultAddCustomer.PaymentTokens[0];    // 08DNXLUVZPSTLSVZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'UI6Q8MW08EGCL7WF' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // UI6Q8MW08EGCL7WF
resultAddCustomer.PaymentTokens[0];    // 08DNXLUVZPSTLSVZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 11QSOLXZSFJQHGIB
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // assignplan
result.AssignmentToken;    // LWN7F41IYK0T4DOQ
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


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // 036Z6ZVH58V19JFT
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'TRKTQD1OLO4RCEOT' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // TRKTQD1OLO4RCEOT
resultAddCustomer.PaymentTokens[0];    // GQHYEXT7AI4DVE4O
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'TRKTQD1OLO4RCEOT' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // TRKTQD1OLO4RCEOT
resultAddCustomer.PaymentTokens[0];    // GQHYEXT7AI4DVE4O
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 4H260VVCJDI4EWJS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // addplan
result.PlanToken;    // 6GMO6ZL57MTIJX3H
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/delete-plan.md: DeletePlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
var result = await _sparrow.DeletePlan(resultCreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // VEPU8ITSULFEBLZN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

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


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // O4MY4SYVL6G20R02
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'RP21493TOGRB22OQ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // RP21493TOGRB22OQ
resultAddCustomer.PaymentTokens[0];    // O7CGHGUVYJMPPQA7
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'RP21493TOGRB22OQ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // RP21493TOGRB22OQ
resultAddCustomer.PaymentTokens[0];    // O7CGHGUVYJMPPQA7
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // TP1IHYWR4A3GB170
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // updateassignment
result.AssignmentToken;    // O4MY4SYVL6G20R02
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan.md: UpdatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
    sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 10.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.UpdatePaymentPlan(resultCreatePaymentPlan.PlanToken, 
    sequences: new []{ new Sparrow.AddOrUpdateSequenceSequence{ OperationType = "updatesequence", Sequence = 1, Amount = 20.00m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 6Y0EJTGL5GCUXNE8
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929572
result.XRef;    // 3863652253
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


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleAuthorization.Status;    // 200
resultSimpleAuthorization.Response;    // 1
resultSimpleAuthorization.TextResponse;    // SUCCESS
resultSimpleAuthorization.TransId;    // 10929573
resultSimpleAuthorization.XRef;    // 3863652281
resultSimpleAuthorization.AuthCode;    // 123456
resultSimpleAuthorization.Type;    // auth
resultSimpleAuthorization.CodeResponse;    // 100
resultSimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929573
result.XRef;    // 3863652281
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929574
result.XRef;    // 3863652349
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


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleAuthorization.Status;    // 200
resultSimpleAuthorization.Response;    // 1
resultSimpleAuthorization.TextResponse;    // SUCCESS
resultSimpleAuthorization.TransId;    // 10929575
resultSimpleAuthorization.XRef;    // 3863652364
resultSimpleAuthorization.AuthCode;    // 123456
resultSimpleAuthorization.Type;    // auth
resultSimpleAuthorization.CodeResponse;    // 100
resultSimpleAuthorization.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 10929575
result.XRef;    // 3863652364
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


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 10929577
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/simple-starcard.md: SimpleStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleStarCard("4111111111111111", 9.99m, "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 10929578
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


