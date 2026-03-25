# DigitalFemsa.net.Model.OrderResponse
Order model. Some nested resources are returned as list previews (for example: `charges`, `line_items`), and may be `null` depending on the request/context. The `checkout` field is only present when the order is linked to a checkout (`channel.checkout_request_id`). 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Object** | **string** |  | [optional] 
**Livemode** | **bool** |  | [optional] 
**Amount** | **int** |  | [optional] 
**Currency** | **string** |  | [optional] 
**PaymentStatus** | **string** | Current payment status of the order. It can be &#x60;null&#x60; for orders without payment information yet. | [optional] 
**AmountRefunded** | **int** |  | [optional] 
**SplitPayment** | **bool?** | Indicates whether the order uses split payments (when available/configured). | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Metadata attached to the order. | [optional] 
**IsRefundable** | **bool** | Indicates whether the order is currently refundable. | [optional] 
**CreatedAt** | **long** |  | [optional] 
**UpdatedAt** | **long** |  | [optional] 
**CustomerInfo** | [**OrderResponseCustomerInfo**](OrderResponseCustomerInfo.md) |  | [optional] 
**ShippingContact** | [**OrderResponseShippingContact**](OrderResponseShippingContact.md) |  | [optional] 
**Channel** | [**OrderResponseChannel**](OrderResponseChannel.md) |  | [optional] 
**FiscalEntity** | [**OrderFiscalEntityResponse**](OrderFiscalEntityResponse.md) |  | [optional] 
**Checkout** | [**OrderResponseCheckout**](OrderResponseCheckout.md) |  | [optional] 
**LineItems** | [**OrderResponseProducts**](OrderResponseProducts.md) |  | [optional] 
**DiscountLines** | [**OrderResponseDiscountLines**](OrderResponseDiscountLines.md) |  | [optional] 
**Charges** | [**OrderResponseCharges**](OrderResponseCharges.md) |  | [optional] 
**PartialReference** | **Dictionary&lt;string, Object&gt;** | Partial reference information (when applicable). Structure may vary depending on the payment flow. | [optional] 
**PaymentsInfo** | **Dictionary&lt;string, Object&gt;** | Additional payment information (when available). Structure may vary. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

