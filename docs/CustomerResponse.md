# DigitalFemsa.net.Model.CustomerResponse
customer response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Customer&#39;s ID | 
**Object** | **string** |  | 
**CreatedAt** | **long** | Creation date of the object (Unix timestamp) | 
**Livemode** | **bool** | true if the object exists in live mode or false if the object exists in test mode | 
**Name** | **string** | Customer&#39;s name | [optional] 
**Email** | **string** |  | [optional] 
**Phone** | **string** | Customer&#39;s phone number | [optional] 
**Corporate** | **bool** | true if the customer is a company | [optional] 
**CustomReference** | **string** | Custom reference | [optional] 
**DefaultFiscalEntityId** | **string** |  | [optional] 
**DefaultShippingContactId** | **string** |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Customer metadata (maps to contextual_data in backend) | [optional] 
**PaymentSources** | [**CustomerPaymentMethodsResponse**](CustomerPaymentMethodsResponse.md) |  | [optional] 
**FiscalEntities** | [**CustomerFiscalEntitiesResponse**](CustomerFiscalEntitiesResponse.md) |  | [optional] 
**ShippingContacts** | [**CustomerResponseShippingContacts**](CustomerResponseShippingContacts.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

