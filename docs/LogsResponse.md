# DigitalFemsa.net.Model.LogsResponse
Log model representing a recorded request/response cycle for troubleshooting and auditing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HasMore** | **bool** | True, if there are more pages. | [optional] [readonly] 
**Object** | **string** | The object type | [optional] [readonly] 
**NextPageUrl** | **string** | URL of the next page. | [optional] 
**PreviousPageUrl** | **string** | Url of the previous page. | [optional] 
**Data** | [**List&lt;LogsResponseData&gt;**](LogsResponseData.md) | set to page results. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

