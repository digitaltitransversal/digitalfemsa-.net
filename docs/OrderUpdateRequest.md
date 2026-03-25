# DigitalFemsa.net.Model.OrderUpdateRequest
Order update payload. Only supported fields can be modified.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | Currency code in ISO 4217 (3-letter uppercase). | [optional] 
**CustomerInfo** | [**OrderUpdateRequestCustomerInfo**](OrderUpdateRequestCustomerInfo.md) |  | [optional] 
**LineItems** | [**List&lt;Product&gt;**](Product.md) | List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product. | [optional] 
**Charges** | [**List&lt;ChargeRequest&gt;**](ChargeRequest.md) |  | [optional] 
**DiscountLines** | [**List&lt;OrderDiscountLinesRequest&gt;**](OrderDiscountLinesRequest.md) | List of [discounts](https://developers.femsa.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount. | [optional] 
**TaxLines** | [**List&lt;OrderTaxRequest&gt;**](OrderTaxRequest.md) |  | [optional] 
**ShippingContactId** | **string** | Existing shipping contact id from the customer to link to this order. | [optional] 
**ShippingContact** | [**CustomerShippingContacts**](CustomerShippingContacts.md) |  | [optional] 
**ShippingLines** | [**List&lt;ShippingRequest&gt;**](ShippingRequest.md) | List of [shipping costs](https://developers.femsa.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products. | [optional] 
**FiscalEntityId** | **string** | Existing fiscal entity id from the customer to link to this order. | [optional] 
**FiscalEntity** | [**OrderUpdateFiscalEntityRequest**](OrderUpdateFiscalEntityRequest.md) |  | [optional] 
**ReturnUrl** | **string** | URL where the customer should be redirected after completing a payment flow (if applicable). | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary key-value data that you can attach to the order for your internal use. It is not used for payment processing. Keys should be strings; values can be any JSON value.  | [optional] 
**Status** | **string** | Order status update (only allowed transitions will be accepted). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

