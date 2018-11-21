using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.Agreements.Model;

namespace AdobeSign.Agreements.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AgreementsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public AgreementsApi(ApiClient apiClient = null)
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
        /// Adds template fields to an agreement 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="formFieldPostInfo">List of form fields to add or replace</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>AgreementFormFields</returns>            
        public AgreementFormFields AddTemplateFieldsToAgreement(string ifMatch, string agreementId, FormFieldPostInfo formFieldPostInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling AddTemplateFieldsToAgreement");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling AddTemplateFieldsToAgreement");

            // verify the required parameter 'formFieldPostInfo' is set
            if (formFieldPostInfo == null) throw new ApiException(400, "Missing required parameter 'formFieldPostInfo' when calling AddTemplateFieldsToAgreement");


            var path = "/agreements/{agreementId}/formFields";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(formFieldPostInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling AddTemplateFieldsToAgreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling AddTemplateFieldsToAgreement: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementFormFields)ApiClient.Deserialize(response.Content, typeof(AgreementFormFields), response.Headers);
        }

        /// <summary>
        /// Creates an agreement. Sends it out for signatures, and returns the agreementID in the response to the client. This is a primary endpoint which is used to create a new agreement. An agreement can be created using transientDocument, libraryDocument or a URL. You can create an agreement in one of the 3 mentioned states: a) &lt;b&gt;DRAFT&lt;/b&gt; - to incrementally build the agreement before sending out, b) &lt;b&gt;AUTHORING&lt;/b&gt; - to add/edit form fields in the agreement, c) &lt;b&gt;IN_PROCESS&lt;/b&gt; - to immediately send the agreement. You can use the PUT /agreements/{agreementId}/state endpoint to transition an agreement between the above mentioned states. An allowed transition would follow the following sequence: DRAFT -&gt; AUTHORING -&gt; IN_PROCESS -&gt; CANCELLED.
        /// </summary>
        /// <param name="agreementInfo">Information about the agreement that you want to create.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>AgreementCreationResponse</returns>            
        public AgreementCreationResponse CreateAgreement(AgreementCreationInfo agreementInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementInfo' is set
            if (agreementInfo == null) throw new ApiException(400, "Missing required parameter 'agreementInfo' when calling CreateAgreement");


            var path = "/agreements";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(agreementInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAgreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAgreement: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementCreationResponse)ApiClient.Deserialize(response.Content, typeof(AgreementCreationResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves the latest state view url of agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="agreementViewInfo">Name of the required view and its desired configuration.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>AgreementViews</returns>            
        public AgreementViews CreateAgreementView(string agreementId, AgreementViewInfo agreementViewInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling CreateAgreementView");

            // verify the required parameter 'agreementViewInfo' is set
            if (agreementViewInfo == null) throw new ApiException(400, "Missing required parameter 'agreementViewInfo' when calling CreateAgreementView");


            var path = "/agreements/{agreementId}/views";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(agreementViewInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAgreementView: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateAgreementView: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementViews)ApiClient.Deserialize(response.Content, typeof(AgreementViews), response.Headers);
        }

        /// <summary>
        /// Creates a participantSet to which the agreement is forwarded for taking appropriate action. Participants marked as delegator can call this API endpoint.
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="participantSetId">The participant set identifier</param> 
        /// <param name="delegatedParticipantSetInfo">Information about the delegate participant Set</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns>DelegationResponse</returns>            
        public DelegationResponse CreateDelegatedParticipantSets(string agreementId, string participantSetId, DelegatedParticipantSetInfo delegatedParticipantSetInfo, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling CreateDelegatedParticipantSets");

            // verify the required parameter 'participantSetId' is set
            if (participantSetId == null) throw new ApiException(400, "Missing required parameter 'participantSetId' when calling CreateDelegatedParticipantSets");

            // verify the required parameter 'delegatedParticipantSetInfo' is set
            if (delegatedParticipantSetInfo == null) throw new ApiException(400, "Missing required parameter 'delegatedParticipantSetInfo' when calling CreateDelegatedParticipantSets");


            var path = "/agreements/{agreementId}/members/participantSets/{participantSetId}/delegatedParticipantSets";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "participantSetId" + "}", ApiClient.ParameterToString(participantSetId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(delegatedParticipantSetInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateDelegatedParticipantSets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateDelegatedParticipantSets: " + response.ErrorMessage, response.ErrorMessage);

            return (DelegationResponse)ApiClient.Deserialize(response.Content, typeof(DelegationResponse), response.Headers);
        }

        /// <summary>
        /// Creates a reminder on the specified participants of an agreement identified by agreementId in the path. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="reminderInfo">The information about a reminder associated with a recipient of an agreement.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>ReminderCreationResult</returns>            
        public ReminderCreationResult CreateReminderOnParticipant(string agreementId, ReminderInfo reminderInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling CreateReminderOnParticipant");

            // verify the required parameter 'reminderInfo' is set
            if (reminderInfo == null) throw new ApiException(400, "Missing required parameter 'reminderInfo' when calling CreateReminderOnParticipant");


            var path = "/agreements/{agreementId}/reminders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(reminderInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateReminderOnParticipant: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateReminderOnParticipant: " + response.ErrorMessage, response.ErrorMessage);

            return (ReminderCreationResult)ApiClient.Deserialize(response.Content, typeof(ReminderCreationResult), response.Headers);
        }

        /// <summary>
        /// Share an agreement with someone. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="shareCreationInfoList">List of agreement share creation information objects.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>ShareCreationResponseList</returns>            
        public ShareCreationResponseList CreateShareOnAgreement(string agreementId, ShareCreationInfoList shareCreationInfoList, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling CreateShareOnAgreement");

            // verify the required parameter 'shareCreationInfoList' is set
            if (shareCreationInfoList == null) throw new ApiException(400, "Missing required parameter 'shareCreationInfoList' when calling CreateShareOnAgreement");


            var path = "/agreements/{agreementId}/members/share";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(shareCreationInfoList); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateShareOnAgreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateShareOnAgreement: " + response.ErrorMessage, response.ErrorMessage);

            return (ShareCreationResponseList)ApiClient.Deserialize(response.Content, typeof(ShareCreationResponseList), response.Headers);
        }

        /// <summary>
        /// Deletes all the documents of an agreement. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void DeleteDocuments(string ifMatch, string agreementId, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling DeleteDocuments");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling DeleteDocuments");


            var path = "/agreements/{agreementId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling DeleteDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Retrieves the current status of an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>AgreementInfo</returns>            
        public AgreementInfo GetAgreementInfo(string agreementId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAgreementInfo");


            var path = "/agreements/{agreementId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementInfo)ApiClient.Deserialize(response.Content, typeof(AgreementInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the latest note associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>Note</returns>            
        public Note GetAgreementNoteForApiUser(string agreementId, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAgreementNoteForApiUser");


            var path = "/agreements/{agreementId}/me/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementNoteForApiUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementNoteForApiUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Note)ApiClient.Deserialize(response.Content, typeof(Note), response.Headers);
        }

        /// <summary>
        /// Retrieves a specific reminder associated with an agreement 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="reminderId">The reminder identifier</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>ReminderInfo</returns>            
        public ReminderInfo GetAgreementReminder(string agreementId, string reminderId, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAgreementReminder");

            // verify the required parameter 'reminderId' is set
            if (reminderId == null) throw new ApiException(400, "Missing required parameter 'reminderId' when calling GetAgreementReminder");


            var path = "/agreements/{agreementId}/reminders/{reminderId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "reminderId" + "}", ApiClient.ParameterToString(reminderId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementReminder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementReminder: " + response.ErrorMessage, response.ErrorMessage);

            return (ReminderInfo)ApiClient.Deserialize(response.Content, typeof(ReminderInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the reminders of an agreement, identified by agreementId in the path. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="status">A comma-separated list of reminder statuses of the reminders which should be returned in the response. Currently supported values are ACTIVE, CANCELLED, COMPLETE</param> 
        /// <returns>RemindersResponse</returns>            
        public RemindersResponse GetAgreementReminders(string agreementId, string status, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAgreementReminders");


            var path = "/agreements/{agreementId}/reminders";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementReminders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreementReminders: " + response.ErrorMessage, response.ErrorMessage);

            return (RemindersResponse)ApiClient.Deserialize(response.Content, typeof(RemindersResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves agreements for the user. 
        /// </summary>
        /// <param name="externalId">Case-sensitive ExternalID for which you would like to retrieve agreement information. ExternalId is passed in the call to the agreement creation API.</param> 
        /// <param name="showHiddenAgreements">A query parameter to fetch all the hidden agreements along with the visible agreements. Default value is false.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>UserAgreements</returns>            
        public UserAgreements GetAgreements(string externalId = null, bool? showHiddenAgreements = null, string cursor = null, int? pageSize = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {



            var path = "/agreements";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (externalId != null) queryParams.Add("externalId", ApiClient.ParameterToString(externalId)); // query parameter
            if (showHiddenAgreements != null) queryParams.Add("showHiddenAgreements", ApiClient.ParameterToString(showHiddenAgreements)); // query parameter
            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAgreements: " + response.ErrorMessage, response.ErrorMessage);

            return (UserAgreements)ApiClient.Deserialize(response.Content, typeof(UserAgreements), response.Headers);
        }

        /// <summary>
        /// Retrieves the IDs of the documents of an agreement identified by agreementId. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param> 
        /// <param name="participantId">The participant identifier to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param> 
        /// <param name="supportingDocumentContentFormat">Content format of the supported documents. It can have two possible values ORIGINAL or CONVERTED_PDF. Default value is CONVERTED_PDF.</param> 
        /// <returns>AgreementDocuments</returns>            
        public AgreementDocuments GetAllDocuments(string agreementId, string versionId, string participantId, string supportingDocumentContentFormat, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAllDocuments");


            var path = "/agreements/{agreementId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantId != null) queryParams.Add("participantId", ApiClient.ParameterToString(participantId)); // query parameter
            if (supportingDocumentContentFormat != null) queryParams.Add("supportingDocumentContentFormat", ApiClient.ParameterToString(supportingDocumentContentFormat)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementDocuments)ApiClient.Deserialize(response.Content, typeof(AgreementDocuments), response.Headers);
        }

        /// <summary>
        /// Retrieves image urls of all visible pages of all the documents associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param> 
        /// <param name="participantId">The participant identifier to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param> 
        /// <param name="imageSizes">A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}. </param> 
        /// <param name="includeSupportingDocumentsImageUrls">When set to true, returns image urls of supporting documents as well. Else, returns image urls of only the original documents.</param> 
        /// <param name="showImageAvailabilityOnly">When set to true, returns only image availability. Else, returns both image urls and its availability.</param> 
        /// <returns>DocumentsImageUrlsInfo</returns>            
        public DocumentsImageUrlsInfo GetAllDocumentsImageUrls(string agreementId, string participantId = null, string imageSizes = null, bool? includeSupportingDocumentsImageUrls = null, bool? showImageAvailabilityOnly = null, string versionId = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAllDocumentsImageUrls");


            var path = "/agreements/{agreementId}/documents/imageUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantId != null) queryParams.Add("participantId", ApiClient.ParameterToString(participantId)); // query parameter
            if (imageSizes != null) queryParams.Add("imageSizes", ApiClient.ParameterToString(imageSizes)); // query parameter
            if (includeSupportingDocumentsImageUrls != null) queryParams.Add("includeSupportingDocumentsImageUrls", ApiClient.ParameterToString(includeSupportingDocumentsImageUrls)); // query parameter
            if (showImageAvailabilityOnly != null) queryParams.Add("showImageAvailabilityOnly", ApiClient.ParameterToString(showImageAvailabilityOnly)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllDocumentsImageUrls: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllDocumentsImageUrls: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentsImageUrlsInfo)ApiClient.Deserialize(response.Content, typeof(DocumentsImageUrlsInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves information of members of the agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="includeNextParticipantSet">A query parameter to fetch next active participation members. Default value is false.</param> 
        /// <returns>MembersInfo</returns>            
        public MembersInfo GetAllMembers(string agreementId, bool? includeNextParticipantSet = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAllMembers");


            var path = "/agreements/{agreementId}/members";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (includeNextParticipantSet != null) queryParams.Add("includeNextParticipantSet", ApiClient.ParameterToString(includeNextParticipantSet)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllMembers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAllMembers: " + response.ErrorMessage, response.ErrorMessage);

            return (MembersInfo)ApiClient.Deserialize(response.Content, typeof(MembersInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the audit trail of an agreement identified by agreementId. PDF file stream containing audit trail information
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetAuditTrail(string agreementId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetAuditTrail");


            var path = "/agreements/{agreementId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetAuditTrail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetAuditTrail: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves a single combined PDF document for the documents associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param> 
        /// <param name="participantId">The participant identifier to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param> 
        /// <param name="attachSupportingDocuments">When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true.</param> 
        /// <param name="attachAuditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetCombinedDocument(string agreementId, bool? attachSupportingDocuments = null, bool? attachAuditReport = null, string participantId = null, string versionId = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocument");


            var path = "/agreements/{agreementId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantId != null) queryParams.Add("participantId", ApiClient.ParameterToString(participantId)); // query parameter
            if (attachSupportingDocuments != null) queryParams.Add("attachSupportingDocuments", ApiClient.ParameterToString(attachSupportingDocuments)); // query parameter
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
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves info of all pages of a combined PDF document for the documents associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="includeSupportingDocumentsPagesInfo">When set to true, returns info of all pages of supporting documents as well. Else, return the info of pages of only the original document.</param> 
        /// <returns>CombinedDocumentPagesInfo</returns>            
        public CombinedDocumentPagesInfo GetCombinedDocumentPagesInfo(string agreementId, bool? includeSupportingDocumentsPagesInfo = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocumentPagesInfo");


            var path = "/agreements/{agreementId}/combinedDocument/pagesInfo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (includeSupportingDocumentsPagesInfo != null) queryParams.Add("includeSupportingDocumentsPagesInfo", ApiClient.ParameterToString(includeSupportingDocumentsPagesInfo)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocumentPagesInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocumentPagesInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (CombinedDocumentPagesInfo)ApiClient.Deserialize(response.Content, typeof(CombinedDocumentPagesInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves url of all visible pages of all the documents associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="versionId">The version identifier of agreement as provided by the API which retrieves information of a specific agreement. If not provided then latest version will be used.</param> 
        /// <param name="participantId">The participant identifier to be used to retrieve documents. If not mentioned, the participation of api caller is used.</param> 
        /// <param name="attachSupportingDocuments">When set to true, attach corresponding supporting documents to the signed agreement PDF. Default value of this parameter is true.</param> 
        /// <param name="attachAuditReport">When set to true, attach an audit report to the signed agreement PDF. Default value is false</param> 
        /// <returns>DocumentUrl</returns>            
        public DocumentUrl GetCombinedDocumentUrl(string agreementId, bool? attachSupportingDocuments = null, bool? attachAuditReport = null, string versionId = null, string participantId = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetCombinedDocumentUrl");


            var path = "/agreements/{agreementId}/combinedDocument/url";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
            if (participantId != null) queryParams.Add("participantId", ApiClient.ParameterToString(participantId)); // query parameter
            if (attachSupportingDocuments != null) queryParams.Add("attachSupportingDocuments", ApiClient.ParameterToString(attachSupportingDocuments)); // query parameter
            if (attachAuditReport != null) queryParams.Add("attachAuditReport", ApiClient.ParameterToString(attachAuditReport)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocumentUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocumentUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentUrl)ApiClient.Deserialize(response.Content, typeof(DocumentUrl), response.Headers);
        }

        /// <summary>
        /// Retrieves the file stream of a document of an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified agreement</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetDocument(string agreementId, string documentId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetDocument");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocument");


            var path = "/agreements/{agreementId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocument: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves image urls of all visible pages of a document associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified agreement</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="imageSizes">A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}. </param> 
        /// <param name="showImageAvailabilityOnly">When set to true, returns only image availability. Else, returns both image urls and its availability.</param> 
        /// <param name="startPage">Start of page number range for which imageUrls are requested. Starting page number should be greater than 0.</param> 
        /// <param name="endPage">End of page number range for which imageUrls are requested.</param> 
        /// <returns>AgreementDocumentImageUrlsInfo</returns>            
        public AgreementDocumentImageUrlsInfo GetDocumentImageUrls(string agreementId, string documentId, string imageSizes = null, bool? showImageAvailabilityOnly = null, int? startPage = null, int? endPage = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetDocumentImageUrls");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetDocumentImageUrls");


            var path = "/agreements/{agreementId}/documents/{documentId}/imageUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (imageSizes != null) queryParams.Add("imageSizes", ApiClient.ParameterToString(imageSizes)); // query parameter
            if (showImageAvailabilityOnly != null) queryParams.Add("showImageAvailabilityOnly", ApiClient.ParameterToString(showImageAvailabilityOnly)); // query parameter
            if (startPage != null) queryParams.Add("startPage", ApiClient.ParameterToString(startPage)); // query parameter
            if (endPage != null) queryParams.Add("endPage", ApiClient.ParameterToString(endPage)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocumentImageUrls: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocumentImageUrls: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementDocumentImageUrlsInfo)ApiClient.Deserialize(response.Content, typeof(AgreementDocumentImageUrlsInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the events information for an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>AgreementEventList</returns>            
        public AgreementEventList GetEvents(string agreementId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetEvents");


            var path = "/agreements/{agreementId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

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

            return (AgreementEventList)ApiClient.Deserialize(response.Content, typeof(AgreementEventList), response.Headers);
        }

        /// <summary>
        /// Retrieves data entered into the interactive form fields of the agreement. This API can only be called by the creator of the agreement
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetFormData(string agreementId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetFormData");


            var path = "/agreements/{agreementId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            headerParams.Add("Accept", "text/csv");
            
            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetFormData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetFormData: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves details of form fields of an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="participantEmail">The email address of the participant to be used to retrieve its associated form fields.</param> 
        /// <returns>AgreementFormFields</returns>            
        public AgreementFormFields GetFormFields(string agreementId, string participantEmail = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetFormFields");


            var path = "/agreements/{agreementId}/formFields";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (participantEmail != null) queryParams.Add("participantEmail", ApiClient.ParameterToString(participantEmail)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetFormFields: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetFormFields: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementFormFields)ApiClient.Deserialize(response.Content, typeof(AgreementFormFields), response.Headers);
        }

        /// <summary>
        /// Retrieves the merge info stored with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>FormFieldMergeInfo</returns>            
        public FormFieldMergeInfo GetMergeInfo(string agreementId, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetMergeInfo");


            var path = "/agreements/{agreementId}/formFields/mergeInfo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetMergeInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetMergeInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (FormFieldMergeInfo)ApiClient.Deserialize(response.Content, typeof(FormFieldMergeInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the participant set of an agreement identified by agreementId in the path. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="participantSetId">The participant set identifier</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>DetailedParticipantSetInfo</returns>            
        public DetailedParticipantSetInfo GetParticipantSet(string agreementId, string participantSetId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetParticipantSet");

            // verify the required parameter 'participantSetId' is set
            if (participantSetId == null) throw new ApiException(400, "Missing required parameter 'participantSetId' when calling GetParticipantSet");


            var path = "/agreements/{agreementId}/members/participantSets/{participantSetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "participantSetId" + "}", ApiClient.ParameterToString(participantSetId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetParticipantSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetParticipantSet: " + response.ErrorMessage, response.ErrorMessage);

            return (DetailedParticipantSetInfo)ApiClient.Deserialize(response.Content, typeof(DetailedParticipantSetInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the URL for the e-sign page for the current signer(s) of an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>SigningUrlResponse</returns>            
        public SigningUrlResponse GetSigningUrl(string agreementId, string xApiUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling GetSigningUrl");


            var path = "/agreements/{agreementId}/signingUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetSigningUrl: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetSigningUrl: " + response.ErrorMessage, response.ErrorMessage);

            return (SigningUrlResponse)ApiClient.Deserialize(response.Content, typeof(SigningUrlResponse), response.Headers);
        }

        /// <summary>
        /// Rejects the agreement for a participant. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="participantSetId">The participant set identifier</param> 
        /// <param name="participantId">The participant identifier</param> 
        /// <param name="agreementRejectionInfo">Participant rejection information required for rejecting the agreement</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <returns></returns>            
        public void RejectAgreementForParticipation(string ifMatch, string agreementId, string participantSetId, string participantId, AgreementRejectionInfo agreementRejectionInfo, string xApiUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling RejectAgreementForParticipation");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling RejectAgreementForParticipation");

            // verify the required parameter 'participantSetId' is set
            if (participantSetId == null) throw new ApiException(400, "Missing required parameter 'participantSetId' when calling RejectAgreementForParticipation");

            // verify the required parameter 'participantId' is set
            if (participantId == null) throw new ApiException(400, "Missing required parameter 'participantId' when calling RejectAgreementForParticipation");

            // verify the required parameter 'agreementRejectionInfo' is set
            if (agreementRejectionInfo == null) throw new ApiException(400, "Missing required parameter 'agreementRejectionInfo' when calling RejectAgreementForParticipation");


            var path = "/agreements/{agreementId}/members/participantSets/{participantSetId}/participants/{participantId}/reject";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "participantSetId" + "}", ApiClient.ParameterToString(participantSetId));
            path = path.Replace("{" + "participantId" + "}", ApiClient.ParameterToString(participantId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            postBody = ApiClient.Serialize(agreementRejectionInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling RejectAgreementForParticipation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling RejectAgreementForParticipation: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the agreement in draft state, or update the expirationTime on an existing agreement that is already out for signature. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="agreementInfo">Information necessary to update a modifiable agreement that is presently out for signature.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateAgreement(string ifMatch, string agreementId, AgreementInfo agreementInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateAgreement");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateAgreement");

            // verify the required parameter 'agreementInfo' is set
            if (agreementInfo == null) throw new ApiException(400, "Missing required parameter 'agreementInfo' when calling UpdateAgreement");


            var path = "/agreements/{agreementId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(agreementInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreement: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreement: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Set the merge info for an agreement. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="formFieldMergeInfo">A mapping indicating the default values to set for form fields</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateAgreementMergeInfo(string ifMatch, string agreementId, FormFieldMergeInfo formFieldMergeInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateAgreementMergeInfo");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateAgreementMergeInfo");

            // verify the required parameter 'formFieldMergeInfo' is set
            if (formFieldMergeInfo == null) throw new ApiException(400, "Missing required parameter 'formFieldMergeInfo' when calling UpdateAgreementMergeInfo");


            var path = "/agreements/{agreementId}/formFields/mergeInfo";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(formFieldMergeInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementMergeInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementMergeInfo: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the latest note associated with an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="note">The note to be associated with the agreement.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateAgreementNoteForApiUser(string agreementId, Note note, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateAgreementNoteForApiUser");

            // verify the required parameter 'note' is set
            if (note == null) throw new ApiException(400, "Missing required parameter 'note' when calling UpdateAgreementNoteForApiUser");


            var path = "/agreements/{agreementId}/me/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(note); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementNoteForApiUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementNoteForApiUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates an existing reminder for an agreement You can only update an ACTIVE reminder, and can only update the status to &#39;CANCELED&#39;, update reminderParticipantIds, or update note.
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="reminderId">The reminder identifier</param> 
        /// <param name="reminderInfo">The information about a reminder associated with a recipient of an agreement.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateAgreementReminder(string agreementId, string reminderId, ReminderInfo reminderInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateAgreementReminder");

            // verify the required parameter 'reminderId' is set
            if (reminderId == null) throw new ApiException(400, "Missing required parameter 'reminderId' when calling UpdateAgreementReminder");

            // verify the required parameter 'reminderInfo' is set
            if (reminderInfo == null) throw new ApiException(400, "Missing required parameter 'reminderInfo' when calling UpdateAgreementReminder");


            var path = "/agreements/{agreementId}/reminders/{reminderId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "reminderId" + "}", ApiClient.ParameterToString(reminderId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(reminderInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementReminder: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementReminder: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the state of an agreement identified by agreementId in the path. This endpoint can be used by originator/sender of an agreement to transition between the states of agreement. An allowed transition would follow the following sequence: DRAFT -&gt; AUTHORING -&gt; IN_PROCESS -&gt; CANCELLED.
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="agreementStateInfo"></param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateAgreementState(string ifMatch, string agreementId, AgreementStateInfo agreementStateInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateAgreementState");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateAgreementState");

            // verify the required parameter 'agreementStateInfo' is set
            if (agreementStateInfo == null) throw new ApiException(400, "Missing required parameter 'agreementStateInfo' when calling UpdateAgreementState");


            var path = "/agreements/{agreementId}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(agreementStateInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementState: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the visibility of an agreement. 
        /// </summary>
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="visibilityInfo">Information to update visibility of agreement</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateAgreementVisibility(string agreementId, VisibilityInfo visibilityInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateAgreementVisibility");

            // verify the required parameter 'visibilityInfo' is set
            if (visibilityInfo == null) throw new ApiException(400, "Missing required parameter 'visibilityInfo' when calling UpdateAgreementVisibility");


            var path = "/agreements/{agreementId}/me/visibility";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(visibilityInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementVisibility: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateAgreementVisibility: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates form fields of an agreement. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="formFieldPutInfo">List of form fields to add or replace</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>AgreementFormFields</returns>            
        public AgreementFormFields UpdateFormFields(string ifMatch, string agreementId, FormFieldPutInfo formFieldPutInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateFormFields");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateFormFields");

            // verify the required parameter 'formFieldPutInfo' is set
            if (formFieldPutInfo == null) throw new ApiException(400, "Missing required parameter 'formFieldPutInfo' when calling UpdateFormFields");


            var path = "/agreements/{agreementId}/formFields";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(formFieldPutInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateFormFields: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateFormFields: " + response.ErrorMessage, response.ErrorMessage);

            return (AgreementFormFields)ApiClient.Deserialize(response.Content, typeof(AgreementFormFields), response.Headers);
        }

        /// <summary>
        /// Updates the participant set of an agreement identified by agreementId in the path. 
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="agreementId">The agreement identifier, as returned by the agreement creation API or retrieved from the API to fetch agreements.</param> 
        /// <param name="participantSetId">The participant set identifier</param> 
        /// <param name="detailedParticipantSetInfo">The new participant set info.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateParticipantSet(string ifMatch, string agreementId, string participantSetId, DetailedParticipantSetInfo detailedParticipantSetInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateParticipantSet");

            // verify the required parameter 'agreementId' is set
            if (agreementId == null) throw new ApiException(400, "Missing required parameter 'agreementId' when calling UpdateParticipantSet");

            // verify the required parameter 'participantSetId' is set
            if (participantSetId == null) throw new ApiException(400, "Missing required parameter 'participantSetId' when calling UpdateParticipantSet");

            // verify the required parameter 'detailedParticipantSetInfo' is set
            if (detailedParticipantSetInfo == null) throw new ApiException(400, "Missing required parameter 'detailedParticipantSetInfo' when calling UpdateParticipantSet");


            var path = "/agreements/{agreementId}/members/participantSets/{participantSetId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "agreementId" + "}", ApiClient.ParameterToString(agreementId));
            path = path.Replace("{" + "participantSetId" + "}", ApiClient.ParameterToString(participantSetId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(detailedParticipantSetInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateParticipantSet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateParticipantSet: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
