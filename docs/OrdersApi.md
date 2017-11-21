# IO.Swagger.Api.OrdersApi

All URIs are relative to *https://api.facestore.local/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOrderById**](OrdersApi.md#getorderbyid) | **GET** /orders/{id}/ | 
[**GetOrders**](OrdersApi.md#getorders) | **GET** /orders | 


<a name="getorderbyid"></a>
# **GetOrderById**
> List<Order> GetOrderById (long? id, List<string> includes)



Returns all orders from the system that the user has access to  ### Includes You can give the following values on includes parameter: `products, customers` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrderByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new OrdersApi();
            var id = 789;  // long? | ID of customer
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 

            try
            {
                List&lt;Order&gt; result = apiInstance.GetOrderById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrderById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of customer | 
 **includes** | [**List<string>**](string.md)| Include associated objects within response | [optional] 

### Return type

[**List<Order>**](Order.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorders"></a>
# **GetOrders**
> List<Order> GetOrders (List<string> includes, int? limit, List<string> orderBy)



Returns all orders from the system that the user has access to  ### Includes You can give the following values on includes parameter: `products, customers` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrdersExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new OrdersApi();
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 
            var orderBy = new List<string>(); // List<string> | Specify the field to be sorted, examples:  - `?order_by=id|desc` - `?order_by=updated_at|desc,position|asc`  (optional) 

            try
            {
                List&lt;Order&gt; result = apiInstance.GetOrders(includes, limit, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrders: " + e.Message );
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

[**List<Order>**](Order.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

