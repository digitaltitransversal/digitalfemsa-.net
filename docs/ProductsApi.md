# DigitalFemsa.net.Api.ProductsApi

All URIs are relative to *https://api.digitalfemsa.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrdersCreateProduct**](ProductsApi.md#orderscreateproduct) | **POST** /orders/{id}/line_items | Create Product |
| [**OrdersDeleteProduct**](ProductsApi.md#ordersdeleteproduct) | **DELETE** /orders/{id}/line_items/{line_item_id} | Delete Product |
| [**OrdersUpdateProduct**](ProductsApi.md#ordersupdateproduct) | **PUT** /orders/{id}/line_items/{line_item_id} | Update Product |

<a id="orderscreateproduct"></a>
# **OrdersCreateProduct**
> ProductOrderResponse OrdersCreateProduct (string id, Product product, string acceptLanguage = null, string xChildCompanyId = null)

Create Product

Creates a new product (line item) for an existing order. Use this endpoint to add an additional item to the order after it has been created.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersCreateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var product = new Product(); // Product | Fields required to create a new product (line item) for an existing order. This request adds a new item to the order.
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Create Product
                ProductOrderResponse result = apiInstance.OrdersCreateProduct(id, product, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.OrdersCreateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Product
    ApiResponse<ProductOrderResponse> response = apiInstance.OrdersCreateProductWithHttpInfo(id, product, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.OrdersCreateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **product** | [**Product**](Product.md) | Fields required to create a new product (line item) for an existing order. This request adds a new item to the order. |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**ProductOrderResponse**](ProductOrderResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersdeleteproduct"></a>
# **OrdersDeleteProduct**
> ProductOrderResponse OrdersDeleteProduct (string id, string lineItemId, string acceptLanguage = null, string xChildCompanyId = null)

Delete Product

Deletes a product (line item) from an existing order. The API will validate whether the order can be modified before removing the item.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersDeleteProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var lineItemId = line_item_2tQ8HkkfbauaKP9Ho;  // string | identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Delete Product
                ProductOrderResponse result = apiInstance.OrdersDeleteProduct(id, lineItemId, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.OrdersDeleteProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersDeleteProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Product
    ApiResponse<ProductOrderResponse> response = apiInstance.OrdersDeleteProductWithHttpInfo(id, lineItemId, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.OrdersDeleteProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **lineItemId** | **string** | identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**ProductOrderResponse**](ProductOrderResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersupdateproduct"></a>
# **OrdersUpdateProduct**
> ProductOrderResponse OrdersUpdateProduct (string id, string lineItemId, UpdateProduct updateProduct, string acceptLanguage = null, string xChildCompanyId = null)

Update Product

Updates an existing product (line item) for an existing order. Use this endpoint to modify the details of a specific line item in the order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersUpdateProductExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ProductsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var lineItemId = line_item_2tQ8HkkfbauaKP9Ho;  // string | identifier
            var updateProduct = new UpdateProduct(); // UpdateProduct | Fields allowed to update an existing product (line item) in an order. All fields are optional; only the provided fields will be updated.
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Update Product
                ProductOrderResponse result = apiInstance.OrdersUpdateProduct(id, lineItemId, updateProduct, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProductsApi.OrdersUpdateProduct: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersUpdateProductWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Product
    ApiResponse<ProductOrderResponse> response = apiInstance.OrdersUpdateProductWithHttpInfo(id, lineItemId, updateProduct, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProductsApi.OrdersUpdateProductWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **lineItemId** | **string** | identifier |  |
| **updateProduct** | [**UpdateProduct**](UpdateProduct.md) | Fields allowed to update an existing product (line item) in an order. All fields are optional; only the provided fields will be updated. |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**ProductOrderResponse**](ProductOrderResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

