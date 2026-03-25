# DigitalFemsa.net.Model.OrderResponseCharges
List preview of charges created for the order. Charges are only created when included in the request or created later through payment flows. This field can be `null` depending on the response context. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasMore** | **bool** | Indicates if there are more pages to be requested | 
**Object** | **string** | Object type, in this case is list | 
**Data** | [**List&lt;ChargesDataResponse&gt;**](ChargesDataResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

