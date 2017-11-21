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
    public interface IBrandsApi
    {
        /// <summary>
        ///  Creates a new brand in the store.
        /// </summary>
        /// <param name="brand">Brand to add to the store</param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 AddBrands (Brand brand);
        /// <summary>
        ///  Deletes a single brand based on the ID supplied
        /// </summary>
        /// <param name="id">ID of brand to delete</param>
        /// <returns></returns>
        void DeleteBrandById (long? id);
        /// <summary>
        ///  Returns a brand based on a single ID  ### Includes You can give the following values on includea parameter: &#x60;routes, products&#x60; 
        /// </summary>
        /// <param name="id">ID of brand to fetch</param>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <returns>InlineResponse201</returns>
        InlineResponse201 GetBrandById (long? id, List<string> includes, int? limit);
        /// <summary>
        ///  Returns all brands from the system that the user has access to  ### Includes You can give the following values on includes parameter: &#x60;routes, products&#x60; 
        /// </summary>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetBrands (List<string> includes, int? limit, List<string> orderBy);
        /// <summary>
        ///  Update a single brand based on the ID supplied
        /// </summary>
        /// <param name="id">ID of brand to update</param>
        /// <param name="brand">Brand to update in store</param>
        /// <returns></returns>
        void UpdateCategoryById (long? id, Object brand);
        /// <summary>
        ///  Update a single brand based on the ID supplied
        /// </summary>
        /// <param name="id">ID of brand to update</param>
        /// <param name="brand">Brand to update in store</param>
        /// <returns></returns>
        void UpdateCategoryById_1 (long? id, Object brand);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BrandsApi : IBrandsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BrandsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BrandsApi(String basePath)
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
        ///  Creates a new brand in the store.
        /// </summary>
        /// <param name="brand">Brand to add to the store</param> 
        /// <returns>InlineResponse201</returns>            
        public InlineResponse201 AddBrands (Brand brand)
        {
            
            // verify the required parameter 'brand' is set
            if (brand == null) throw new ApiException(400, "Missing required parameter 'brand' when calling AddBrands");
            
    
            var path = "/brands";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(brand); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBrands: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddBrands: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse201) ApiClient.Deserialize(response.Content, typeof(InlineResponse201), response.Headers);
        }
    
        /// <summary>
        ///  Deletes a single brand based on the ID supplied
        /// </summary>
        /// <param name="id">ID of brand to delete</param> 
        /// <returns></returns>            
        public void DeleteBrandById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteBrandById");
            
    
            var path = "/brands/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBrandById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBrandById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Returns a brand based on a single ID  ### Includes You can give the following values on includea parameter: &#x60;routes, products&#x60; 
        /// </summary>
        /// <param name="id">ID of brand to fetch</param> 
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <returns>InlineResponse201</returns>            
        public InlineResponse201 GetBrandById (long? id, List<string> includes, int? limit)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetBrandById");
            
    
            var path = "/brands/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBrandById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBrandById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse201) ApiClient.Deserialize(response.Content, typeof(InlineResponse201), response.Headers);
        }
    
        /// <summary>
        ///  Returns all brands from the system that the user has access to  ### Includes You can give the following values on includes parameter: &#x60;routes, products&#x60; 
        /// </summary>
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param> 
        /// <returns>InlineResponse200</returns>            
        public InlineResponse200 GetBrands (List<string> includes, int? limit, List<string> orderBy)
        {
            
    
            var path = "/brands";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBrands: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBrands: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        ///  Update a single brand based on the ID supplied
        /// </summary>
        /// <param name="id">ID of brand to update</param> 
        /// <param name="brand">Brand to update in store</param> 
        /// <returns></returns>            
        public void UpdateCategoryById (long? id, Object brand)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCategoryById");
            
            // verify the required parameter 'brand' is set
            if (brand == null) throw new ApiException(400, "Missing required parameter 'brand' when calling UpdateCategoryById");
            
    
            var path = "/brands/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(brand); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCategoryById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCategoryById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Update a single brand based on the ID supplied
        /// </summary>
        /// <param name="id">ID of brand to update</param> 
        /// <param name="brand">Brand to update in store</param> 
        /// <returns></returns>            
        public void UpdateCategoryById_1 (long? id, Object brand)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateCategoryById_1");
            
            // verify the required parameter 'brand' is set
            if (brand == null) throw new ApiException(400, "Missing required parameter 'brand' when calling UpdateCategoryById_1");
            
    
            var path = "/brands/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(brand); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCategoryById_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateCategoryById_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
