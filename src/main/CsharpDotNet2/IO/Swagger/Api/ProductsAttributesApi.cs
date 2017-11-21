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
    public interface IProductsAttributesApi
    {
        /// <summary>
        ///  Creates a new attribute of products in the store.
        /// </summary>
        /// <param name="attribute">Attribute to add to the store</param>
        /// <returns>List&lt;Attribute&gt;</returns>
        List<Attribute> AddProductsAttributes (Attribute attribute);
        /// <summary>
        ///  deletes a single attribute of products based on the ID supplied
        /// </summary>
        /// <param name="id">ID of attribute to delete</param>
        /// <returns></returns>
        void DeleteProductAttributeById (long? id);
        /// <summary>
        ///  Returns a attribute of products based on a single ID  ### Includes You can give the following values on includes parameter: &#x60;options&#x60; 
        /// </summary>
        /// <param name="id">ID of attribute to fetch</param>
        /// <param name="includes">Include associated objects within response</param>
        /// <returns>Attribute</returns>
        Attribute GetProductAttributeById (long? id, List<string> includes);
        /// <summary>
        ///  Returns all attributes of products from the system that the user has access to  ### Includes You can give the following values on includes parameter: &#x60;options&#x60; 
        /// </summary>
        /// <param name="includes">Include associated objects within response</param>
        /// <param name="limit">max records to return</param>
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param>
        /// <returns>List&lt;Attribute&gt;</returns>
        List<Attribute> GetProductsAttributes (List<string> includes, int? limit, List<string> orderBy);
        /// <summary>
        ///  update a single attribute of products based on the ID supplied
        /// </summary>
        /// <param name="id">ID of attribute to update</param>
        /// <param name="productAttribute">Attribute to add to the store</param>
        /// <returns>Attribute</returns>
        Attribute UpdateProductAttributeById (long? id, Attribute productAttribute);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ProductsAttributesApi : IProductsAttributesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsAttributesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ProductsAttributesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsAttributesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsAttributesApi(String basePath)
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
        ///  Creates a new attribute of products in the store.
        /// </summary>
        /// <param name="attribute">Attribute to add to the store</param> 
        /// <returns>List&lt;Attribute&gt;</returns>            
        public List<Attribute> AddProductsAttributes (Attribute attribute)
        {
            
            // verify the required parameter 'attribute' is set
            if (attribute == null) throw new ApiException(400, "Missing required parameter 'attribute' when calling AddProductsAttributes");
            
    
            var path = "/attributes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(attribute); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddProductsAttributes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddProductsAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Attribute>) ApiClient.Deserialize(response.Content, typeof(List<Attribute>), response.Headers);
        }
    
        /// <summary>
        ///  deletes a single attribute of products based on the ID supplied
        /// </summary>
        /// <param name="id">ID of attribute to delete</param> 
        /// <returns></returns>            
        public void DeleteProductAttributeById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteProductAttributeById");
            
    
            var path = "/attributes/{id}/";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProductAttributeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteProductAttributeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Returns a attribute of products based on a single ID  ### Includes You can give the following values on includes parameter: &#x60;options&#x60; 
        /// </summary>
        /// <param name="id">ID of attribute to fetch</param> 
        /// <param name="includes">Include associated objects within response</param> 
        /// <returns>Attribute</returns>            
        public Attribute GetProductAttributeById (long? id, List<string> includes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetProductAttributeById");
            
    
            var path = "/attributes/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includes != null) queryParams.Add("includes", ApiClient.ParameterToString(includes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductAttributeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductAttributeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Attribute) ApiClient.Deserialize(response.Content, typeof(Attribute), response.Headers);
        }
    
        /// <summary>
        ///  Returns all attributes of products from the system that the user has access to  ### Includes You can give the following values on includes parameter: &#x60;options&#x60; 
        /// </summary>
        /// <param name="includes">Include associated objects within response</param> 
        /// <param name="limit">max records to return</param> 
        /// <param name="orderBy">Specify the field to be sorted, examples:  - &#x60;?order_by&#x3D;id|desc&#x60; - &#x60;?order_by&#x3D;updated_at|desc,position|asc&#x60; </param> 
        /// <returns>List&lt;Attribute&gt;</returns>            
        public List<Attribute> GetProductsAttributes (List<string> includes, int? limit, List<string> orderBy)
        {
            
    
            var path = "/attributes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductsAttributes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetProductsAttributes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Attribute>) ApiClient.Deserialize(response.Content, typeof(List<Attribute>), response.Headers);
        }
    
        /// <summary>
        ///  update a single attribute of products based on the ID supplied
        /// </summary>
        /// <param name="id">ID of attribute to update</param> 
        /// <param name="productAttribute">Attribute to add to the store</param> 
        /// <returns>Attribute</returns>            
        public Attribute UpdateProductAttributeById (long? id, Attribute productAttribute)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateProductAttributeById");
            
            // verify the required parameter 'productAttribute' is set
            if (productAttribute == null) throw new ApiException(400, "Missing required parameter 'productAttribute' when calling UpdateProductAttributeById");
            
    
            var path = "/attributes/{id}/";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(productAttribute); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "APIKeyHeader" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductAttributeById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateProductAttributeById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Attribute) ApiClient.Deserialize(response.Content, typeof(Attribute), response.Headers);
        }
    
    }
}
