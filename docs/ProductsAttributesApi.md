# IO.Swagger.Api.ProductsAttributesApi

All URIs are relative to *https://api.facestore.local/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProductsAttributes**](ProductsAttributesApi.md#addproductsattributes) | **POST** /attributes | 
[**DeleteProductAttributeById**](ProductsAttributesApi.md#deleteproductattributebyid) | **DELETE** /attributes/{id}/ | 
[**GetProductAttributeById**](ProductsAttributesApi.md#getproductattributebyid) | **GET** /attributes/{id}/ | 
[**GetProductsAttributes**](ProductsAttributesApi.md#getproductsattributes) | **GET** /attributes | 
[**UpdateProductAttributeById**](ProductsAttributesApi.md#updateproductattributebyid) | **PUT** /attributes/{id}/ | 


<a name="addproductsattributes"></a>
# **AddProductsAttributes**
> List<Attribute> AddProductsAttributes (Attribute attribute)



Creates a new attribute of products in the store.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddProductsAttributesExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsAttributesApi();
            var attribute = new Attribute(); // Attribute | Attribute to add to the store

            try
            {
                List&lt;Attribute&gt; result = apiInstance.AddProductsAttributes(attribute);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsAttributesApi.AddProductsAttributes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attribute** | [**Attribute**](Attribute.md)| Attribute to add to the store | 

### Return type

[**List<Attribute>**](Attribute.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductattributebyid"></a>
# **DeleteProductAttributeById**
> void DeleteProductAttributeById (long? id)



deletes a single attribute of products based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProductAttributeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsAttributesApi();
            var id = 789;  // long? | ID of attribute to delete

            try
            {
                apiInstance.DeleteProductAttributeById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsAttributesApi.DeleteProductAttributeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of attribute to delete | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductattributebyid"></a>
# **GetProductAttributeById**
> Attribute GetProductAttributeById (long? id, List<string> includes)



Returns a attribute of products based on a single ID  ### Includes You can give the following values on includes parameter: `options` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductAttributeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsAttributesApi();
            var id = 789;  // long? | ID of attribute to fetch
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 

            try
            {
                Attribute result = apiInstance.GetProductAttributeById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsAttributesApi.GetProductAttributeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of attribute to fetch | 
 **includes** | [**List<string>**](string.md)| Include associated objects within response | [optional] 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductsattributes"></a>
# **GetProductsAttributes**
> List<Attribute> GetProductsAttributes (List<string> includes, int? limit, List<string> orderBy)



Returns all attributes of products from the system that the user has access to  ### Includes You can give the following values on includes parameter: `options` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductsAttributesExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsAttributesApi();
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 
            var orderBy = new List<string>(); // List<string> | Specify the field to be sorted, examples:  - `?order_by=id|desc` - `?order_by=updated_at|desc,position|asc`  (optional) 

            try
            {
                List&lt;Attribute&gt; result = apiInstance.GetProductsAttributes(includes, limit, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsAttributesApi.GetProductsAttributes: " + e.Message );
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

[**List<Attribute>**](Attribute.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductattributebyid"></a>
# **UpdateProductAttributeById**
> Attribute UpdateProductAttributeById (long? id, Attribute productAttribute)



update a single attribute of products based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProductAttributeByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsAttributesApi();
            var id = 789;  // long? | ID of attribute to update
            var productAttribute = new Attribute(); // Attribute | Attribute to add to the store

            try
            {
                Attribute result = apiInstance.UpdateProductAttributeById(id, productAttribute);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsAttributesApi.UpdateProductAttributeById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of attribute to update | 
 **productAttribute** | [**Attribute**](Attribute.md)| Attribute to add to the store | 

### Return type

[**Attribute**](Attribute.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

