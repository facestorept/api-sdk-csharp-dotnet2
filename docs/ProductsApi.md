# IO.Swagger.Api.ProductsApi

All URIs are relative to *https://api.facestore.local/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddProduct**](ProductsApi.md#addproduct) | **POST** /products | 
[**DeleteProductById**](ProductsApi.md#deleteproductbyid) | **DELETE** /products/{id}/ | 
[**GetProductById**](ProductsApi.md#getproductbyid) | **GET** /products/{id}/ | 
[**GetProducts**](ProductsApi.md#getproducts) | **GET** /products | 
[**UpdateProductById**](ProductsApi.md#updateproductbyid) | **PUT** /products/{id}/ | 
[**UpdateProductById_0**](ProductsApi.md#updateproductbyid_0) | **PATCH** /products/{id}/ | 


<a name="addproduct"></a>
# **AddProduct**
> InlineResponse2014 AddProduct (Product product)



Creates a new product in the store.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddProductExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsApi();
            var product = new Product(); // Product | Product to add to the store

            try
            {
                InlineResponse2014 result = apiInstance.AddProduct(product);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.AddProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **product** | [**Product**](Product.md)| Product to add to the store | 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproductbyid"></a>
# **DeleteProductById**
> void DeleteProductById (long? id)



deletes a single product based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteProductByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 789;  // long? | ID of product to delete

            try
            {
                apiInstance.DeleteProductById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of product to delete | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproductbyid"></a>
# **GetProductById**
> InlineResponse2014 GetProductById (long? id, List<string> includes, int? limit)



Returns a product based on a single ID  ### Includes You can give the following values on includes parameter: `brands, categories, routes, stocks` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 789;  // long? | ID of product to fetch
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 

            try
            {
                InlineResponse2014 result = apiInstance.GetProductById(id, includes, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of product to fetch | 
 **includes** | [**List<string>**](string.md)| Include associated objects within response | [optional] 
 **limit** | **int?**| max records to return | [optional] 

### Return type

[**InlineResponse2014**](InlineResponse2014.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproducts"></a>
# **GetProducts**
> InlineResponse2006 GetProducts (List<string> includes, int? limit, List<string> orderBy)



Returns all products from the system that the user has access to  ### Includes You can give the following values on includes parameter: `brands, categories, routes, stocks` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetProductsExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsApi();
            var includes = new List<string>(); // List<string> | Include associated objects within response (optional) 
            var limit = 56;  // int? | max records to return (optional) 
            var orderBy = new List<string>(); // List<string> | Specify the field to be sorted, examples:  - `?order_by=id|desc` - `?order_by=updated_at|desc,position|asc`  (optional) 

            try
            {
                InlineResponse2006 result = apiInstance.GetProducts(includes, limit, orderBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductbyid"></a>
# **UpdateProductById**
> void UpdateProductById (long? id, Product tax)



update a single product based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProductByIdExample
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 789;  // long? | ID of product to update
            var tax = new Product(); // Product | Product to add to the store

            try
            {
                apiInstance.UpdateProductById(id, tax);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of product to update | 
 **tax** | [**Product**](Product.md)| Product to add to the store | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproductbyid_0"></a>
# **UpdateProductById_0**
> void UpdateProductById_0 (long? id, Product tax)



update a single product based on the ID supplied

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateProductById_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: APIKeyHeader
            Configuration.Default.ApiKey.Add("APIToken", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("APIToken", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 789;  // long? | ID of product to update
            var tax = new Product(); // Product | Product to add to the store

            try
            {
                apiInstance.UpdateProductById_0(id, tax);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProductById_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**| ID of product to update | 
 **tax** | [**Product**](Product.md)| Product to add to the store | 

### Return type

void (empty response body)

### Authorization

[APIKeyHeader](../README.md#APIKeyHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

