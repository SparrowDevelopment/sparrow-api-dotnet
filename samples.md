
### ach/advanced-echeck-sale.md: AdvancedECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedECheck(
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11032418
result.XRef;    // 3876731357
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/advanced-sale.md: AdvancedACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedACH(
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11032419
result.XRef;    // 3876731375
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-ach.md: SimpleACH


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleACH(
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11032420
result.XRef;    // 3876731380
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### ach/simple-echeck.md: SimpleECheck


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleECheck(
    bankAccount: new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, 
    amount: 9.99m, 
    contactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe", Company = "Sparrow One", Address = new Sparrow.Address{ Address1 = "16100 N 71st Street", City = "Scottsdale", State = "AZ", Zip = "85254", Country = "US" } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.TextResponse;    // SUCCESS
result.TransId;    // 11032421
result.XRef;    // 3876731391
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### airline-passenger-sale/passenger-sale.md: PassengerSale (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.PassengerSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m, 
    passengerName: "John Doe", 
    airportCodes: new []{ "" }, 
    airlineCodeNumber: "AA0", 
    ticketNumber: "1234567890", 
    flightDateCoupons: new []{ new DateTime(2019,10,21) }, 
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
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032422
result.XRef;    // 3876731403
result.AuthCode;    // 123456
result.Type;    // auth
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### chargeback/mark-chargeback.md: MarkSuccessfulTransactionAsChargeback


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
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
resultSimpleSale.TransId;    // 11032423
resultSimpleSale.XRef;    // 3876731424
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
result.TransId;    // 11032423
result.XRef;    // 3876731424
result.AuthCode;    // 123456
result.Type;    // chargeback
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-credit/simple-credit.md: SimpleCredit


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleCredit(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032424
result.XRef;    // 3876731452
result.Type;    // credit
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/advanced-sale.md: AdvancedSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032425
result.XRef;    // 3876731470
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### creating-a-sale/simple-sale.md: SimpleSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032426
result.XRef;    // 3876731523
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
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.AddPaymentTypesToCustomer(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToAdd: new []{ new Sparrow.PaymentTypeToAdd{ PaymentType = new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, BankAccount = new Sparrow.BankAccount{ BankName = "First Test Bank", Routing = "110000000", Account = "1234567890123", AchAccountType = Sparrow.AchAccountType.Checking, AchAccountSubType = Sparrow.AchAccountSubType.Personal }, Ewallet = new Sparrow.Ewallet{ EwalletAccount = "user@example.com" } } } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '645GRTD1SIXLJ5U5' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 645GRTD1SIXLJ5U5
resultAddCustomer.PaymentTokens[0];    // QEU8KSUON36XUWLI
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '645GRTD1SIXLJ5U5' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 645GRTD1SIXLJ5U5
result.PaymentTokens[0];    // 76XRTBDSCGBYBGAA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/adding-a-customer.md: AddCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'MDQE3APBQWNPLB0N' successfully created
result.Type;    // addcustomer
result.CustomerToken;    // MDQE3APBQWNPLB0N
result.PaymentTokens[0];    // L5UM9ALNJR2XWQH5
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/delete-customer.md: DeleteDataVaultCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.DeleteDataVaultCustomer(
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'BY7F1K0J4252GRGD' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // BY7F1K0J4252GRGD
resultAddCustomer.PaymentTokens[0];    // UBY9KEP6DXUOUOFX
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
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.DeletePaymentType(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToDelete: new []{ new Sparrow.PaymentTypeToDelete{ Token = resultAddCustomer.PaymentTokens[0] } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'YKFAA8JWGNX0GLLV' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // YKFAA8JWGNX0GLLV
resultAddCustomer.PaymentTokens[0];    // A7E9RB07JBCD0MYP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'YKFAA8JWGNX0GLLV' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // YKFAA8JWGNX0GLLV
result.PaymentTokens[0];    // A7E9RB07JBCD0MYP
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-customer.md: RetrieveCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.RetrieveCustomer(
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'XIE6MFCW2C26RYZ1' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // XIE6MFCW2C26RYZ1
resultAddCustomer.PaymentTokens[0];    // M9NWKGFXTI195F54
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // XIE6MFCW2C26RYZ1
result.FirstName;    // John
result.LastName;    // Doe
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/get-payment-type.md: RetrievePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.RetrievePaymentType(
    token: resultAddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'YHD8GOI55SHOJ4PU' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // YHD8GOI55SHOJ4PU
resultAddCustomer.PaymentTokens[0];    // LK118CERCRMEND0W
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Processed
result.CustomerToken;    // YHD8GOI55SHOJ4PU
result.FirstName;    // John
result.LastName;    // Doe
result.PayType;    // CreditCard
result.PayNo;    // 1
result.CardExp;    // 1019
result.Account;    // 411111******1111
result.Token;    // LK118CERCRMEND0W
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-type.md: UpdateCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.UpdateCustomer(
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'G7HJV1U70S1290OZ' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // G7HJV1U70S1290OZ
resultAddCustomer.PaymentTokens[0];    // 2HXUOE6WDW6ZBER2
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token 'G7HJV1U70S1290OZ' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // G7HJV1U70S1290OZ
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### datavault/update-payment-types.md: UpdatePaymentType


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.UpdatePaymentType(
    token: resultAddCustomer.CustomerToken, 
    paymentTypeToUpdate: new []{ new Sparrow.PaymentTypeToUpdate{ Token = resultAddCustomer.PaymentTokens[0], PaymentType = new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '1UILWG9UZ3AQKMRL' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 1UILWG9UZ3AQKMRL
resultAddCustomer.PaymentTokens[0];    // DWLGPFIBBUG8555V
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Customer with token '1UILWG9UZ3AQKMRL' successfully updated
result.Type;    // updatecustomer
result.CustomerToken;    // 1UILWG9UZ3AQKMRL
result.PaymentTokens[0];    // DWLGPFIBBUG8555V
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### decrypt-custom-field/decrypt.md: DecryptCustomFields (FAIL)


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var result = await _sparrow.DecryptCustomFields(
    fieldName: "customField1", 
    token: resultAddCustomer.CustomerToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'B9AOSCDWHD5UDQM0' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // B9AOSCDWHD5UDQM0
resultAddCustomer.PaymentTokens[0];    // EUWP2KMWLGJB9AZ4
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 3
result.TextResponse;    // Custom field 'customField1' not found.
result.CustomerToken;    // B9AOSCDWHD5UDQM0
result.Token;    // B9AOSCDWHD5UDQM0
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
result.TransId;    // 11032427
result.XRef;    // A2M3983N76ZKS
result.Type;    // credit
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### fiserv/fiserv-advanced.md: AdvancedFiservSale


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.AdvancedFiservSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032428
result.XRef;    // 3876731622
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
    cardExp: new DateTime(2019,10,21), 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032429
result.XRef;    // 3876731632
result.AuthCode;    // 123456
result.Type;    // sale
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-inv-customer.md: CancelInvoiceByCustomer


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
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
resultCreateInvoice.InvoiceNumber;    // Inv-39704
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39704
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/cancel-invoice.md: CancelInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
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
resultCreateInvoice.InvoiceNumber;    // Inv-39705
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully canceled
result.InvoiceNumber;    // Inv-39705
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/create-merchant-invoice.md: CreateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // invoice has been successfully created
result.InvoiceNumber;    // Inv-39706
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/get-invoice.md: RetrieveInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.RetrieveInvoice(
    invoiceNumber: resultCreateInvoice.InvoiceNumber);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39707
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Success
result.InvoiceNumber;    // Inv-39707
result.InvoiceAmount;    // 10.0000
result.Currency;    // USD
result.InvoiceDate;    // 10/21/2019
result.InvoiceStatus;    // Active
result.InvoicePaymentLink;    // https://secure.sparrowone.com/Payments/Payment.aspx?token=D5A731D92F086B1C
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-ach.md: PayInvoiceWithBankAccount


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
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
resultCreateInvoice.InvoiceNumber;    // Inv-39708
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 11032430
result.InvoiceNumber;    // Inv-39708
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/pay-inv-cc.md: PayInvoiceWithCreditCard


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
    currency: "USD", 
    invoiceStatus: Sparrow.InvoiceStatus.Active, 
    invoiceAmount: 10.00m);
var result = await _sparrow.PayInvoiceWithCreditCard(
    invoiceNumber: resultCreateInvoice.InvoiceNumber, 
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreateInvoice:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreateInvoice.TextResponse;    // invoice has been successfully created
resultCreateInvoice.InvoiceNumber;    // Inv-39709
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully paid
result.TransId;    // 11032431
result.InvoiceNumber;    // Inv-39709
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### invoicing/update-invoice.md: UpdateInvoice


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreateInvoice = await _sparrow.CreateInvoice(
    invoiceDate: new DateTime(2019,10,21), 
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
resultCreateInvoice.InvoiceNumber;    // Inv-39710
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.TextResponse;    // Invoice has been successfully updated
result.InvoiceNumber;    // Inv-39710
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/Simple-refund.md: SimpleRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
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
resultSimpleSale.TransId;    // 11032432
resultSimpleSale.XRef;    // 3876731707
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
result.TransId;    // 11032432
result.XRef;    // 3876731707
result.AuthCode;    // 123456
result.Type;    // refund
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-refund/advanced-refund.md: AdvancedRefund


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
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
resultSimpleSale.TransId;    // 11032433
resultSimpleSale.XRef;    // 3876731759
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
result.TransId;    // 11032433
result.XRef;    // 3876731759
result.AuthCode;    // 123456
result.Type;    // refund
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/advanced-void.md: AdvancedVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
var result = await _sparrow.AdvancedVoid(
    transId: resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11032435
resultSimpleSale.XRef;    // 3876731796
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
result.TransId;    // 11032435
result.XRef;    // 3876731796
result.AuthCode;    // 123456
result.Type;    // void
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### issuing-a-void/simple-void.md: SimpleVoid


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleSale = await _sparrow.SimpleSale(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
var result = await _sparrow.SimpleVoid(
    transId: resultSimpleSale.TransId);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT SimpleSale:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultSimpleSale.Status;    // 200
resultSimpleSale.Response;    // 1
resultSimpleSale.TextResponse;    // SUCCESS
resultSimpleSale.TransId;    // 11032436
resultSimpleSale.XRef;    // 3876731838
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
result.TransId;    // 11032436
result.XRef;    // 3876731838
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
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: new DateTime(2019,10,21), 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token '7P8FPQCQYSSYEFCL' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // 7P8FPQCQYSSYEFCL
resultAddCustomer.PaymentTokens[0];    // DTLYC9IM2C4MH1PA
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 7OOKMD2ATZ8MKX8V
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // assignplan
result.AssignmentToken;    // OSS6DU853EXQSWID
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/cancel-plan-assignment.md: CancelPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: new DateTime(2019,10,21), 
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
resultAssignPaymentPlanToCustomer.AssignmentToken;    // IY3TGPWQVYX89QHS
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'IP3KIQ30XODM2BWH' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // IP3KIQ30XODM2BWH
resultAddCustomer.PaymentTokens[0];    // OAXYBBOB2W5DLALY
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // PRUDES37GWNMVZI6
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
    startDate: new DateTime(2019,10,21), 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // addplan
result.PlanToken;    // C17KAJUGB2SWV0OW
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/delete-plan.md: DeletePlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: new DateTime(2019,10,21), 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.DeletePlan(
    token: resultCreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // DRJWXFITUP47M13F
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // deleteplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~




### payment-plans/delete-sequence.md: DeleteSequence


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: new DateTime(2019,10,21), 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var result = await _sparrow.DeleteSequence(
    deleteSequenceSteps: new []{ new Sparrow.SequenceStepToDelete{ Sequence = 1 } }, 
    token: resultCreatePaymentPlan.PlanToken);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // X16TGWE4V6Z5X90W
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.Type;    // updateplan
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan-assignment.md: UpdatePaymentPlanAssignment


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultAddCustomer = await _sparrow.AddCustomer(
    defaultContactInfo: new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, 
    paymentType: new []{ new Sparrow.PaymentType{ PayType = Sparrow.PayType.Creditcard, ContactInfo = new Sparrow.ContactInfo{ FirstName = "John", LastName = "Doe" }, CreditCard = new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) } } });
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: new DateTime(2019,10,21), 
    sequenceSteps: new []{ new Sparrow.SequenceStep{ Sequence = 1, Amount = 9.99m, ScheduleType = Sparrow.ScheduleType.Monthly, ScheduleDay = 5, Duration = 12 } });
var resultAssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(
    customerToken: resultAddCustomer.CustomerToken, 
    planToken: resultCreatePaymentPlan.PlanToken, 
    paymentToken: resultAddCustomer.PaymentTokens[0]);
var result = await _sparrow.UpdatePaymentPlanAssignment(
    assignmentToken: resultAssignPaymentPlanToCustomer.AssignmentToken, 
    startDate: new DateTime(2019,10,21));
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AssignPaymentPlanToCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAssignPaymentPlanToCustomer.Response;    // 1
resultAssignPaymentPlanToCustomer.TextResponse;    // Success
resultAssignPaymentPlanToCustomer.Type;    // assignplan
resultAssignPaymentPlanToCustomer.AssignmentToken;    // KB5UMCK91864GH2W
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT AddCustomer:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultAddCustomer.Response;    // 1
resultAddCustomer.TextResponse;    // Customer with token 'CPEEHDA9OGDMOPBL' successfully created
resultAddCustomer.Type;    // addcustomer
resultAddCustomer.CustomerToken;    // CPEEHDA9OGDMOPBL
resultAddCustomer.PaymentTokens[0];    // ONAUCBX8EXRO6A55
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT CreatePaymentPlan:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
resultCreatePaymentPlan.Response;    // 1
resultCreatePaymentPlan.TextResponse;    // SUCCESS
resultCreatePaymentPlan.Type;    // addplan
resultCreatePaymentPlan.PlanToken;    // 4170HM56ZU0RGVJD
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Response;    // 1
result.TextResponse;    // Success
result.Type;    // updateassignment
result.AssignmentToken;    // KB5UMCK91864GH2W
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### payment-plans/update-plan.md: UpdatePaymentPlan


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultCreatePaymentPlan = await _sparrow.CreatePaymentPlan(
    planName: "PaymentPlan1", 
    planDesc: "1st Payment Plan", 
    startDate: new DateTime(2019,10,21), 
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
resultCreatePaymentPlan.PlanToken;    // 0GHHZ4TB1FAUVVCN
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
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m, 
    authCode: "123456", 
    authDate: new DateTime(2019,10,21));
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032437
result.XRef;    // 3876731902
result.AuthCode;    // 123456
result.Type;    // offline
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/advanced-capture.md: AdvancedCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
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
resultSimpleAuthorization.TransId;    // 11032438
resultSimpleAuthorization.XRef;    // 3876731911
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
result.TransId;    // 11032438
result.XRef;    // 3876731911
result.AuthCode;    // 123456
result.Type;    // capture
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-auth.md: SimpleAuthorization


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var result = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
    amount: 9.99m);
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 200
result.Response;    // 1
result.TextResponse;    // SUCCESS
result.TransId;    // 11032439
result.XRef;    // 3876731939
result.AuthCode;    // 123456
result.Type;    // auth
result.CodeResponse;    // 100
result.CodeDescription;    // Transaction was Approved
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



### separate-auth-capture/simple-capture.md: SimpleCapture


CODE: 

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
var resultSimpleAuthorization = await _sparrow.SimpleAuthorization(
    creditCard: new Sparrow.CreditCard{ CardNum = "4111111111111111", CardExp = new DateTime(2019,10,21) }, 
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
resultSimpleAuthorization.TransId;    // 11032440
resultSimpleAuthorization.XRef;    // 3876731948
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
result.TransId;    // 11032440
result.XRef;    // 3876731948
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
    cardExp: new DateTime(2019,10,21), 
    amount: 9.99m, 
    CID: "12345678901");
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


RESULT:

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
result.Status;    // 400
result.TextResponse;    // System Error: Reason Code: 002 CID value is invalid or non existant
result.TransId;    // 11032441
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
result.TransId;    // 11032442
result.Type;    // sale
result.CodeDescription;    // Denied
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


