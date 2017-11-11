
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
result.TransId;    // 10929640
result.XRef;    // 3863662162
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
result.TransId;    // 10929642
result.XRef;    // 3863662194
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
result.TransId;    // 10929643
result.XRef;    // 3863662205
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
result.TransId;    // 10929644
result.XRef;    // 3863662219
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
result.TransId;    // 10929645
result.XRef;    // 3863662241
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
resultSimpleSale.TransId;    // 10929646
resultSimpleSale.XRef;    // 3863662272
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
result.TransId;    // 10929646
result.XRef;    // 3863662272
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
result.TransId;    // 10929648
result.XRef;    // 3863662314
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
result.TransId;    // 10929649
result.XRef;    // 3863662335
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
result.TransId;    // 10929650
result.XRef;    // 3863662359
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
resultAddCustomer.TextResponse;    // Customer with token 'HIWH5W1R03MGBKJ8' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // HIWH5W1R03MGBKJ8
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'HIWH5W1R03MGBKJ8' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // HIWH5W1R03MGBKJ8
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
result.TextResponse;    // Customer with token 'J8GI7EL527SDUQ66' successfully created
result.Type;    // addcustomer
result.CustomerToken;    // J8GI7EL527SDUQ66
result.PaymentTokens[0];    // TBSOO0AEEKP9VXZH
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
resultAddCustomer.TextResponse;    // Customer with token 'VLJSR1HEHW4Y05F4' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // VLJSR1HEHW4Y05F4
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
resultAddCustomer.TextResponse;    // Customer with token 'HQUJ3D1R3AHHJ0FF' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // HQUJ3D1R3AHHJ0FF
resultAddCustomer.PaymentTokens[0];    // PEI47OHNNQE9RLBU
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'HQUJ3D1R3AHHJ0FF' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // HQUJ3D1R3AHHJ0FF
result.PaymentTokens[0];    // PEI47OHNNQE9RLBU
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
resultAddCustomer.TextResponse;    // Customer with token 'FFRQ237ST2YQUA5Q' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // FFRQ237ST2YQUA5Q
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // FFRQ237ST2YQUA5Q
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
resultAddCustomer.TextResponse;    // Customer with token 'RYIWWK62IG5N829S' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // RYIWWK62IG5N829S
resultAddCustomer.PaymentTokens[0];    // 8WBDIZNVG0KE003M
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // RYIWWK62IG5N829S
result.PayType;    // CreditCard
result.PayNo;    // 1
result.CardExp;    // 1019
result.Account;    // 411111******1111
result.Token;    // 8WBDIZNVG0KE003M
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
resultAddCustomer.TextResponse;    // Customer with token 'UXR3CO84JYHW7UT0' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // UXR3CO84JYHW7UT0
resultAddCustomer.PaymentTokens[0];    // 2GS792I1LXP5A2CR
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'UXR3CO84JYHW7UT0' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // UXR3CO84JYHW7UT0
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
resultAddCustomer.TextResponse;    // Customer with token 'NT2LKGPTYG3UR0XV' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // NT2LKGPTYG3UR0XV
resultAddCustomer.PaymentTokens[0];    // HULTI5N1PZRP9C4R
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'NT2LKGPTYG3UR0XV' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // NT2LKGPTYG3UR0XV
result.PaymentTokens[0];    // HULTI5N1PZRP9C4R
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
resultAddCustomer.TextResponse;    // Customer with token 'WZJO2IPW18I29XKU' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // WZJO2IPW18I29XKU
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 3
result.TextResponse;    // Custom field 'customField1' not found.
result.CustomerToken;    // WZJO2IPW18I29XKU
result.Token;    // WZJO2IPW18I29XKU
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
result.TransId;    // 10929651
result.XRef;    // YBR4C6LBZKN88
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
result.TransId;    // 10929653
result.XRef;    // 3863662510
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
result.TransId;    // 10929654
result.XRef;    // 3863662536
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
resultCreateInvoice.InvoiceNumber;    // Inv-39537
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39537
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
resultCreateInvoice.InvoiceNumber;    // Inv-39538
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39538
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/create-merchant-invoice.md: CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully created
result.InvoiceNumber;    // Inv-39539
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
resultCreateInvoice.InvoiceNumber;    // Inv-39540
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Success
result.InvoiceNumber;    // Inv-39540
result.InvoiceAmount;    // 10.0000
result.Currency;    // USD
result.InvoiceDate;    // 12/01/2017
result.InvoiceStatus;    // Active
result.InvoicePaymentLink;    // https://secure.sparrowone.com/Payments/Payment.aspx?token=C8FC15465E31C9BC
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
resultCreateInvoice.InvoiceNumber;    // Inv-39541
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 10929655
result.InvoiceNumber;    // Inv-39541
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
resultCreateInvoice.InvoiceNumber;    // Inv-39542
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 10929656
result.InvoiceNumber;    // Inv-39542
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
resultCreateInvoice.InvoiceNumber;    // Inv-39543
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully updated
result.InvoiceNumber;    // Inv-39543
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
resultSimpleSale.TransId;    // 10929657
resultSimpleSale.XRef;    // 3863662663
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
result.TransId;    // 10929657
result.XRef;    // 3863662663
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
resultSimpleSale.TransId;    // 10929658
resultSimpleSale.XRef;    // 3863662716
resultSimpleSale.AuthCode;    // 123456
resultSimpleSale.Type;    // sale
resultSimpleSale.CodeResponse;    // 100
resultSimpleSale.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 300
result.Response;    // 3
result.TextResponse;    // Flagged for Review by Velocity and Duplicates Policy (Duplicate Transactions Rule). Original Transaction ID: 10929657
result.TransId;    // 10929658
result.XRef;    // 3863662716
result.AuthCode;    // 123456
result.Type;    // refund
result.OrigTransId;    // 10929657
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
resultSimpleSale.TransId;    // 10929659
resultSimpleSale.XRef;    // 3863662753
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
result.TransId;    // 10929659
result.XRef;    // 3863662753
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
resultSimpleSale.TransId;    // 10929660
resultSimpleSale.XRef;    // 3863662800
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
result.TransId;    // 10929660
result.XRef;    // 3863662800
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
resultAddCustomer.TextResponse;    // Customer with token 'HK4AHGWEROSYMBAQ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // HK4AHGWEROSYMBAQ
resultAddCustomer.PaymentTokens[0];    // OFCEA0PNA01IK7PU
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // P6QFOOADQ1J1N472
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // assignplan
result.AssignmentToken;    // PJ0335C03SRNM5G6
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
resultAssignPaymentPlanToCustomer.AssignmentToken;    // 2A7ADGB640FYCKNS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'NWRW0SC0AZL0084V' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // NWRW0SC0AZL0084V
resultAddCustomer.PaymentTokens[0];    // HDF1SPH7L4LZACVJ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // BXITKFER5Q9ROO4U
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
result.PlanToken;    // 7XTJZFJ7PTK6HMZ8
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
resultCreatePaymentPlan.PlanToken;    // 97ICKGXSCLLRICAF
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
resultAssignPaymentPlanToCustomer.AssignmentToken;    // P47THH5DX97BIKWQ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'T5HWY6KJFJ8M5VMO' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // T5HWY6KJFJ8M5VMO
resultAddCustomer.PaymentTokens[0];    // Y7NPWDV4AZR84WJ3
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // EB70B3RBCI72KT4B
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // updateassignment
result.AssignmentToken;    // P47THH5DX97BIKWQ
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
resultCreatePaymentPlan.PlanToken;    // 963KYVTPJMW8OLOS
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
result.TransId;    // 10929661
result.XRef;    // 3863662933
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
resultSimpleAuthorization.TransId;    // 10929662
resultSimpleAuthorization.XRef;    // 3863662961
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
result.TransId;    // 10929662
result.XRef;    // 3863662961
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
result.TransId;    // 10929663
result.XRef;    // 3863663014
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
resultSimpleAuthorization.TransId;    // 10929665
resultSimpleAuthorization.XRef;    // 3863663054
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
result.TransId;    // 10929665
result.XRef;    // 3863663054
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
result.TransId;    // 10929667
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
result.TransId;    // 10929668
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


