# DigitalFemsa.net.Model.Checkout
Creates a Payment Link. This is a sub-resource related to an Order template: each time a customer pays using the link, the API will create an Order using `order_template`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Payment link name. | 
**Type** | **string** | Checkout type. | 
**Recurrent** | **bool** | false: single use. true: multiple payments | 
**PaymentsLimitCount** | **int** | Required when &#x60;recurrent&#x60; is true. Maximum number of payments allowed through the link. | [optional] 
**AllowedPaymentMethods** | **List&lt;string&gt;** | Payment methods available in the payment link. | 
**NeedsShippingContact** | **bool** | This flag allows you to fill in the shipping information at checkout. | 
**StartsAt** | **long** | Start time for the link. Unix timestamp in seconds. | [optional] 
**ExpiresAt** | **long** | Expiration time for the link (Unix timestamp in seconds). Valid range is between 2 and 365 days (calculated from the next day of creation at 00:01).  | 
**CanNotExpire** | **bool** | If true, the link does not expire. | [optional] 
**OrderTemplate** | [**CheckoutOrderTemplate**](CheckoutOrderTemplate.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

