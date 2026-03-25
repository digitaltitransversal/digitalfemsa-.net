# DigitalFemsa.net.Model.TransactionResponse
Transaction object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique identifier of the transaction. | 
**Object** | **string** | Object name, which is transaction. | 
**Amount** | **long** | The amount of the transaction. | 
**Fee** | **long** | The amount to be deducted for taxes and commissions. | 
**Net** | **long** | The net amount after deducting commissions and taxes. | 
**Currency** | **string** | The currency of the transaction. It uses the 3-letter code of ISO 4217. | 
**Status** | **string** | Code indicating transaction status. | 
**Type** | **string** | Transaction type. | 
**CreatedAt** | **long** | Date and time of creation of the transaction in Unix format. | 
**Livemode** | **bool** | Indicates whether the transaction was created in live mode or test mode. | 
**Charge** | **string** | Charge ID associated with the transaction (present only if the transaction belongs to a charge). | [optional] 
**Transfer** | **string** | Transfer ID associated with the transaction (present only if the transaction belongs to a transfer). | [optional] 
**TransferredAt** | **long?** | Date and time when the transaction was transferred, in Unix format. | [optional] 
**Formula** | **string** | Transaction fee formula identifier (if available). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

