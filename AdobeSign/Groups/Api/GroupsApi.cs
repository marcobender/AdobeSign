using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.Groups.Model;

namespace AdobeSign.Groups.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GroupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public GroupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                throw new ArgumentNullException("apiClient");
            this.ApiClient = apiClient;
        }



        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        internal ApiClient ApiClient { get; set; }

        /// <summary>
        /// Retrieves detailed information about the group. 
        /// </summary>
        /// <param name="groupId">The group identifier, as returned by the group creation API or retrieved from the API to fetch groups</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns>DetailedGroupInfo</returns>            
        public DetailedGroupInfo GetGroupDetails(string groupId, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GetGroupDetails");


            var path = "/groups/{groupId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetGroupDetails: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetGroupDetails: " + response.ErrorMessage, response.ErrorMessage);

            return (DetailedGroupInfo)ApiClient.Deserialize(response.Content, typeof(DetailedGroupInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves all the groups in an account. 
        /// </summary>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>GroupsInfo</returns>            
        public GroupsInfo GetGroups(string cursor = null, int? pageSize = 0, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set



            var path = "/groups";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetGroups: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupsInfo)ApiClient.Deserialize(response.Content, typeof(GroupsInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves all the users in a group. 
        /// </summary>
        /// <param name="groupId">The group identifier, as returned by the group creation API or retrieved from the API to fetch groups</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>GroupUsersInfo</returns>            
        public GroupUsersInfo GetUsersInGroup(string groupId, string cursor = null, int? pageSize = null, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'groupId' is set
            if (groupId == null) throw new ApiException(400, "Missing required parameter 'groupId' when calling GetUsersInGroup");


            var path = "/groups/{groupId}/users";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "groupId" + "}", ApiClient.ParameterToString(groupId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetUsersInGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetUsersInGroup: " + response.ErrorMessage, response.ErrorMessage);

            return (GroupUsersInfo)ApiClient.Deserialize(response.Content, typeof(GroupUsersInfo), response.Headers);
        }

    }
}
