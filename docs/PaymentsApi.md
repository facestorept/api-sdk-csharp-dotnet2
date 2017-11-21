# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://api.facestore.local/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentById**](PaymentsApi.md#getpaymentbyid) | **GET** /payments/{id}/ | 
[**GetPayments**](PaymentsApi.md#getpayments) | **GET** /payments | 


<a name="getpaymentbyid"></a>
# **GetPaymentById**
> InlineResponse2005 GetPaymentById (long? id)



Returns all payments from the system that the user has access to 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new PaymentsApi();
            var id = 789;  // long? | ID of payment

            try
            {
                InlineResponse2005 result = apiInstance.GetPaymentById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of payment | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayments"></a>
# **GetPayments**
> InlineResponse2004 GetPayments (List<string> includes, int? limit, List<string> orderBy)



Returns all payments from the system that the user has access to 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentsExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new PaymentsApi();
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 
            var orderBy = new List<string>(); // List<string> | Specify the field to be sorted, examples:  - `?order_by=id|desc` - `?order_by=updated_at|desc,position|asc`  (optional) 

            try
            {
                InlineResponse2004 result = apiInstance.GetPayments(includes, limit, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includes** | [**List<string>**](string.md)| Include associated objects within response | [optional] 
 **limit** | **int?**| max records to return | [optional] 
 **orderBy** | [**List<string>**](string.md)| Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60;  | [optional] 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

