
		        [TestMethod]
        public async Task AssignPaymentPlanToCustomer()
        {
            var result_AddCustomer = await _sparrow_creditcard.AddCustomer("John", "Doe",
                payments: new[] { new Sparrow.AddCustomerPayment { PayType = "creditcard", CardNum = "4005562231212149", CardExp = "1019" } });
            var result_CreatePaymentPlan = await _sparrow_creditcard.CreatePaymentPlan("PaymentPlan1", "1st Payment Plan", "01/31/2017",
                buildSequenceSequences: new[] { new Sparrow.CreatePaymentPlanBuildSequenceSequence() { Sequence = "1", Amount = 9.99m, ScheduleType = "monthly", ScheduleDay = "5", Duration = "12" } });
            var result = await _sparrow_creditcard.AssignPaymentPlanToCustomer(result_AddCustomer.CustomerToken, result_CreatePaymentPlan.PlanToken, result_AddCustomer.PaymentTokens[0]);

            TestContext.WriteLine(result.ToString());

            // Assert.AreEqual(200, result.Status);
            // Assert.AreEqual(1, result.Response);
            Assert.IsTrue(result.TextResponse.ToUpper().Contains("SUCCESS"));
        }