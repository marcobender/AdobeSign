using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.Webhooks.Model;

namespace AdobeSign.Webhooks.Api
{
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WebhooksApi 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhooksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public WebhooksApi(ApiClient apiClient = null)
        {

            if (apiClient == null) // use the default one in Configuration
                throw new ArgumentNullException("apiClient");
            this.ApiClient = apiClient;
        }


        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        internal ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Creates a webhook. 
        /// </summary>
        /// <param name="webhookInfo">Information about the webhook that you want to create</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>WebhookCreationResponse</returns>            
        public WebhookCreationResponse CreateWebhook (WebhookInfo webhookInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
            // verify the required parameter 'webhookInfo' is set
            if (webhookInfo == null) throw new ApiException(400, "Missing required parameter 'webhookInfo' when calling CreateWebhook");
            
    
            var path = "/webhooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                        postBody = ApiClient.Serialize(webhookInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebhookCreationResponse) ApiClient.Deserialize(response.Content, typeof(WebhookCreationResponse), response.Headers);
        }
    
        /// <summary>
        /// Deletes a webhook. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="webhookId">The webhook identifier, as returned by the webhook creation API or retrieved from the API to fetch webhooks.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void DeleteWebhook (string ifMatch, string webhookId, string xApiUser = null, string xOnBehalfOfUser = null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling DeleteWebhook");
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling DeleteWebhook");
            
    
            var path = "/webhooks/{webhookId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Retrieves the details of a webhook. 
        /// </summary>
        /// <param name="webhookId">The webhook identifier, as returned by the webhook creation API or retrieved from the API to fetch webhooks.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>WebhookInfo</returns>            
        public WebhookInfo GetWebhookInfo (string webhookId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch =null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling GetWebhookInfo");
            
    
            var path = "/webhooks/{webhookId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhookInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhookInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (WebhookInfo) ApiClient.Deserialize(response.Content, typeof(WebhookInfo), response.Headers);
        }
    
        /// <summary>
        /// Retrieves webhooks for a user. 
        /// </summary>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="showInActiveWebhooks">A query parameter to fetch all the inactive webhooks along with the active webhooks.</param> 
        /// <param name="scope">Scope of webhook. The possible values are ACCOUNT, GROUP, USER or RESOURCE</param> 
        /// <param name="resourceType">The type of resource on which webhook was created. The possible values are AGREEMENT, WIDGET, MEGASIGN and LIBRARY_DOCUMENT.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>UserWebhooks</returns>            
        public UserWebhooks GetWebhooks (bool? showInActiveWebhooks = null, string scope = null, string resourceType = null, string cursor = null, int? pageSize = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
    
            var path = "/webhooks";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (showInActiveWebhooks != null) queryParams.Add("showInActiveWebhooks", ApiClient.ParameterToString(showInActiveWebhooks)); // query parameter
 if (scope != null) queryParams.Add("scope", ApiClient.ParameterToString(scope)); // query parameter
 if (resourceType != null) queryParams.Add("resourceType", ApiClient.ParameterToString(resourceType)); // query parameter
 if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
 if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
             
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhooks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWebhooks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserWebhooks) ApiClient.Deserialize(response.Content, typeof(UserWebhooks), response.Headers);
        }
    
        /// <summary>
        /// Updates a webhook. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="webhookId">The webhook identifier, as returned by the webhook creation API or retrieved from the API to fetch webhooks.</param> 
        /// <param name="webhookInfo">Information necessary to update a webhook</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateWebhook (string ifMatch, string webhookId, WebhookInfo webhookInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateWebhook");
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling UpdateWebhook");
            
            // verify the required parameter 'webhookInfo' is set
            if (webhookInfo == null) throw new ApiException(400, "Missing required parameter 'webhookInfo' when calling UpdateWebhook");
            
    
            var path = "/webhooks/{webhookId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
                        postBody = ApiClient.Serialize(webhookInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWebhook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWebhook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the state of a webhook identified by webhookId in the path. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="webhookId">The webhook identifier, as returned by the webhook creation API or retrieved from the API to fetch webhooks.</param> 
        /// <param name="webhookStateInfo"></param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateWebhookState (string ifMatch, string webhookId, WebhookStateInfo webhookStateInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateWebhookState");
            
            // verify the required parameter 'webhookId' is set
            if (webhookId == null) throw new ApiException(400, "Missing required parameter 'webhookId' when calling UpdateWebhookState");
            
            // verify the required parameter 'webhookStateInfo' is set
            if (webhookStateInfo == null) throw new ApiException(400, "Missing required parameter 'webhookStateInfo' when calling UpdateWebhookState");
            
    
            var path = "/webhooks/{webhookId}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "webhookId" + "}", ApiClient.ParameterToString(webhookId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
 if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
                        postBody = ApiClient.Serialize(webhookStateInfo); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWebhookState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateWebhookState: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
