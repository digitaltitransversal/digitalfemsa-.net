# DigitalFemsa.net.Model.OrderRequest
a order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | Currency with which the payment will be made. | 
**CustomerInfo** | [**OrderRequestCustomerInfo**](OrderRequestCustomerInfo.md) |  | 
**LineItems** | [**List&lt;Product&gt;**](Product.md) | List of [products](https://developers.digitalfemsa.io/reference/orderscreateproduct) that are sold in the order. You must have at least one product. | 
**Charges** | [**List&lt;ChargeRequest&gt;**](ChargeRequest.md) | List of [charges](https://developers.digitalfemsa.io/reference/orderscreatecharge) that are applied to the order | [optional] 
**Checkout** | [**CheckoutRequest**](CheckoutRequest.md) |  | [optional] 
**DiscountLines** | [**List&lt;OrderDiscountLinesRequest&gt;**](OrderDiscountLinesRequest.md) | List of [discounts](https://developers.digitalfemsa.io/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount. | [optional] 
**TaxLines** | [**List&lt;OrderTaxRequest&gt;**](OrderTaxRequest.md) | List of [taxes](https://developers.digitalfemsa.io/reference/orderscreatetaxes) that are applied to the order. | [optional] 
**NeedsShippingContact** | **bool** | Allows you to fill out the shipping information at checkout | [optional] 
**ShippingContact** | [**CustomerShippingContacts**](CustomerShippingContacts.md) |  | [optional] 
**ShippingLines** | [**List&lt;ShippingRequest&gt;**](ShippingRequest.md) | List of [shipping costs](https://developers.digitalfemsa.io/reference/orderscreateshipping). If the online store offers digital products. | [optional] 
**FiscalEntity** | [**OrderFiscalEntityRequest**](OrderFiscalEntityRequest.md) |  | [optional] 
**ProcessingMode** | **string** | Indicates the processing mode for the order, either ecommerce, recurrent or validation. | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** | Arbitrary key-value data that you can attach to the order for your internal use (e.g. &#x60;customer_segment&#x60;, &#x60;sales_channel&#x60;, &#x60;internal_order_id&#x60;). It is not used for payment processing or fraud decisions. Keys should be strings; values can be any JSON value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

