# IO.Swagger.Api.BrandsApi

All URIs are relative to *https://api.facestore.local/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBrands**](BrandsApi.md#addbrands) | **POST** /brands | 
[**DeleteBrandById**](BrandsApi.md#deletebrandbyid) | **DELETE** /brands/{id}/ | 
[**GetBrandById**](BrandsApi.md#getbrandbyid) | **GET** /brands/{id}/ | 
[**GetBrands**](BrandsApi.md#getbrands) | **GET** /brands | 
[**UpdateCategoryById**](BrandsApi.md#updatecategorybyid) | **PUT** /brands/{id}/ | 
[**UpdateCategoryById_0**](BrandsApi.md#updatecategorybyid_0) | **PATCH** /brands/{id}/ | 


<a name="addbrands"></a>
# **AddBrands**
> InlineResponse201 AddBrands (Brand brand)



Creates a new brand in the store.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddBrandsExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new BrandsApi();
            var brand = new Brand(); // Brand | Brand to add to the store

            try
            {
                InlineResponse201 result = apiInstance.AddBrands(brand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.AddBrands: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brand** | [**Brand**](Brand.md)| Brand to add to the store | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebrandbyid"></a>
# **DeleteBrandById**
> void DeleteBrandById (long? id)



Deletes a single brand based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBrandByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new BrandsApi();
            var id = 789;  // long? | ID of brand to delete

            try
            {
                apiInstance.DeleteBrandById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.DeleteBrandById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of brand to delete | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrandbyid"></a>
# **GetBrandById**
> InlineResponse201 GetBrandById (long? id, List<string> includes, int? limit)



Returns a brand based on a single ID  ### Includes You can give the following values on includea parameter: `routes, products` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBrandByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new BrandsApi();
            var id = 789;  // long? | ID of brand to fetch
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 

            try
            {
                InlineResponse201 result = apiInstance.GetBrandById(id, includes, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.GetBrandById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of brand to fetch | 
 **includes** | [**List<string>**](string.md)| Include associated objects within response | [optional] 
 **limit** | **int?**| max records to return | [optional] 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbrands"></a>
# **GetBrands**
> InlineResponse200 GetBrands (List<string> includes, int? limit, List<string> orderBy)



Returns all brands from the system that the user has access to  ### Includes You can give the following values on includes parameter: `routes, products` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBrandsExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new BrandsApi();
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 
            var orderBy = new List<string>(); // List<string> | Specify the field to be sorted, examples:  - `?order_by=id|desc` - `?order_by=updated_at|desc,position|asc`  (optional) 

            try
            {
                InlineResponse200 result = apiInstance.GetBrands(includes, limit, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.GetBrands: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategorybyid"></a>
# **UpdateCategoryById**
> void UpdateCategoryById (long? id, Object brand)



Update a single brand based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCategoryByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new BrandsApi();
            var id = 789;  // long? | ID of brand to update
            var brand = ;  // Object | Brand to update in store

            try
            {
                apiInstance.UpdateCategoryById(id, brand);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.UpdateCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of brand to update | 
 **brand** | **Object**| Brand to update in store | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecategorybyid_0"></a>
# **UpdateCategoryById_0**
> void UpdateCategoryById_0 (long? id, Object brand)



Update a single brand based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCategoryById_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new BrandsApi();
            var id = 789;  // long? | ID of brand to update
            var brand = ;  // Object | Brand to update in store

            try
            {
                apiInstance.UpdateCategoryById_0(id, brand);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.UpdateCategoryById_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of brand to update | 
 **brand** | **Object**| Brand to update in store | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

