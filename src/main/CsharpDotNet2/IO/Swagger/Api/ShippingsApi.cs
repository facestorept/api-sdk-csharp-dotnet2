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
    public interface IShippingsApi
    {
        /// <summary>
        ///  Creates a new shipping in the store.
        /// </summary>
        /// <param name="shipping">Shipping to add to the store</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 AddShipping (Shipping shipping);
        /// <summary>
        ///  deletes a single shipping based on the ID supplied
        /// </summary>
        /// <param name="id">ID of shipping to delete</param>
        /// <returns></returns>
        void DeleteShippingById (long? id);
        /// <summary>
        ///  Returns a shipping based on a single ID
        /// </summary>
        /// <param name="id">ID of shipping to fetch</param>
        /// <param name="limit">max records to return</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 GetShippingById (long? id, int? limit);
        /// <summary>
        ///  Returns all shippings from the system that the user has access to
        /// </summary>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetShippings (List<string> includes, int? limit, List<string> orderBy);
        /// <summary>
        ///  update a single shipping based on the ID supplied
        /// </summary>
        /// <param name="id">ID of shipping to update</param>
        /// <param name="tax">Shipping to update in store</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 UpdateShippingById (long? id, Shipping tax);
        /// <summary>
        ///  update a single shipping based on the ID supplied
        /// </summary>
        /// <param name="id">ID of shipping to update</param>
        /// <param name="tax">Shipping to update in store</param>
        /// <returns>InlineResponse2013</returns>
        InlineResponse2013 UpdateShippingById_1 (long? id, Shipping tax);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ShippingsApi : IShippingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ShippingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShippingsApi(String basePath)
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
        ///  Creates a new shipping in the store.
        /// </summary>
        /// <param name="shipping">Shipping to add to the store</param> 
        /// <returns>InlineResponse2013</returns>            
        public InlineResponse2013 AddShipping (Shipping shipping)
        {
            
            // verify the required parameter 'shipping' is set
            if (shipping == null) throw new ApiException(400, "Missing required parameter 'shipping' when calling AddShipping");
            
    
            var path = "/shippings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(shipping); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddShipping: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddShipping: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2013) ApiClient.Deserialize(response.Content, typeof(InlineResponse2013), response.Headers);
        }
    
        /// <summary>
        ///  deletes a single shipping based on the ID supplied
        /// </summary>
        /// <param name="id">ID of shipping to delete</param> 
        /// <returns></returns>            
        public void DeleteShippingById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteShippingById");
            
    
            var path = "/shippings/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteShippingById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteShippingById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Returns a shipping based on a single ID
        /// </summary>
        /// <param name="id">ID of shipping to fetch</param> 
        /// <param name="limit">max records to return</param> 
        /// <returns>InlineResponse2013</returns>            
        public InlineResponse2013 GetShippingById (long? id, int? limit)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetShippingById");
            
    
            var path = "/shippings/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippingById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2013) ApiClient.Deserialize(response.Content, typeof(InlineResponse2013), response.Headers);
        }
    
        /// <summary>
        ///  Returns all shippings from the system that the user has access to
        /// </summary>
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param> 
        /// <returns>InlineResponse2003</returns>            
        public InlineResponse2003 GetShippings (List<string> includes, int? limit, List<string> orderBy)
        {
            
    
            var path = "/shippings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetShippings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        ///  update a single shipping based on the ID supplied
        /// </summary>
        /// <param name="id">ID of shipping to update</param> 
        /// <param name="tax">Shipping to update in store</param> 
        /// <returns>InlineResponse2013</returns>            
        public InlineResponse2013 UpdateShippingById (long? id, Shipping tax)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateShippingById");
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling UpdateShippingById");
            
    
            var path = "/shippings/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2013) ApiClient.Deserialize(response.Content, typeof(InlineResponse2013), response.Headers);
        }
    
        /// <summary>
        ///  update a single shipping based on the ID supplied
        /// </summary>
        /// <param name="id">ID of shipping to update</param> 
        /// <param name="tax">Shipping to update in store</param> 
        /// <returns>InlineResponse2013</returns>            
        public InlineResponse2013 UpdateShippingById_1 (long? id, Shipping tax)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateShippingById_1");
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling UpdateShippingById_1");
            
    
            var path = "/shippings/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingById_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateShippingById_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2013) ApiClient.Deserialize(response.Content, typeof(InlineResponse2013), response.Headers);
        }
    
    }
}
