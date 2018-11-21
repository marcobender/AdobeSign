using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.MegaSigns.Model;

namespace AdobeSign.MegaSigns.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MegaSignsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MegaSignsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public MegaSignsApi(ApiClient apiClient = null)
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
        /// Send an agreement out for signature to multiple recipients. Each recipient will receive and sign their own copy of the agreement. This is a primary endpoint which is used to create a new megaSign. A megaSign can be created using transientDocument, libraryDocument or a URL. You can create a megaSign in &lt;b&gt;IN_PROCESS&lt;/b&gt; - Create a megaSign in this state to immediately send it. You can use the PUT/megaSigns/{megaSignId}/state endpoint to transition the state of megaSign. An allowed transition would follow the following sequence: IN_PROCESS -&gt; CANCELLED.
        /// </summary>
        /// <param name="megaSignInfo">Information about the MegaSign that you want to send.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>MegaSignCreationResponse</returns>            
        public MegaSignCreationResponse CreateMegaSign(MegaSignCreationInfo megaSignInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignInfo' is set
            if (megaSignInfo == null) throw new ApiException(400, "Missing required parameter 'megaSignInfo' when calling CreateMegaSign");


            var path = "/megaSigns";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(megaSignInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateMegaSign: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateMegaSign: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignCreationResponse)ApiClient.Deserialize(response.Content, typeof(MegaSignCreationResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves the file stream of the original childAgreementsInfoFile that was uploaded by sender while creating the MegaSign. CSV file stream containing form data information
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="childAgreementsInfoFileId">The identifier of the childAgreementsInfoFile that has been uploaded by sender while creating the megaSign or retrieved from the API to fetch megaSignInfo </param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetChildAgreementsInfoFile(string megaSignId, string childAgreementsInfoFileId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetChildAgreementsInfoFile");

            // verify the required parameter 'childAgreementsInfoFileId' is set
            if (childAgreementsInfoFileId == null) throw new ApiException(400, "Missing required parameter 'childAgreementsInfoFileId' when calling GetChildAgreementsInfoFile");


            var path = "/megaSigns/{megaSignId}/childAgreementsInfo/{childAgreementsInfoFileId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));
            path = path.Replace("{" + "childAgreementsInfoFileId" + "}", ApiClient.ParameterToString(childAgreementsInfoFileId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            headerParams.Add("Accept", "application/pdf");

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetChildAgreementsInfoFile: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetChildAgreementsInfoFile: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves the events information for the MegaSign parent agreement. 
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>MegasignEventList</returns>            
        public MegasignEventList GetEvents(string megaSignId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetEvents");


            var path = "/megaSigns/{megaSignId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetEvents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetEvents: " + response.ErrorMessage, response.ErrorMessage);

            return (MegasignEventList)ApiClient.Deserialize(response.Content, typeof(MegasignEventList), response.Headers);
        }

        /// <summary>
        /// Get all the child agreements of the specified MegaSign parent agreement. 
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>MegaSignChildAgreements</returns>            
        public MegaSignChildAgreements GetMegaSignChildAgreements(string megaSignId, string cursor = null, int? pageSize = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignChildAgreements");


            var path = "/megaSigns/{megaSignId}/agreements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignChildAgreements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignChildAgreements: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignChildAgreements)ApiClient.Deserialize(response.Content, typeof(MegaSignChildAgreements), response.Headers);
        }

        /// <summary>
        /// Retrieves a single combined PDF document for the documents associated with the MegaSign parent agreement. 
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="attachAuditReport">When set to true attach an audit report to the MegaSign document PDF. Default value will be false.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetMegaSignCombinedDocument(string megaSignId, bool? attachAuditReport = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignCombinedDocument");


            var path = "/megaSigns/{megaSignId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (attachAuditReport != null) queryParams.Add("attachAuditReport", ApiClient.ParameterToString(attachAuditReport)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            headerParams.Add("Accept", "application/pdf");

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignCombinedDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }
        /// <summary>
        /// Retrieves data entered by recipients into interactive form fields at the time they signed the child agreements of the specified MegaSign agreement CSV file stream containing form data information
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetMegaSignFormData(string megaSignId, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignFormData");


            var path = "/megaSigns/{megaSignId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            headerParams.Add("Accept", "application/pdf");

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignFormData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignFormData: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Get detailed information of the specified MegaSign parent agreement. 
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>MegaSignCreationInfo</returns>            
        public MegaSignCreationInfo GetMegaSignInfo(string megaSignId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignInfo");


            var path = "/megaSigns/{megaSignId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignCreationInfo)ApiClient.Deserialize(response.Content, typeof(MegaSignCreationInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the requested views of mega sign agreement. 
        /// </summary>
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="megaSignViewInfo">Name of the required view and its desired configuration.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>MegaSignViewResponse</returns>            
        public MegaSignViewResponse GetMegaSignView(string megaSignId, MegaSignViewInfo megaSignViewInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling GetMegaSignView");

            // verify the required parameter 'megaSignViewInfo' is set
            if (megaSignViewInfo == null) throw new ApiException(400, "Missing required parameter 'megaSignViewInfo' when calling GetMegaSignView");


            var path = "/megaSigns/{megaSignId}/views";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(megaSignViewInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignView: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSignView: " + response.ErrorMessage, response.ErrorMessage);

            return (MegaSignViewResponse)ApiClient.Deserialize(response.Content, typeof(MegaSignViewResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves MegaSign parent agreements for a user. 
        /// </summary>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>MegaSigns</returns>            
        public AdobeSign.MegaSigns.Model.MegaSigns GetMegaSigns(string cursor = null, int? pageSize = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set



            var path = "/megaSigns";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSigns: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMegaSigns: " + response.ErrorMessage, response.ErrorMessage);

            return (AdobeSign.MegaSigns.Model.MegaSigns)ApiClient.Deserialize(response.Content, typeof(AdobeSign.MegaSigns.Model.MegaSigns), response.Headers);
        }

        /// <summary>
        /// Updates the state of a MegaSign identified by MegaSignId in the path. This endpoint can be used by creator of the MegaSign to transition between the states of megaSign. An allowed transition would follow the following sequence :  IN_PROCESS-&gt;CANCELLED.
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="megaSignId">The identifier of the MegaSign parent agreement, as returned by the megaSign creation API or retrieved from the API to fetch megaSign agreements</param> 
        /// <param name="megaSignStateInfo">MegaSign state update information object.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateMegaSignState(string ifMatch, string megaSignId, MegaSignStateInfo megaSignStateInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateMegaSignState");

            // verify the required parameter 'megaSignId' is set
            if (megaSignId == null) throw new ApiException(400, "Missing required parameter 'megaSignId' when calling UpdateMegaSignState");

            // verify the required parameter 'megaSignStateInfo' is set
            if (megaSignStateInfo == null) throw new ApiException(400, "Missing required parameter 'megaSignStateInfo' when calling UpdateMegaSignState");


            var path = "/megaSigns/{megaSignId}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "megaSignId" + "}", ApiClient.ParameterToString(megaSignId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(megaSignStateInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateMegaSignState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateMegaSignState: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
