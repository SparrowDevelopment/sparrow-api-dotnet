# Unknown Test Data

## SimpleStarCard and AdvancedStarCard

- Need a valid CID number for testing
- textresponse: System Error: Reason Code: 002 CID value is invalid or non existant
- Attempted Values:
	- 52347800001
	- 12345678901

- curl state: INVALID TEST
	- The curl test does not execute the proper call, but is actually doing a credit card transation

## DecryptCustomFields

- Need valid data to test:
	- token and fieldname
	- OR a way to create an encrypted field
- textresponse: Custom field 'customField1' not found

- curl state: ERROR RESPONSE
	- textresponse=Internal+processing+error


## RetrieveCardBalance

- Unknown Error, Possibly a Parameter is missing from the documentation
- textresponse: Operation type is not supported by payment processor

- curl state: ERROR RESPONSE
	- textresponse=Operation+type+is+not+supported+by+payment+processor&

## PassengerSale

- Need valid test data
- textresponse: Operation type is not supported by payment processor

- curl state: INVALID TEST
	- The curl test does not execute the proper call, but is actually doing a regular sale (NOT transtype=passengersale)


# Possible Implementation Bugs

## CancelInvoiceByCustomer 

- This endpoint does not refer to any customer in the docs, it seems to be identical to CancelInvoice


