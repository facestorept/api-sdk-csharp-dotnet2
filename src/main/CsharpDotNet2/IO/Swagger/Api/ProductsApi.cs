using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductsApi
    {
        /// <summary>
        ///  Creates a new product in the store.
        /// </summary>
        /// <param name="product">Product to add to the store</param>
        /// <returns>InlineResponse2014</returns>
        InlineResponse2014 AddProduct (Product product);
        /// <summary>
        ///  deletes a single product based on the ID supplied
        /// </summary>
        /// <param name="id">ID of product to delete</param>
        /// <returns></returns>
        void DeleteProductById (long? id);
        /// <summary>
        ///  Returns a product based on a single ID  ### Includes You can give the following values on includes parameter: &#x60;brands, categories, routes, stocks&#x60; 
        /// </summary>
        /// <param name="id">ID of product to fetch</param>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <returns>InlineResponse2014</returns>
        InlineResponse2014 GetProductById (long? id, List<string> includes, int? limit);
        /// <summary>
        ///  Returns all products from the system that the user has access to  ### Includes You can give the following values on includes parameter: &#x60;brands, categories, routes, stocks&#x60; 
        /// </summary>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 GetProducts (List<string> includes, int? limit, List<string> orderBy);
        /// <summary>
        ///  update a single product based on the ID supplied
        /// </summary>
        /// <param name="id">ID of product to update</param>
        /// <param name="tax">Product to add to the store</param>
        /// <returns></returns>
        void UpdateProductById (long? id, Product tax);
        /// <summary>
        ///  update a single product based on the ID supplied
        /// </summary>
        /// <param name="id">ID of product to update</param>
        /// <param name="tax">Product to add to the store</param>
        /// <returns></returns>
        void UpdateProductById_1 (long? id, Product tax);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductsApi : IProductsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Creates a new product in the store.
        /// </summary>
        /// <param name="product">Product to add to the store</param> 
        /// <returns>InlineResponse2014</returns>            
        public InlineResponse2014 AddProduct (Product product)
        {
            
            // verify the required parameter 'product' is set
            if (product == null) throw new ApiException(400, "Missing required parameter 'product' when calling AddProduct");
            
    
            var path = "/products";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(product); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddProduct: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddProduct: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2014) ApiClient.Deserialize(response.Content, typeof(InlineResponse2014), response.Headers);
        }
    
        /// <summary>
        ///  deletes a single product based on the ID supplied
        /// </summary>
        /// <param name="id">ID of product to delete</param> 
        /// <returns></returns>            
        public void DeleteProductById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteProductById");
            
    
            var path = "/products/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProductById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProductById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Returns a product based on a single ID  ### Includes You can give the following values on includes parameter: &#x60;brands, categories, routes, stocks&#x60; 
        /// </summary>
        /// <param name="id">ID of product to fetch</param> 
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <returns>InlineResponse2014</returns>            
        public InlineResponse2014 GetProductById (long? id, List<string> includes, int? limit)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetProductById");
            
    
            var path = "/products/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includes != null) queryParams.Add("includes", ApiClient.ParameterToString(includes)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2014) ApiClient.Deserialize(response.Content, typeof(InlineResponse2014), response.Headers);
        }
    
        /// <summary>
        ///  Returns all products from the system that the user has access to  ### Includes You can give the following values on includes parameter: &#x60;brands, categories, routes, stocks&#x60; 
        /// </summary>
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param> 
        /// <returns>InlineResponse2006</returns>            
        public InlineResponse2006 GetProducts (List<string> includes, int? limit, List<string> orderBy)
        {
            
    
            var path = "/products";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includes != null) queryParams.Add("includes", ApiClient.ParameterToString(includes)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (orderBy != null) queryParams.Add("order_by", ApiClient.ParameterToString(orderBy)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProducts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProducts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        /// <summary>
        ///  update a single product based on the ID supplied
        /// </summary>
        /// <param name="id">ID of product to update</param> 
        /// <param name="tax">Product to add to the store</param> 
        /// <returns></returns>            
        public void UpdateProductById (long? id, Product tax)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateProductById");
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling UpdateProductById");
            
    
            var path = "/products/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(tax); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  update a single product based on the ID supplied
        /// </summary>
        /// <param name="id">ID of product to update</param> 
        /// <param name="tax">Product to add to the store</param> 
        /// <returns></returns>            
        public void UpdateProductById_1 (long? id, Product tax)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateProductById_1");
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling UpdateProductById_1");
            
    
            var path = "/products/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(tax); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductById_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductById_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
