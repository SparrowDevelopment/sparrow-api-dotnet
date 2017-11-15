# Unknown Test Data

## SimpleStarCard and AdvancedStarCard
### Confirmed (MT)
- Need a valid CID number for testing
- textresponse: System Error: Reason Code: 002 CID value is invalid or non existant
- Attempted Values:
	- 52347800001
	- 12345678901

- curl state: INVALID TEST
	- The curl test does not execute the proper call, but is actually doing a credit card transation

## DecryptCustomFields
### Confirmed (MT)
- Need valid data to test:
	- token and fieldname
	- OR a way to create an encrypted field
- textresponse: Custom field 'customField1' not found

- curl state: ERROR RESPONSE
	- textresponse=Internal+processing+error


## RetrieveCardBalance
### Confirmed (MT)
- Unknown Error, Possibly a Parameter is missing from the documentation
- textresponse: Operation type is not supported by payment processor

- curl state: ERROR RESPONSE
	- textresponse=Operation+type+is+not+supported+by+payment+processor&

## PassengerSale
### Confirmed (MT)
- Need valid test data
- textresponse: Operation type is not supported by payment processor

- curl state: INVALID TEST
	- The curl test does not execute the proper call, but is actually doing a regular sale (NOT transtype=passengersale)


# Possible Implementation Bugs

## CancelInvoiceByCustomer 

- This endpoint does not refer to any customer in the docs, it seems to be identical to CancelInvoice
- (Might be an implied reason code? E.g., transtype "cancelinvoice" implies cancelled by business, "cancelinvoicebycustomer" specifies invoice cancelled by consumer?)

# Inconsistent Success Responses

## Inconsistent Text Response

Most response messages contain the word "success" or "successfully" and this is the most reliable way to confirm success.

However, the following do not always respond with a message containing the word "success"

- MarkSuccessfulTransactionAsChargeback

## Inconsistent Status Code

These do not respond with 'status' value of 200

- UpdateInvoice
- RetrieveInvoice
- AssignPaymentPlanToCustomer
- CancelPlanAssignment
- CancelInvoice
- CancelInvoiceByCustomer
- CreatePaymentPlan
- PayInvoiceWithCreditCard
- AddCreditCard
- CreateInvoice
- UpdatePaymentPlanAssignment
- UpdatePaymentPlan
- AddStarCard
- DeleteDataVaultCustomer
- AddEwallet
- DeletePlan
- DeletePaymentType
- PayInvoiceWithBankAccount
- AddACH
- UpdateCustomer
- AddCustomer


## Inconsistent Response Codes

These respond with a response code of '00' 'A' or nothing

- UpdateInvoice
- AdvancedACH
- SimpleACH
- RetrieveInvoice
- CancelInvoice
- CancelInvoiceByCustomer
- PayInvoiceWithCreditCard
- CreateInvoice
- AddStarCard
- PayInvoiceWithBankAccount
- AddACH

