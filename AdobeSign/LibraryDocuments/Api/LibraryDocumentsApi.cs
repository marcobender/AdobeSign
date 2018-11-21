using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.LibraryDocuments.Model;

namespace AdobeSign.LibraryDocuments.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LibraryDocumentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryDocumentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public LibraryDocumentsApi(ApiClient apiClient = null)
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
        /// Creates a template that is placed in the library of the user for reuse. 
        /// </summary>
        /// <param name="libraryDocumentInfo">Information about the library document that you want to create.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>LibraryDocumentCreationResponse</returns>            
        public LibraryDocumentCreationResponse CreateLibraryDocument(LibraryDocumentCreationInfoV6 libraryDocumentInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentInfo' is set
            if (libraryDocumentInfo == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentInfo' when calling CreateLibraryDocument");


            var path = "/libraryDocuments";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            postBody = ApiClient.Serialize(libraryDocumentInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateLibraryDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateLibraryDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (LibraryDocumentCreationResponse)ApiClient.Deserialize(response.Content, typeof(LibraryDocumentCreationResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves the latest state view url of a library document. 
        /// </summary>

        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="libraryViewInfo">Name of the required view and its desired configuration.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>LibraryDocumentViewResponse</returns>            
        public LibraryDocumentViewResponse CreateLibraryDocumentView(string libraryDocumentId, LibraryViewInfo libraryViewInfo, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling CreateLibraryDocumentView");

            // verify the required parameter 'libraryViewInfo' is set
            if (libraryViewInfo == null) throw new ApiException(400, "Missing required parameter 'libraryViewInfo' when calling CreateLibraryDocumentView");


            var path = "/libraryDocuments/{libraryDocumentId}/views";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter
            postBody = ApiClient.Serialize(libraryViewInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateLibraryDocumentView: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateLibraryDocumentView: " + response.ErrorMessage, response.ErrorMessage);

            return (LibraryDocumentViewResponse)ApiClient.Deserialize(response.Content, typeof(LibraryDocumentViewResponse), response.Headers);
        }

        /// <summary>
        /// Retrieves the combined document associated with a library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="attachAuditReport">When set to YES attach an audit report to the library document PDF. Default value will be false.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetCombinedDocument(string libraryDocumentId, bool? attachAuditReport = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetCombinedDocument");


            var path = "/libraryDocuments/{libraryDocumentId}/combinedDocument";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetCombinedDocument: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves the IDs of the documents associated with library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="versionId">The version identifier of library_document as provided by the API which retrieves information of a specific library document. If not provided then latest version will be used.</param> 
        /// <returns>Documents</returns>            
        public Documents GetDocuments(string libraryDocumentId, string versionId = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetDocuments");


            var path = "/libraryDocuments/{libraryDocumentId}/documents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (Documents)ApiClient.Deserialize(response.Content, typeof(Documents), response.Headers);
        }

        /// <summary>
        /// Retrieves the events information for a library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>LibraryDocumentEventList</returns>            
        public LibraryDocumentEventList GetEvents(string libraryDocumentId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetEvents");


            var path = "/libraryDocuments/{libraryDocumentId}/events";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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

            return (LibraryDocumentEventList)ApiClient.Deserialize(response.Content, typeof(LibraryDocumentEventList), response.Headers);
        }

        /// <summary>
        /// Retrieves data entered into the interactive form fields of the library document. This API can only be called by the creator of the library document
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetFormData(string libraryDocumentId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetFormData");


            var path = "/libraryDocuments/{libraryDocumentId}/formData";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetFormData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetFormData: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves the file stream of a document of library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified library document</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetLibraryDocument(string libraryDocumentId, string documentId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocument");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetLibraryDocument");


            var path = "/libraryDocuments/{libraryDocumentId}/documents/{documentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));
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
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocument: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves the audit trail associated with a library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>byte[]</returns>            
        public byte[] GetLibraryDocumentAuditTrail(string libraryDocumentId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocumentAuditTrail");


            var path = "/libraryDocuments/{libraryDocumentId}/auditTrail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentAuditTrail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentAuditTrail: " + response.ErrorMessage, response.ErrorMessage);

            return response.RawBytes;
        }

        /// <summary>
        /// Retrieves image urls of all visible pages of a document associated with a library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="documentId">The document identifier, as retrieved from the API which fetches the documents of a specified library document</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <param name="imageSizes">A comma separated list of image sizes i.e. {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_50_PERCENT, ZOOM_75_PERCENT, ZOOM_100_PERCENT, ZOOM_125_PERCENT, ZOOM_150_PERCENT, ZOOM_200_PERCENT}. Default sizes returned are {FIXED_WIDTH_50px, FIXED_WIDTH_250px, FIXED_WIDTH_675px, ZOOM_100_PERCENT}. </param> 
        /// <param name="startPage">Start of page number range for which imageUrls are requested. Starting page number should be greater than 0.</param> 
        /// <param name="endPage">End of page number range for which imageUrls are requested.</param> 
        /// <returns>DocumentImageUrlsInfo</returns>            
        public DocumentImageUrlsInfo GetLibraryDocumentImageUrls(string libraryDocumentId, string documentId, string imageSizes = null, int? startPage = null, int? endPage = null, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocumentImageUrls");

            // verify the required parameter 'documentId' is set
            if (documentId == null) throw new ApiException(400, "Missing required parameter 'documentId' when calling GetLibraryDocumentImageUrls");


            var path = "/libraryDocuments/{libraryDocumentId}/documents/{documentId}/imageUrls";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));
            path = path.Replace("{" + "documentId" + "}", ApiClient.ParameterToString(documentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (imageSizes != null) queryParams.Add("imageSizes", ApiClient.ParameterToString(imageSizes)); // query parameter
            if (startPage != null) queryParams.Add("startPage", ApiClient.ParameterToString(startPage)); // query parameter
            if (endPage != null) queryParams.Add("endPage", ApiClient.ParameterToString(endPage)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifNoneMatch != null) headerParams.Add("If-None-Match", ApiClient.ParameterToString(ifNoneMatch)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentImageUrls: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentImageUrls: " + response.ErrorMessage, response.ErrorMessage);

            return (DocumentImageUrlsInfo)ApiClient.Deserialize(response.Content, typeof(DocumentImageUrlsInfo), response.Headers);
        }

        /// <summary>
        /// Retrieves the details of a library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="ifNoneMatch">Pass the value of the e-tag header obtained from the previous response to the same request to get a RESOURCE_NOT_MODIFIED(304) if the resource hasn&#39;t changed.</param> 
        /// <returns>LibraryDocumentCreationInfoV6</returns>            
        public LibraryDocumentCreationInfoV6 GetLibraryDocumentInfo(string libraryDocumentId, string xApiUser = null, string xOnBehalfOfUser = null, string ifNoneMatch = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocumentInfo");


            var path = "/libraryDocuments/{libraryDocumentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentInfo: " + response.ErrorMessage, response.ErrorMessage);

            return (LibraryDocumentCreationInfoV6)ApiClient.Deserialize(response.Content, typeof(LibraryDocumentCreationInfoV6), response.Headers);
        }

        /// <summary>
        /// Retrieves the latest note of a library document for the API user. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns>Note</returns>            
        public Note GetLibraryDocumentNoteForApiUser(string libraryDocumentId, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling GetLibraryDocumentNoteForApiUser");


            var path = "/libraryDocuments/{libraryDocumentId}/me/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentNoteForApiUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocumentNoteForApiUser: " + response.ErrorMessage, response.ErrorMessage);

            return (Note)ApiClient.Deserialize(response.Content, typeof(Note), response.Headers);
        }

        /// <summary>
        /// Retrieves library documents for a user. 
        /// </summary>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="showHiddenLibraryDocuments">A query parameter to fetch all the hidden library documents along with the visible library documents. Default value is false.</param> 
        /// <param name="cursor">Used to navigate through the pages. If not provided, returns the first page.</param> 
        /// <param name="pageSize">Number of intended items in the response page. If not provided, it is decided by the application settings.</param> 
        /// <returns>LibraryDocuments</returns>            
        public AdobeSign.LibraryDocuments.Model.LibraryDocuments GetLibraryDocuments(bool? showHiddenLibraryDocuments = null, string cursor = null, int? pageSize = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set



            var path = "/libraryDocuments";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (showHiddenLibraryDocuments != null) queryParams.Add("showHiddenLibraryDocuments", ApiClient.ParameterToString(showHiddenLibraryDocuments)); // query parameter
            if (cursor != null) queryParams.Add("cursor", ApiClient.ParameterToString(cursor)); // query parameter
            if (pageSize != null) queryParams.Add("pageSize", ApiClient.ParameterToString(pageSize)); // query parameter

            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocuments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling GetLibraryDocuments: " + response.ErrorMessage, response.ErrorMessage);

            return (AdobeSign.LibraryDocuments.Model.LibraryDocuments)ApiClient.Deserialize(response.Content, typeof(AdobeSign.LibraryDocuments.Model.LibraryDocuments), response.Headers);
        }

        /// <summary>
        /// Updates the library document. Currently status, name, sharingMode and templateTypes of the library document can only be updated.
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="libraryDocumentInfo">Information about the library document that you want to create.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateLibraryDocument(string ifMatch, string libraryDocumentId, LibraryDocumentInfo libraryDocumentInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateLibraryDocument");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling UpdateLibraryDocument");

            // verify the required parameter 'libraryDocumentInfo' is set
            if (libraryDocumentInfo == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentInfo' when calling UpdateLibraryDocument");


            var path = "/libraryDocuments/{libraryDocumentId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(libraryDocumentInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocument: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the latest note of a library document for the API user. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="note">The note to be associated with the library document.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateLibraryDocumentNoteForApiUser(string libraryDocumentId, Note note, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling UpdateLibraryDocumentNoteForApiUser");

            // verify the required parameter 'note' is set
            if (note == null) throw new ApiException(400, "Missing required parameter 'note' when calling UpdateLibraryDocumentNoteForApiUser");


            var path = "/libraryDocuments/{libraryDocumentId}/me/note";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocumentNoteForApiUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocumentNoteForApiUser: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the library document&#39;s state. Currently state can be changed from AUTHORING to ACTIVE.
        /// </summary>
        /// <param name="ifMatch">The server will only update the resource if it matches the listed ETag otherwise error RESOURCE_MODIFIED(412) is returned.</param> 
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="libraryDocumentStateInfo">Information about the state of library document to which you want to update</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateLibraryDocumentState(string ifMatch, string libraryDocumentId, LibraryDocumentStateInfo libraryDocumentStateInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'ifMatch' is set
            if (ifMatch == null) throw new ApiException(400, "Missing required parameter 'ifMatch' when calling UpdateLibraryDocumentState");

            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling UpdateLibraryDocumentState");

            // verify the required parameter 'libraryDocumentStateInfo' is set
            if (libraryDocumentStateInfo == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentStateInfo' when calling UpdateLibraryDocumentState");


            var path = "/libraryDocuments/{libraryDocumentId}/state";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            postBody = ApiClient.Serialize(libraryDocumentStateInfo); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocumentState: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocumentState: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

        /// <summary>
        /// Updates the visibility of library document. 
        /// </summary>
        /// <param name="libraryDocumentId">The document identifier, as retrieved from the API to fetch library documents.</param> 
        /// <param name="visibilityInfo">Information to update visibility of agreement</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <returns></returns>            
        public void UpdateLibraryDocumentVisibility(string libraryDocumentId, VisibilityInfo visibilityInfo, string xApiUser = null, string xOnBehalfOfUser = null)
        {

            // verify the required parameter 'authorization' is set


            // verify the required parameter 'libraryDocumentId' is set
            if (libraryDocumentId == null) throw new ApiException(400, "Missing required parameter 'libraryDocumentId' when calling UpdateLibraryDocumentVisibility");

            // verify the required parameter 'visibilityInfo' is set
            if (visibilityInfo == null) throw new ApiException(400, "Missing required parameter 'visibilityInfo' when calling UpdateLibraryDocumentVisibility");


            var path = "/libraryDocuments/{libraryDocumentId}/me/visibility";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "libraryDocumentId" + "}", ApiClient.ParameterToString(libraryDocumentId));

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
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocumentVisibility: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling UpdateLibraryDocumentVisibility: " + response.ErrorMessage, response.ErrorMessage);

            return;
        }

    }
}
