using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.Workflows.Model;

namespace AdobeSign.Workflows.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class WorkflowsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public WorkflowsApi(ApiClient apiClient = null)
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
        /// Retrieves workflows for a user. 
        /// </summary>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="includeDraftWorkflows">Include draft workflows</param> 
        /// <param name="includeInactiveWorkflows">Include inactive workflows</param> 
        /// <param name="groupId">The group identifier for which the workflows will be fetched</param> 
        /// <returns>UserWorkflows</returns>            
        public UserWorkflows GetWorkflows (bool? includeDraftWorkflows = null, bool? includeInactiveWorkflows = null, string groupId = null, string xApiUser = null)
        {
            
            // verify the required parameter 'authorization' is set
            
            
    
            var path = "/workflows";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeDraftWorkflows != null) queryParams.Add("includeDraftWorkflows", ApiClient.ParameterToString(includeDraftWorkflows)); // query parameter
 if (includeInactiveWorkflows != null) queryParams.Add("includeInactiveWorkflows", ApiClient.ParameterToString(includeInactiveWorkflows)); // query parameter
 if (groupId != null) queryParams.Add("groupId", ApiClient.ParameterToString(groupId)); // query parameter
             
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
                            
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWorkflows: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetWorkflows: " + response.ErrorMessage, response.ErrorMessage);
    
            return (UserWorkflows) ApiClient.Deserialize(response.Content, typeof(UserWorkflows), response.Headers);
        }
    
    }
}
