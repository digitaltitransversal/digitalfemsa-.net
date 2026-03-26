# DigitalFemsa.net.Model.OrderResponseShippingContact
Shipping contact associated with the order. It may be `null` when not provided/required.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Phone** | **string** |  | [optional] 
**Receiver** | **string** |  | [optional] 
**BetweenStreets** | **string** |  | [optional] 
**Address** | [**CustomerShippingContactsResponseAddress**](CustomerShippingContactsResponseAddress.md) |  | [optional] 
**ParentId** | **string** | Customer ID that owns this shipping contact. | [optional] 
**Default** | **bool** |  | [optional] 
**Id** | **string** |  | [optional] 
**CreatedAt** | **long** |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Metadata associated with the shipping contact | [optional] 
**Object** | **string** |  | [optional] 
**Deleted** | **bool** | Present only when the shipping contact was deleted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

