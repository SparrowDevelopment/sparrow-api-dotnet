
### ach/advanced-echeck-sale.md: AdvancedECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedECheck(
    transType: Sparrow.TransType_SaleRefundCredit.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11031601
result.XRef;    // 3876601345
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/advanced-sale.md: AdvancedACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedACH(
    transType: Sparrow.TransType_SaleRefundCredit.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11031603
result.XRef;    // 3876601362
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-ach.md: SimpleACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleACH(
    transType: Sparrow.TransType_SaleRefundCredit.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11031604
result.XRef;    // 3876601374
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-echeck.md: SimpleECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleECheck(
    transType: Sparrow.TransType_SaleRefund.Sale, 
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11031605
result.XRef;    // 3876601387
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### airline-passenger-sale/passenger-sale.md: PassengerSale (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.PassengerSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m, 
    passengerName: "John Doe", 
    airportCodes: new []{ "" }, 
    airlineCodeNumber: "AA0", 
    ticketNumber: "1234567890", 
    flightDateCoupons: new []{ "" }, 
    flightDepartureTimeCoupons: new []{ "" }, 
    approvalCode: "123456", 
    authCharIndicator: Sparrow.AuthCharIndicator.A, 
    validationCode: "1234", 
    authResponseCode: "AB");
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
var result = await _sparrow.RetrieveCardBalance(
    cardNum: "4111111111111111");
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
var result = await _sparrow.VerifyAccount(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031606
result.XRef;    // 3876601412
result.AuthCode;    // 123456
result.Type;    // auth
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### chargeback/mark-chargeback.md: MarkSuccessfulTransactionAsChargeback


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.MarkSuccessfulTransactionAsChargeback(
    transId: resultSimpleSale.TransId, 
    reason: "Testing for Success");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11031607
resultSimpleSale.XRef;    // 3876601428
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
result.TransId;    // 11031607
result.XRef;    // 3876601428
result.AuthCode;    // 123456
result.Type;    // chargeback
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-credit/simple-credit.md: SimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleCredit(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031608
result.XRef;    // 3876601469
result.Type;    // credit
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/advanced-sale.md: AdvancedSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031610
result.XRef;    // 3876601495
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/simple-sale.md: SimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031611
result.XRef;    // 3876601514
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/add-payment-type.md: AddPaymentTypesToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var result = await _sparrow.AddPaymentTypesToCustomer(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToAdd: new []{ new Sparrow.PaymentTypeToAdd{ PaymentType = new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'LI4QQ2EUJUJ44EQL' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // LI4QQ2EUJUJ44EQL
resultAddCustomer.PaymentTokens[0];    // 4J4X60DT4DYL6K0N
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'LI4QQ2EUJUJ44EQL' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // LI4QQ2EUJUJ44EQL
result.PaymentTokens[0];    // VYIOUE6G8E4BVQPH
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/adding-a-customer.md: AddCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'HC3WAIZ4A15LA6M0' successfully created
result.Type;    // addcustomer
result.CustomerToken;    // HC3WAIZ4A15LA6M0
result.PaymentTokens[0];    // 1MCDE3PUFKWMD2Y8
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-customer.md: DeleteDataVaultCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
var result = await _sparrow.DeleteDataVaultCustomer(
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'J770MPNZVV6EZMUK' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // J770MPNZVV6EZMUK
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
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var result = await _sparrow.DeletePaymentType(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToDelete: new []{ new Sparrow.PaymentTypeToDelete{ Token = resultAddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '35X2L3KWT9XE51T8' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 35X2L3KWT9XE51T8
resultAddCustomer.PaymentTokens[0];    // 07UUHXJNWIRZVM1H
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '35X2L3KWT9XE51T8' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 35X2L3KWT9XE51T8
result.PaymentTokens[0];    // 07UUHXJNWIRZVM1H
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-customer.md: RetrieveCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
var result = await _sparrow.RetrieveCustomer(
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'D6REJTP7CQUEGLZN' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // D6REJTP7CQUEGLZN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // D6REJTP7CQUEGLZN
result.FirstName;    // John
result.LastName;    // Doe
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-payment-type.md: RetrievePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var result = await _sparrow.RetrievePaymentType(
    token: resultAddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '1YWFID0GWJGCMUAG' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 1YWFID0GWJGCMUAG
resultAddCustomer.PaymentTokens[0];    // IPB9JPYGSWS0DEHK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // 1YWFID0GWJGCMUAG
result.PayType;    // CreditCard
result.PayNo;    // 1
result.CardExp;    // 1019
result.Account;    // 411111******1111
result.Token;    // IPB9JPYGSWS0DEHK
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-type.md: UpdateCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var result = await _sparrow.UpdateCustomer(
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '9BDIP5R0EYRBANFO' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 9BDIP5R0EYRBANFO
resultAddCustomer.PaymentTokens[0];    // MGJEWW6GKT38I1QW
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '9BDIP5R0EYRBANFO' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 9BDIP5R0EYRBANFO
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-types.md: UpdatePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var result = await _sparrow.UpdatePaymentType(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToUpdate: new []{ new Sparrow.PaymentTypeToUpdate{ Token = resultAddCustomer.PaymentTokens[0], PaymentType = new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'UUCUMH2OQGWX7MYH' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // UUCUMH2OQGWX7MYH
resultAddCustomer.PaymentTokens[0];    // PR2SDPXME775CSSN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'UUCUMH2OQGWX7MYH' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // UUCUMH2OQGWX7MYH
result.PaymentTokens[0];    // PR2SDPXME775CSSN
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### decrypt-custom-field/decrypt.md: DecryptCustomFields (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
var result = await _sparrow.DecryptCustomFields(
    fieldName: "customField1", 
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'H5QQLVBEO5XQAII8' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // H5QQLVBEO5XQAII8
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 3
result.TextResponse;    // Custom field 'customField1' not found.
result.CustomerToken;    // H5QQLVBEO5XQAII8
result.Token;    // H5QQLVBEO5XQAII8
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ewallet/ewallet-credit.md: EWalletSimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.EWalletSimpleCredit(
    ewallet: new Sparrow.Ewallet{ EwalletAccount = "user@example.com" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // Successful
result.TransId;    // 11031614
result.XRef;    // TS447MF6ZHBWJ
result.Type;    // credit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-advanced.md: AdvancedFiservSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedFiservSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031617
result.XRef;    // 3876601688
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-simple.md: FiservSimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.FiservSimpleSale(
    cardNum: "4111111111111111", 
    cardExp: "1019", 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031618
result.XRef;    // 3876601714
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-inv-customer.md: CancelInvoiceByCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.CancelInvoiceByCustomer(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    invoiceStatusReason: "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39662
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39662
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-invoice.md: CancelInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.CancelInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    invoiceStatusReason: "Testing");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39663
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39663
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/create-merchant-invoice.md: CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully created
result.InvoiceNumber;    // Inv-39664
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/get-invoice.md: RetrieveInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.RetrieveInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39665
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Success
result.InvoiceNumber;    // Inv-39665
result.InvoiceAmount;    // 10.0000
result.Currency;    // USD
result.InvoiceDate;    // 12/01/2017
result.InvoiceStatus;    // Active
result.InvoicePaymentLink;    // https://secure.sparrowone.com/Payments/Payment.aspx?token=4A244274D8513C5D
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-ach.md: PayInvoiceWithBankAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.PayInvoiceWithBankAccount(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39666
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 11031620
result.InvoiceNumber;    // Inv-39666
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-cc.md: PayInvoiceWithCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.PayInvoiceWithCreditCard(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39667
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 11031621
result.InvoiceNumber;    // Inv-39667
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/update-invoice.md: UpdateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: "12/01/2017", 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Draft, 
    invoiceAmount: 10.00m);
var result = await _sparrow.UpdateInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    invoiceStatus: Sparrow.InvoiceStatus.Active);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39668
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully updated
result.InvoiceNumber;    // Inv-39668
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/Simple-refund.md: SimpleRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.SimpleRefund(
    transId: resultSimpleSale.TransId, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11031623
resultSimpleSale.XRef;    // 3876601810
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
result.TransId;    // 11031623
result.XRef;    // 3876601810
result.AuthCode;    // 123456
result.Type;    // refund
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/advanced-refund.md: AdvancedRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedRefund(
    transId: resultSimpleSale.TransId, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11031628
resultSimpleSale.XRef;    // 3876601934
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
result.TransId;    // 11031628
result.XRef;    // 3876601934
result.AuthCode;    // 123456
result.Type;    // refund
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/advanced-void.md: AdvancedVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedVoid(
    transId: resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11031630
resultSimpleSale.XRef;    // 3876601974
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
result.TransId;    // 11031630
result.XRef;    // 3876601974
result.AuthCode;    // 123456
result.Type;    // void
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/simple-void.md: SimpleVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.SimpleVoid(
    transId: resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11031631
resultSimpleSale.XRef;    // 3876602015
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
result.TransId;    // 11031631
result.XRef;    // 3876602015
result.AuthCode;    // 123456
result.Type;    // void
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/assign-payment-plan.md: AssignPaymentPlanToCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: "01/31/2017", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'IA7S3M5O7JJI6FPK' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // IA7S3M5O7JJI6FPK
resultAddCustomer.PaymentTokens[0];    // VSTVZNIV40J9DEZD
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 5VS088TF7ZPOJ6L8
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // assignplan
result.AssignmentToken;    // YXZ61LMZF519G264
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/cancel-plan-assignment.md: CancelPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: "01/31/2017", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.CancelPlanAssignment(
    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // TZ222FDXZXKJ4LN0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'YIQC5H54PYDH1HM5' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // YIQC5H54PYDH1HM5
resultAddCustomer.PaymentTokens[0];    // Z8AQ91PJLLTWFX4S
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // GYZO32P52MXCC5K3
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
var result = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: "01/31/2017", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // addplan
result.PlanToken;    // NUZK54863G0UYJZ2
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/delete-plan.md: DeletePlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: "01/31/2017", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.DeletePlan(
    token: resultCreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // TFUIQTTKG3P4VIOB
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
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: "01/01/2018", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.UpdatePaymentPlanAssignment(
    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken, 
    startDate: "02/02/2020");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // 3VXCOUCT5M0LRFPA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '4P2POKJ5I4DOXKWJ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 4P2POKJ5I4DOXKWJ
resultAddCustomer.PaymentTokens[0];    // V8QAIXNXFPIAMVJT
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 7WHXC4PI6YAWPEX6
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // updateassignment
result.AssignmentToken;    // 3VXCOUCT5M0LRFPA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan.md: UpdatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: "01/31/2017", 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 10.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.UpdatePaymentPlan(
    token: resultCreatePaymentPlan.PlanToken, 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 20.00m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12, OperationType = Sparrow.OperationType.Updatesequence } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 73IU7UXY168WPS9Q
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
var result = await _sparrow.SimpleOfflineCapture(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m, 
    authCode: "123456", 
    authDate: "01/31/2017");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031634
result.XRef;    // 3876602152
result.AuthCode;    // 123456
result.Type;    // offline
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/advanced-capture.md: AdvancedCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedCapture(
    transId: resultSimpleAuthorization.TransId, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleAuthorization.Status;    // 200
resultSimpleAuthorization.Response;    // 1
resultSimpleAuthorization.TextResponse;    // SUCCESS
resultSimpleAuthorization.TransId;    // 11031635
resultSimpleAuthorization.XRef;    // 3876602189
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
result.TransId;    // 11031635
result.XRef;    // 3876602189
result.AuthCode;    // 123456
result.Type;    // capture
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-auth.md: SimpleAuthorization


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11031636
result.XRef;    // 3876602251
result.AuthCode;    // 123456
result.Type;    // auth
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-capture.md: SimpleCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = "1019" }, 
    amount: 9.99m);
var result = await _sparrow.SimpleCapture(
    transId: resultSimpleAuthorization.TransId, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleAuthorization:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleAuthorization.Status;    // 200
resultSimpleAuthorization.Response;    // 1
resultSimpleAuthorization.TextResponse;    // SUCCESS
resultSimpleAuthorization.TransId;    // 11031638
resultSimpleAuthorization.XRef;    // 3876602292
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
result.TransId;    // 11031638
result.XRef;    // 3876602292
result.AuthCode;    // 123456
result.Type;    // capture
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/advanced-starcard.md: AdvancedStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedStarCard(
    cardNum: "4111111111111111", 
    cardExp: "1019", 
    amount: 9.99m, 
    CID: "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 11031641
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### starcard/simple-starcard.md: SimpleStarCard (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleStarCard(
    cardNum: "4111111111111111", 
    amount: 9.99m, 
    CID: "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 11031643
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


