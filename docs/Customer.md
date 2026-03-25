# DigitalFemsa.net.Model.Customer
Customer create request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Customer&#39;s name. | 
**Email** | **string** | Customer email address. | 
**Phone** | **string** | Customer phone number. | [optional] 
**Corporate** | **bool** | Indicates whether the customer email is corporate. | [optional] [default to false]
**CustomReference** | **string** | Merchant-defined reference used to identify the customer in your system. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary metadata associated with the customer. | [optional] 
**PaymentSources** | [**List&lt;CustomerPaymentMethodsRequest&gt;**](CustomerPaymentMethodsRequest.md) | Customer payment sources to be created with the customer (optional). | [optional] 
**FiscalEntities** | [**List&lt;CustomerFiscalEntitiesRequest&gt;**](CustomerFiscalEntitiesRequest.md) | Customer fiscal entities to be created with the customer (optional). | [optional] 
**ShippingContacts** | [**List&lt;CustomerShippingContacts&gt;**](CustomerShippingContacts.md) | Customer shipping contacts to be created with the customer (optional). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

