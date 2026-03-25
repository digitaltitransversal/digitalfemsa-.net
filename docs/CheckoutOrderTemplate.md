# DigitalFemsa.net.Model.CheckoutOrderTemplate
Attributes used to create the order when a new payment is received.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | ISO 4217 currency code for the order. | 
**CustomerInfo** | [**CheckoutOrderTemplateCustomerInfo**](CheckoutOrderTemplateCustomerInfo.md) |  | [optional] 
**LineItems** | [**List&lt;Product&gt;**](Product.md) | Products to buy. Each contains unit price and quantity used to calculate the order total. | 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary key-value data attached to the order for internal use. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

