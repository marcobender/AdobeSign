using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.TransientDocuments.Model;

namespace AdobeSign.TransientDocuments.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransientDocumentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransientDocumentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public TransientDocumentsApi(ApiClient apiClient = null)
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
        /// Uploads a document and obtains the document&#39;s ID. The document uploaded through this call is referred to as transient since it is available only for 7 days after the upload. The returned transient document ID can be used in the API calls where the uploaded file needs to be referred. The transient document request is a multipart request consisting of three parts - filename, mime type and the file stream. You can only upload one file at a time in this request.
        /// </summary>
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param> 
        /// <param name="fileName">A name for the document being uploaded. Maximum number of characters in the name is restricted to 255.</param> 
        /// <param name="mimeType">The mime type of the document being uploaded. If not specified here then mime type is picked up from the file object. If mime type is not present there either then mime type is inferred from file name extension.</param> 
        /// <returns>TransientDocumentResponse</returns>            
        public TransientDocumentResponse CreateTransientDocument(System.IO.Stream file, string fileName = null, string mimeType = null, string xApiUser = null, string xOnBehalfOfUser = null)
        {


            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling CreateTransientDocument");


            var path = "/transientDocuments";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
            if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter

            if (fileName != null) formParams.Add("File-Name", ApiClient.ParameterToString(fileName)); // form parameter
            if (mimeType != null) formParams.Add("Mime-Type", ApiClient.ParameterToString(mimeType)); // form parameter
            if (file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", file));

            // authentication setting, if any
            String[] authSettings = new String[] { };

            // make the HTTP request
            IRestResponse response = (IRestResponse)ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);

            if (((int)response.StatusCode) >= 400)
                throw new ApiException((int)response.StatusCode, "Error calling CreateTransientDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling CreateTransientDocument: " + response.ErrorMessage, response.ErrorMessage);

            return (TransientDocumentResponse)ApiClient.Deserialize(response.Content, typeof(TransientDocumentResponse), response.Headers);
        }

        /// <summary>
        /// Uploads a document and obtains the document&#39;s ID. The document uploaded through this call is referred to as transient since it is available only for 7 days after the upload. The returned transient document ID can be used in the API calls where the uploaded file needs to be referred. The transient document request is a multipart request consisting of three parts - filename, mime type and the file stream. You can only upload one file at a time in this request.
        /// </summary>
        public TransientDocumentResponse CreateTransientDocument(byte[] file, string fileName = null, string mimeType = null)
        {
            var response  =  ApiClient.CallApiFile("/transientDocuments", file, fileName, mimeType);
            return (TransientDocumentResponse)ApiClient.Deserialize(response.Content, typeof(TransientDocumentResponse), response.Headers);


        }

    }
}
