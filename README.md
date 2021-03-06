# IO.Swagger - the C# library for the 

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build date: 2017-11-21T13:59:55.778Z
- Build package: io.swagger.codegen.languages.CsharpDotNet2ClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

Note: NuGet is downloaded by the mono compilation script and packages are installed with it. No dependency DLLs are bundled with this generator

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.facestore.local/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BrandsApi* | [**AddBrands**](docs/BrandsApi.md#addbrands) | **POST** /brands | 
*BrandsApi* | [**DeleteBrandById**](docs/BrandsApi.md#deletebrandbyid) | **DELETE** /brands/{id}/ | 
*BrandsApi* | [**GetBrandById**](docs/BrandsApi.md#getbrandbyid) | **GET** /brands/{id}/ | 
*BrandsApi* | [**GetBrands**](docs/BrandsApi.md#getbrands) | **GET** /brands | 
*BrandsApi* | [**UpdateCategoryById**](docs/BrandsApi.md#updatecategorybyid) | **PUT** /brands/{id}/ | 
*BrandsApi* | [**UpdateCategoryById_0**](docs/BrandsApi.md#updatecategorybyid_0) | **PATCH** /brands/{id}/ | 
*CategoriesApi* | [**AddCategories**](docs/CategoriesApi.md#addcategories) | **POST** /categories | 
*CategoriesApi* | [**DeleteCategoryById**](docs/CategoriesApi.md#deletecategorybyid) | **DELETE** /categories/{id}/ | 
*CategoriesApi* | [**GetCategories**](docs/CategoriesApi.md#getcategories) | **GET** /categories | 
*CategoriesApi* | [**GetCategoryById**](docs/CategoriesApi.md#getcategorybyid) | **GET** /categories/{id}/ | 
*CategoriesApi* | [**UpdateCategoryById**](docs/CategoriesApi.md#updatecategorybyid) | **PUT** /categories/{id}/ | 
*CustomersApi* | [**GetCustomerById**](docs/CustomersApi.md#getcustomerbyid) | **GET** /customers/{id}/ | 
*CustomersApi* | [**GetCustomers**](docs/CustomersApi.md#getcustomers) | **GET** /customers | 
*OrdersApi* | [**GetOrderById**](docs/OrdersApi.md#getorderbyid) | **GET** /orders/{id}/ | 
*OrdersApi* | [**GetOrders**](docs/OrdersApi.md#getorders) | **GET** /orders | 
*PaymentsApi* | [**GetPaymentById**](docs/PaymentsApi.md#getpaymentbyid) | **GET** /payments/{id}/ | 
*PaymentsApi* | [**GetPayments**](docs/PaymentsApi.md#getpayments) | **GET** /payments | 
*ProductsApi* | [**AddProduct**](docs/ProductsApi.md#addproduct) | **POST** /products | 
*ProductsApi* | [**DeleteProductById**](docs/ProductsApi.md#deleteproductbyid) | **DELETE** /products/{id}/ | 
*ProductsApi* | [**GetProductById**](docs/ProductsApi.md#getproductbyid) | **GET** /products/{id}/ | 
*ProductsApi* | [**GetProducts**](docs/ProductsApi.md#getproducts) | **GET** /products | 
*ProductsApi* | [**UpdateProductById**](docs/ProductsApi.md#updateproductbyid) | **PUT** /products/{id}/ | 
*ProductsApi* | [**UpdateProductById_0**](docs/ProductsApi.md#updateproductbyid_0) | **PATCH** /products/{id}/ | 
*ProductsAttributesApi* | [**AddProductsAttributes**](docs/ProductsAttributesApi.md#addproductsattributes) | **POST** /attributes | 
*ProductsAttributesApi* | [**DeleteProductAttributeById**](docs/ProductsAttributesApi.md#deleteproductattributebyid) | **DELETE** /attributes/{id}/ | 
*ProductsAttributesApi* | [**GetProductAttributeById**](docs/ProductsAttributesApi.md#getproductattributebyid) | **GET** /attributes/{id}/ | 
*ProductsAttributesApi* | [**GetProductsAttributes**](docs/ProductsAttributesApi.md#getproductsattributes) | **GET** /attributes | 
*ProductsAttributesApi* | [**UpdateProductAttributeById**](docs/ProductsAttributesApi.md#updateproductattributebyid) | **PUT** /attributes/{id}/ | 
*ShippingsApi* | [**AddShipping**](docs/ShippingsApi.md#addshipping) | **POST** /shippings | 
*ShippingsApi* | [**DeleteShippingById**](docs/ShippingsApi.md#deleteshippingbyid) | **DELETE** /shippings/{id}/ | 
*ShippingsApi* | [**GetShippingById**](docs/ShippingsApi.md#getshippingbyid) | **GET** /shippings/{id}/ | 
*ShippingsApi* | [**GetShippings**](docs/ShippingsApi.md#getshippings) | **GET** /shippings | 
*ShippingsApi* | [**UpdateShippingById**](docs/ShippingsApi.md#updateshippingbyid) | **PUT** /shippings/{id}/ | 
*ShippingsApi* | [**UpdateShippingById_0**](docs/ShippingsApi.md#updateshippingbyid_0) | **PATCH** /shippings/{id}/ | 
*TaxesApi* | [**AddTaxes**](docs/TaxesApi.md#addtaxes) | **POST** /taxes | 
*TaxesApi* | [**DeleteTaxById**](docs/TaxesApi.md#deletetaxbyid) | **DELETE** /taxes/{id}/ | 
*TaxesApi* | [**GetTaxById**](docs/TaxesApi.md#gettaxbyid) | **GET** /taxes/{id}/ | 
*TaxesApi* | [**GetTaxes**](docs/TaxesApi.md#gettaxes) | **GET** /taxes | 
*TaxesApi* | [**UpdateTaxById**](docs/TaxesApi.md#updatetaxbyid) | **PUT** /taxes/{id}/ | 
*TaxesApi* | [**UpdateTaxById_0**](docs/TaxesApi.md#updatetaxbyid_0) | **PATCH** /taxes/{id}/ | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.Attribute](docs/Attribute.md)
 - [IO.Swagger.Model.AttributeOptions](docs/AttributeOptions.md)
 - [IO.Swagger.Model.Brand](docs/Brand.md)
 - [IO.Swagger.Model.Category](docs/Category.md)
 - [IO.Swagger.Model.Customer](docs/Customer.md)
 - [IO.Swagger.Model.DefaultResponse](docs/DefaultResponse.md)
 - [IO.Swagger.Model.I18n](docs/I18n.md)
 - [IO.Swagger.Model.I18nProduct](docs/I18nProduct.md)
 - [IO.Swagger.Model.I18nProductSeo](docs/I18nProductSeo.md)
 - [IO.Swagger.Model.InlineResponse200](docs/InlineResponse200.md)
 - [IO.Swagger.Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [IO.Swagger.Model.InlineResponse2001Meta](docs/InlineResponse2001Meta.md)
 - [IO.Swagger.Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [IO.Swagger.Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [IO.Swagger.Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [IO.Swagger.Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [IO.Swagger.Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [IO.Swagger.Model.InlineResponse201](docs/InlineResponse201.md)
 - [IO.Swagger.Model.InlineResponse2011](docs/InlineResponse2011.md)
 - [IO.Swagger.Model.InlineResponse2012](docs/InlineResponse2012.md)
 - [IO.Swagger.Model.InlineResponse2013](docs/InlineResponse2013.md)
 - [IO.Swagger.Model.InlineResponse2014](docs/InlineResponse2014.md)
 - [IO.Swagger.Model.MetaPartialResponse](docs/MetaPartialResponse.md)
 - [IO.Swagger.Model.NotFoundResponse](docs/NotFoundResponse.md)
 - [IO.Swagger.Model.Options](docs/Options.md)
 - [IO.Swagger.Model.Order](docs/Order.md)
 - [IO.Swagger.Model.Payment](docs/Payment.md)
 - [IO.Swagger.Model.Product](docs/Product.md)
 - [IO.Swagger.Model.Shipping](docs/Shipping.md)
 - [IO.Swagger.Model.Tax](docs/Tax.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="APIKeyHeader"></a>
### APIKeyHeader

- **Type**: API key
- **API key parameter name**: APIToken
- **Location**: HTTP header

