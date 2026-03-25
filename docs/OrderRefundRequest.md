# DigitalFemsa.net.Model.OrderRefundRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | Amount to refund. If not provided, the API refunds the refundable amount of the selected charge. | 
**ChargeId** | **string** | Charge ID to refund. If not provided, the API selects a refundable charge from the order. | [optional] 
**Reason** | **string** | Refund reason. If not provided, the API uses a default reason. | 
**ExpiresAt** | **long?** | Expiration timestamp for cash refunds (must be within the allowed range configured by the API). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

