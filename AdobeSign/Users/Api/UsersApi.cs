using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.Users.Model;

namespace AdobeSign.Users.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
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
        /// Retrieves the groups of the user. 
        /// </summary>
        /// <param name="userId">The user identifier, as returned by the user creation API or retrieved from the API to fetch users. To get the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns>UserGroupsInfo</returns>            
        public UserGroupsInfo GetGroupsOfUser(string userId, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetGroupsOfUser");


            var path = "/users/{userId}/groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetGroupsOfUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetGroupsOfUser: " + response.ErrorMessage, response.ErrorMessage);

            return (UserGroupsInfo)ApiClient.Deserialize(response.Content, typeof(UserGroupsInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves detailed information about the user in the caller account. 
        /// </summary>
        /// <param name="userId">The user identifier, as returned by the user creation API or retrieved from the API to fetch users. To get the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns>DetailedUserInfo</returns>            
        public DetailedUserInfo GetUserDetail(string userId, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserDetail");


            var path = "/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetUserDetail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetUserDetail: " + response.ErrorMessage, response.ErrorMessage);

            return (DetailedUserInfo)ApiClient.Deserialize(response.Content, typeof(DetailedUserInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the URL of manage, account settings and user profile page. 
        /// </summary>
        /// <param name="userId">The user identifier, as returned by the user creation API or retrieved from the API to fetch users. To get the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.</param> 
        /// <param name="userViewInfo">Name of the required view and its desired configuration.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>UserViewResponse</returns>            
        public UserViewResponse GetUserViews(string userId, UserViewInfo userViewInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling GetUserViews");

            // verify the required parameter 'userViewInfo' is set
            if (userViewInfo == null) throw new ApiException(400, "Missing required parameter 'userViewInfo' when calling GetUserViews");


            var path = "/users/{userId}/views";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(userViewInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetUserViews: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetUserViews: " + response.ErrorMessage, response.ErrorMessage);

            return (UserViewResponse)ApiClient.Deserialize(response.Content, typeof(UserViewResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves all the users in an account. 
        /// </summary>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>UsersInfo</returns>            
        public UsersInfo GetUsers(string cursor = null, int? pageSize = null, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set



            var path = "/users";
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
                throw new ApiException((int)response.StatusCode, "Error calling GetUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetUsers: " + response.ErrorMessage, response.ErrorMessage);

            return (UsersInfo)ApiClient.Deserialize(response.Content, typeof(UsersInfo), response.Headers);
        }

        /// <summary>
        /// Update an user. 
        /// </summary>
        /// <param name="userId">The user identifier, as provided by GET /users or POST /users</param> 
        /// <param name="detailedUserInfo">Information necessary to update a user.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns></returns>            
        public void ModifyUser(string userId, DetailedUserInfo detailedUserInfo, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ModifyUser");

            // verify the required parameter 'detailedUserInfo' is set
            if (detailedUserInfo == null) throw new ApiException(400, "Missing required parameter 'detailedUserInfo' when calling ModifyUser");


            var path = "/users/{userId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(detailedUserInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ModifyUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ModifyUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Activate/Deactivate a given user. 
        /// </summary>
        /// <param name="userId">The user identifier, as returned by the user creation API or retrieved from the API to fetch users. To update the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.</param> 
        /// <param name="userStateInfo"></param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns>UserStatusUpdateResponse</returns>            
        public UserStatusUpdateResponse ModifyUserState(string userId, UserStateInfo userStateInfo, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling ModifyUserState");

            // verify the required parameter 'userStateInfo' is set
            if (userStateInfo == null) throw new ApiException(400, "Missing required parameter 'userStateInfo' when calling ModifyUserState");


            var path = "/users/{userId}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(userStateInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling ModifyUserState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling ModifyUserState: " + response.ErrorMessage, response.ErrorMessage);

            return (UserStatusUpdateResponse)ApiClient.Deserialize(response.Content, typeof(UserStatusUpdateResponse), response.Headers);
        }

        /// <summary>
        /// Updates the groups of the user. 
        /// </summary>
        /// <param name="userId">The user identifier, as returned by the user creation API or retrieved from the API to fetch users. To update the details for the token owner, UserId can be replaced by \&quot;me\&quot; without quotes.</param> 
        /// <param name="userGroupsInfo"></param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns></returns>            
        public void UpdateGroupsOfUser(string userId, UserGroupsInfo userGroupsInfo, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'userId' is set
            if (userId == null) throw new ApiException(400, "Missing required parameter 'userId' when calling UpdateGroupsOfUser");

            // verify the required parameter 'userGroupsInfo' is set
            if (userGroupsInfo == null) throw new ApiException(400, "Missing required parameter 'userGroupsInfo' when calling UpdateGroupsOfUser");


            var path = "/users/{userId}/groups";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "userId" + "}", ApiClient.ParameterToString(userId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(userGroupsInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateGroupsOfUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateGroupsOfUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
