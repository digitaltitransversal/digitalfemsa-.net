# DigitalFemsa.net.Model.CheckoutRequest
[Checkout](https://developers.digitalfemsa.io/docs/checkout-redireccionado) details 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedPaymentMethods** | **List&lt;string&gt;** | Are the payment methods available for this link | 
**ExpiresAt** | **long** | Unix timestamp of checkout expiration | [optional] 
**FailureUrl** | **string** | Redirection url back to the site in case of failed payment, applies only to HostedPayment. | [optional] 
**Name** | **string** | Reason for payment | [optional] 
**OnDemandEnabled** | **bool** |  | [optional] 
**SuccessUrl** | **string** | Redirection url back to the site in case of successful payment, applies only to HostedPayment | [optional] 
**Type** | **string** | This field represents the type of checkout | [optional] 
**RedirectionTime** | **int** | Number of seconds to wait before redirecting to the success or failure url | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

