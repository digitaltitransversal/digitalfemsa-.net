# DigitalFemsa.net.Api.ChargesApi

All URIs are relative to *https://api.digitalfemsa.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCharges**](ChargesApi.md#getcharges) | **GET** /charges | List charges |
| [**OrdersCreateCharge**](ChargesApi.md#orderscreatecharge) | **POST** /orders/{id}/charges | Create a charge for an order |
| [**UpdateCharge**](ChargesApi.md#updatecharge) | **PUT** /charges/{id} | Update a charge |

<a id="getcharges"></a>
# **GetCharges**
> GetChargesResponse GetCharges (string acceptLanguage = null, string xChildCompanyId = null, int? limit = null, string next = null, string previous = null, string search = null)

List charges

Retrieves a paginated list of charges for the authenticated account.  Use the pagination parameters (`limit`, `next_page`, `previous_page`) to navigate through results. Use `search` to filter charges (for example by id or reference). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class GetChargesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChargesApi(config);
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 
            var search = "search_example";  // string | General order search, e.g. by mail, reference etc. (optional) 

            try
            {
                // List charges
                GetChargesResponse result = apiInstance.GetCharges(acceptLanguage, xChildCompanyId, limit, next, previous, search);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargesApi.GetCharges: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChargesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List charges
    ApiResponse<GetChargesResponse> response = apiInstance.GetChargesWithHttpInfo(acceptLanguage, xChildCompanyId, limit, next, previous, search);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargesApi.GetChargesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |
| **search** | **string** | General order search, e.g. by mail, reference etc. | [optional]  |

### Return type

[**GetChargesResponse**](GetChargesResponse.md)

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
| **422** | whitelist validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="orderscreatecharge"></a>
# **OrdersCreateCharge**
> ChargeOrderResponse OrdersCreateCharge (string id, ChargeRequest chargeRequest, string acceptLanguage = null, string xChildCompanyId = null)

Create a charge for an order

Creates a new charge associated with an existing order.  Notes: - The charge is created for the order identified by the path parameter `id`. - Depending on the payment method, the charge may be created in a non-final status (for example, pending). - If the order does not meet the required conditions, the API may respond with **428 Precondition Required**. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersCreateChargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChargesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var chargeRequest = new ChargeRequest(); // ChargeRequest | requested field for a charge
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Create a charge for an order
                ChargeOrderResponse result = apiInstance.OrdersCreateCharge(id, chargeRequest, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargesApi.OrdersCreateCharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateChargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a charge for an order
    ApiResponse<ChargeOrderResponse> response = apiInstance.OrdersCreateChargeWithHttpInfo(id, chargeRequest, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargesApi.OrdersCreateChargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **chargeRequest** | [**ChargeRequest**](ChargeRequest.md) | requested field for a charge |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**ChargeOrderResponse**](ChargeOrderResponse.md)

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
| **428** | Precondition Required |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecharge"></a>
# **UpdateCharge**
> ChargeResponse UpdateCharge (string id, ChargeUpdateRequest chargeUpdateRequest, string acceptLanguage = null, string xChildCompanyId = null)

Update a charge

Updates an existing charge. Only `reference_id` can be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class UpdateChargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ChargesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var chargeUpdateRequest = new ChargeUpdateRequest(); // ChargeUpdateRequest | requested field for update a charge
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Update a charge
                ChargeResponse result = apiInstance.UpdateCharge(id, chargeUpdateRequest, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChargesApi.UpdateCharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a charge
    ApiResponse<ChargeResponse> response = apiInstance.UpdateChargeWithHttpInfo(id, chargeUpdateRequest, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChargesApi.UpdateChargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **chargeUpdateRequest** | [**ChargeUpdateRequest**](ChargeUpdateRequest.md) | requested field for update a charge |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**ChargeResponse**](ChargeResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **422** | whitelist validation error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

