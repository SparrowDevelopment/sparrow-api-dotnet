"
        
### SimpleSale
    
```    
        
            var result = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AdvancedSale
    
```    
        
            var result = await _sparrow.AdvancedSale("4111111111111111", "1019", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleAuthorization
    
```    
        
            var result = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleCapture
    
```    
        
            var result_SimpleAuthorization = await _sparrow.SimpleAuthorization("4111111111111111", "1019", 9.99m);
            var result = await _sparrow.SimpleCapture(result_SimpleAuthorization.TransId, 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleOfflineCapture
    
```    
        
            var result = await _sparrow.SimpleOfflineCapture("4111111111111111", "1019", 9.99m, "123456", "01/31/2017");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleRefund
    
```    
        
            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow.SimpleRefund(result_SimpleSale.TransId, 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AdvancedRefund
    
```    
        
            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow.AdvancedRefund(result_SimpleSale.TransId, 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleVoid
    
```    
        
            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow.SimpleVoid(result_SimpleSale.TransId);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AdvancedVoid
    
```    
        
            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow.AdvancedVoid(result_SimpleSale.TransId);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### PassengerSale
    
```    
        
            var result = await _sparrow.PassengerSale("4111111111111111", "1019", 9.99m, "John Doe", "LAS", "AA0", "1234567890", "", "", "123456", "A", "1234", "AB");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleStarCard
    
```    
        
            var result = await _sparrow.SimpleStarCard("4111111111111111", 9.99m, "12345678901");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AdvancedStarCard
    
```    
        
            var result = await _sparrow.AdvancedStarCard("4111111111111111", "1019", 9.99m, "12345678901");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### SimpleACH
    
```    
        
            var result = await _sparrow.SimpleACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AdvancedACH
    
```    
        
            var result = await _sparrow.AdvancedACH("sale", "First Test Bank", "110000000", "1234567890123", "checking", "personal", 9.99m, "John", "Doe");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### EWalletSimpleCredit
    
```    
        
            var result = await _sparrow.EWalletSimpleCredit("user@example.com", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### FiservSimpleSale
    
```    
        
            var result = await _sparrow.FiservSimpleSale("4111111111111111", "1019", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AdvancedFiservSale
    
```    
        
            var result = await _sparrow.AdvancedFiservSale("4111111111111111", "1019", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### MarkSuccessfulTransactionAsChargeback
    
```    
        
            var result_SimpleSale = await _sparrow.SimpleSale("4111111111111111", "1019", 9.99m);
            var result = await _sparrow.MarkSuccessfulTransactionAsChargeback(result_SimpleSale.TransId, "Testing for Success");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### RetrieveCardBalance
    
```    
        
            var result = await _sparrow.RetrieveCardBalance("4111111111111111");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### DecryptCustomFields
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result = await _sparrow.DecryptCustomFields("customField1", result_AddCustomer.CustomerToken);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### VerifyAccount
    
```    
        
            var result = await _sparrow.VerifyAccount("4111111111111111", "1019", 9.99m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AddCustomer
    
```    
        
            var result = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AddCreditCard
    
```    
        
            var result = await _sparrow.AddCreditCard("John", "Doe");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AddACH
    
```    
        
            var result = await _sparrow.AddACH("John", "Doe", "First Test Bank", "110000000", "1234567890123");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AddStarCard
    
```    
        
            var result = await _sparrow.AddStarCard("John", "Doe", "12345678901");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AddEwallet
    
```    
        
            var result = await _sparrow.AddEwallet("John", "Doe");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### UpdateCustomer
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result = await _sparrow.UpdateCustomer(result_AddCustomer.CustomerToken);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### DeletePaymentType
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result = await _sparrow.DeletePaymentType(result_AddCustomer.CustomerToken, 
                payments: new []{ new Sparrow.DeletePaymentTypePayment{ Token = result_AddCustomer.PaymentTokens[0] } });

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### DeleteDataVaultCustomer
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe");
            var result = await _sparrow.DeleteDataVaultCustomer(result_AddCustomer.CustomerToken);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### CreatePaymentPlan
    
```    
        
            var result = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### UpdatePaymentPlan
    
```    
        
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow.UpdatePaymentPlan(result_CreatePaymentPlan.PlanToken);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### DeletePlan
    
```    
        
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017");
            var result = await _sparrow.DeletePlan(result_CreatePaymentPlan.PlanToken);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### AssignPaymentPlanToCustomer
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result = await _sparrow.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### UpdatePaymentPlanAssignment
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/01/2018", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result = await _sparrow.UpdatePaymentPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken, 
                options: new Sparrow.UpdatePaymentPlanAssignmentOptions{ StartDate = "02/02/2020" });

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### CancelPlanAssignment
    
```    
        
            var result_AddCustomer = await _sparrow.AddCustomer("John", "Doe", 
                payments: new []{ new Sparrow.AddCustomerPayment{ PayType = "creditcard", CardNum = "4111111111111111", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017", 
                sequences: new []{ new Sparrow.BuildSequenceSequence{ Sequence = 1, Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = 5, Duration = 12 } });
            var result_AssignPaymentPlanToCustomer = await _sparrow.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);
            var result = await _sparrow.CancelPlanAssignment(result_AssignPaymentPlanToCustomer.AssignmentToken);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### CreateInvoice
    
```    
        
            var result = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### UpdateInvoice
    
```    
        
            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "draft", 10.00m);
            var result = await _sparrow.UpdateInvoice(result_CreateInvoice.InvoiceNumber, 
                options: new Sparrow.UpdateInvoiceOptions{ InvoiceStatus = "active" });

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### RetrieveInvoice
    
```    
        
            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow.RetrieveInvoice(result_CreateInvoice.InvoiceNumber);

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### CancelInvoice
    
```    
        
            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow.CancelInvoice(result_CreateInvoice.InvoiceNumber, "Testing");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### CancelInvoiceByCustomer
    
```    
        
            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow.CancelInvoiceByCustomer(result_CreateInvoice.InvoiceNumber, "Testing");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### PayInvoiceWithCreditCard
    
```    
        
            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow.PayInvoiceWithCreditCard(result_CreateInvoice.InvoiceNumber, "4111111111111111", "1019");

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
### PayInvoiceWithBankAccount
    
```    
        
            var result_CreateInvoice = await _sparrow.CreateInvoice("12/01/2017", "USD", "active", 10.00m);
            var result = await _sparrow.PayInvoiceWithBankAccount(result_CreateInvoice.InvoiceNumber, "First Test Bank", "110000000", "1234567890123", "checking", "personal", 
                billing: new Sparrow.PayInvoiceWithBankAccountBilling{ FirstName = "John", LastName = "Doe" });

            if (result.IsSuccess)
            {
                // Do something ...
            }
            else
            {
                var textResponse = result.TextResponse;

                // Handle the Failure ...
            }

```            
    
"