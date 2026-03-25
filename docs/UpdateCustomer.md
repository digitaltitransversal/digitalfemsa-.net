# DigitalFemsa.net.Model.UpdateCustomer
Request body to update a customer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Customer&#39;s name. | [optional] 
**Email** | **string** | Customer email address. | [optional] 
**Phone** | **string** | Customer phone number. | [optional] 
**Corporate** | **bool** | True if the customer represents a company. | [optional] 
**CustomReference** | **string** | Merchant-defined reference used to identify the customer in your system. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary metadata associated with the customer. | [optional] 
**PaymentSources** | [**List&lt;CustomerPaymentMethodsRequest&gt;**](CustomerPaymentMethodsRequest.md) | Customer payment sources to create/attach (offline recurrent references). | [optional] 
**DefaultPaymentSourceId** | **string** | Sets the default payment source for the customer (must be an existing payment source on the customer). | [optional] 
**DefaultFiscalEntityId** | **string** | Sets the default fiscal entity for the customer (must be an existing fiscal entity on the customer). | [optional] 
**DefaultShippingContactId** | **string** | Sets the default shipping contact for the customer (must be an existing shipping contact on the customer). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

