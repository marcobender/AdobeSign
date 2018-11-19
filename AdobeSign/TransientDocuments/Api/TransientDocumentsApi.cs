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
    public interface ITransientDocumentsApi
    {
        /// <summary>
        /// Uploads a document and obtains the document&#39;s ID. The document uploaded through this call is referred to as transient since it is available only for 7 days after the upload. The returned transient document ID can be used in the API calls where the uploaded file needs to be referred. The transient document request is a multipart request consisting of three parts - filename, mime type and the file stream. You can only upload one file at a time in this request.
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with any of the following scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_sign&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_sign&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_sign&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param>
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param>
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param>
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param>
        /// <param name="fileName">A name for the document being uploaded. Maximum number of characters in the name is restricted to 255.</param>
        /// <param name="mimeType">The mime type of the document being uploaded. If not specified here then mime type is picked up from the file object. If mime type is not present there either then mime type is inferred from file name extension.</param>
        /// <returns>TransientDocumentResponse</returns>
        TransientDocumentResponse CreateTransientDocument (string authorization, System.IO.Stream file, string xApiUser, string xOnBehalfOfUser, string fileName, string mimeType);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransientDocumentsApi : ITransientDocumentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransientDocumentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransientDocumentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransientDocumentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransientDocumentsApi(String basePath)
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
        /// Uploads a document and obtains the document&#39;s ID. The document uploaded through this call is referred to as transient since it is available only for 7 days after the upload. The returned transient document ID can be used in the API calls where the uploaded file needs to be referred. The transient document request is a multipart request consisting of three parts - filename, mime type and the file stream. You can only upload one file at a time in this request.
        /// </summary>
        /// <param name="authorization">An &lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc()\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;OAuth Access Token&lt;/a&gt; with any of the following scopes:&lt;ul&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_sign&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;agreement_sign&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;agreement_sign&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;widget_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;widget_write&lt;/a&gt;&lt;/li&gt;&lt;li style&#x3D;&#39;list-style-type: square&#39;&gt;&lt;a href&#x3D;\&quot;#\&quot; onclick&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; oncontextmenu&#x3D;\&quot;this.href&#x3D;oauthDoc(&#39;library_write&#39;)\&quot; target&#x3D;\&quot;oauthDoc\&quot;&gt;library_write&lt;/a&gt;&lt;/li&gt;&lt;/ul&gt;in the format &lt;b&gt;&#39;Bearer {accessToken}&#39;.</param> 
        /// <param name="file">The file part of the multipart request for document upload. You can upload only one file at a time.</param> 
        /// <param name="xApiUser">The userId or email of API caller using the account or group token in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; If it is not specified, then the caller is inferred from the token.</param> 
        /// <param name="xOnBehalfOfUser">The userId or email in the format &lt;b&gt;userid:{userId} OR email:{email}.&lt;/b&gt; of the user that has shared his/her account</param> 
        /// <param name="fileName">A name for the document being uploaded. Maximum number of characters in the name is restricted to 255.</param> 
        /// <param name="mimeType">The mime type of the document being uploaded. If not specified here then mime type is picked up from the file object. If mime type is not present there either then mime type is inferred from file name extension.</param> 
        /// <returns>TransientDocumentResponse</returns>            
        public TransientDocumentResponse CreateTransientDocument (string authorization, System.IO.Stream file, string xApiUser, string xOnBehalfOfUser, string fileName, string mimeType)
        {
            
            // verify the required parameter 'authorization' is set
            if (authorization == null) throw new ApiException(400, "Missing required parameter 'authorization' when calling CreateTransientDocument");
            
            // verify the required parameter 'file' is set
            if (file == null) throw new ApiException(400, "Missing required parameter 'file' when calling CreateTransientDocument");
            
    
            var path = "/transientDocuments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (authorization != null) headerParams.Add("Authorization", ApiClient.ParameterToString(authorization)); // header parameter
 if (xApiUser != null) headerParams.Add("x-api-user", ApiClient.ParameterToString(xApiUser)); // header parameter
 if (xOnBehalfOfUser != null) headerParams.Add("x-on-behalf-of-user", ApiClient.ParameterToString(xOnBehalfOfUser)); // header parameter
            if (fileName != null) formParams.Add("File-Name", ApiClient.ParameterToString(fileName)); // form parameter
if (mimeType != null) formParams.Add("Mime-Type", ApiClient.ParameterToString(mimeType)); // form parameter
if (file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTransientDocument: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTransientDocument: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransientDocumentResponse) ApiClient.Deserialize(response.Content, typeof(TransientDocumentResponse), response.Headers);
        }
    
    }
}
