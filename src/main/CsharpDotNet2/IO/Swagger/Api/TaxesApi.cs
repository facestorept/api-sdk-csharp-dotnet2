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
    public interface ITaxesApi
    {
        /// <summary>
        ///  Creates a new tax in the store.
        /// </summary>
        /// <param name="tax">Tax to add to the store</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 AddTaxes (Tax tax);
        /// <summary>
        ///  deletes a single tax based on the ID supplied
        /// </summary>
        /// <param name="id">ID of tax to delete</param>
        /// <returns></returns>
        void DeleteTaxById (long? id);
        /// <summary>
        ///  Returns a tax based on a single ID
        /// </summary>
        /// <param name="id">ID of tax to fetch</param>
        /// <param name="limit">max records to return</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 GetTaxById (long? id, int? limit);
        /// <summary>
        ///  Returns all taxes from the system that the user has access to
        /// </summary>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetTaxes (List<string> includes, int? limit, List<string> orderBy);
        /// <summary>
        ///  update a single tax based on the ID supplied
        /// </summary>
        /// <param name="id">ID of tax to update</param>
        /// <param name="tax">Tax to add to the store</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 UpdateTaxById (long? id, Tax tax);
        /// <summary>
        ///  update a single tax based on the ID supplied
        /// </summary>
        /// <param name="id">ID of tax to update</param>
        /// <param name="tax">Tax to add to the store</param>
        /// <returns>InlineResponse2012</returns>
        InlineResponse2012 UpdateTaxById_1 (long? id, Tax tax);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TaxesApi : ITaxesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TaxesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaxesApi(String basePath)
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
        ///  Creates a new tax in the store.
        /// </summary>
        /// <param name="tax">Tax to add to the store</param> 
        /// <returns>InlineResponse2012</returns>            
        public InlineResponse2012 AddTaxes (Tax tax)
        {
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling AddTaxes");
            
    
            var path = "/taxes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(tax); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTaxes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTaxes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2012) ApiClient.Deserialize(response.Content, typeof(InlineResponse2012), response.Headers);
        }
    
        /// <summary>
        ///  deletes a single tax based on the ID supplied
        /// </summary>
        /// <param name="id">ID of tax to delete</param> 
        /// <returns></returns>            
        public void DeleteTaxById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTaxById");
            
    
            var path = "/taxes/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTaxById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTaxById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Returns a tax based on a single ID
        /// </summary>
        /// <param name="id">ID of tax to fetch</param> 
        /// <param name="limit">max records to return</param> 
        /// <returns>InlineResponse2012</returns>            
        public InlineResponse2012 GetTaxById (long? id, int? limit)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTaxById");
            
    
            var path = "/taxes/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTaxById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTaxById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2012) ApiClient.Deserialize(response.Content, typeof(InlineResponse2012), response.Headers);
        }
    
        /// <summary>
        ///  Returns all taxes from the system that the user has access to
        /// </summary>
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param> 
        /// <returns>InlineResponse2002</returns>            
        public InlineResponse2002 GetTaxes (List<string> includes, int? limit, List<string> orderBy)
        {
            
    
            var path = "/taxes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTaxes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTaxes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        ///  update a single tax based on the ID supplied
        /// </summary>
        /// <param name="id">ID of tax to update</param> 
        /// <param name="tax">Tax to add to the store</param> 
        /// <returns>InlineResponse2012</returns>            
        public InlineResponse2012 UpdateTaxById (long? id, Tax tax)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateTaxById");
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling UpdateTaxById");
            
    
            var path = "/taxes/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTaxById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTaxById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2012) ApiClient.Deserialize(response.Content, typeof(InlineResponse2012), response.Headers);
        }
    
        /// <summary>
        ///  update a single tax based on the ID supplied
        /// </summary>
        /// <param name="id">ID of tax to update</param> 
        /// <param name="tax">Tax to add to the store</param> 
        /// <returns>InlineResponse2012</returns>            
        public InlineResponse2012 UpdateTaxById_1 (long? id, Tax tax)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateTaxById_1");
            
            // verify the required parameter 'tax' is set
            if (tax == null) throw new ApiException(400, "Missing required parameter 'tax' when calling UpdateTaxById_1");
            
    
            var path = "/taxes/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTaxById_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTaxById_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2012) ApiClient.Deserialize(response.Content, typeof(InlineResponse2012), response.Headers);
        }
    
    }
}
