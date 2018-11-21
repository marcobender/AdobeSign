using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using AdobeSign.Model;

namespace AdobeSign.Client
{
    /// <summary>
    /// Adobe Sign API client 
    /// </summary>
    public class ApiClient
    {

        /// <summary>
        /// Gets the Api Access Point URL. (Default https://api.na2.echosign.com)
        /// </summary>
        public string ApiAccessPoint { get; internal set; }
        /// <summary>
        /// Gets the Web Access Point URL. (Default https://secure.na2.echosign.com)
        /// </summary>
        public string WebAccessPoint { get; internal set; }



        public string AccessToken { get; internal set; }
        public string RefreshToken { get; internal set; }
        public DateTime? TokenExpireDate { get; internal set; }

        /// <summary>
        /// oauth client Id
        /// </summary>
        /// <value>The base path</value>
        public string ClientId { get; internal set; }


        /// <summary>
        /// oauth Client Secret
        /// </summary>
        /// <value>The base path</value>
        public string ClientSecret { get; internal set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        public ApiClient(
            string clientId,
            string clientSecret,
            string webAccessPoint = "https://secure.na1.echosign.com")
        {
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.WebAccessPoint = webAccessPoint;;
        }


        /// <summary>
        /// https://secure.na1.echosign.com/public/static/oauthDoc.jsp
        /// </summary>
        /// <param name="redirect_uri">a secure, absolute URI</param>
        /// <param name="scope">space delimited set of the permissions that the user will be asked to approve </param>
        /// <param name="state"></param>
        /// <returns></returns>
        public string GetAuthorizationRequestURL(string redirect_uri, 
            string scope = "user_login:self agreement_write:account agreement_read:account", string state = null)
        {
            return $"{this.WebAccessPoint}/public/oauth?redirect_uri={this.EscapeString(redirect_uri)}&response_type=code&client_id={this.ClientId}&scope={this.EscapeString(scope)}&state={this.EscapeString(state)}";

        }
        public void SetAccessToken(
            string accessToken,
            string refreshToken,
            DateTime tokenExpireDate,
            string apiAccessPoint)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.TokenExpireDate = tokenExpireDate;
            this.ApiAccessPoint = apiAccessPoint;
            this.RestClient = new RestClient(this.ApiAccessPoint + "/api/rest/v6");
        }

        /// <summary>
        /// https://secure.na1.echosign.com/public/static/oauthDoc.jsp
        /// </summary>
        /// <param name="redirect_uri">must match the value used during the previous step</param>
        /// <param name="code">the authorization code obtained</param>
        /// <param name="state"></param>
        /// <returns></returns>
        public AdobeSign.Model.ApiToken GetAccessToken(
            string redirect_uri,
            string code,
            string api_access_point= null)
        {
            this.ApiAccessPoint = api_access_point ?? this.ApiAccessPoint ?? "https://api.na2.echosign.com";

            var authRestClient = new RestClient(this.ApiAccessPoint);


            if (code == null)
                throw new ApiException(500, "Missing required 'code'.");

            var request = new RestRequest("/oauth/token",  Method.POST);
            request.AddParameter("grant_type", "authorization_code");
            request.AddParameter("client_id", this.ClientId);
            request.AddParameter(  "client_secret" , this.ClientSecret);
            request.AddParameter(  "redirect_uri" , redirect_uri);
            request.AddParameter(  "code" , code);

            var response = authRestClient.Execute(request);

            

            if (((int)response.StatusCode) >= 400)
            {
                if (response.Content != null && response.ContentType.StartsWith("application/json"))
                {
                    var a = JsonConvert.DeserializeObject<ApiError>(response.Content);
                    throw new ApiException((int)response.StatusCode, "Error calling /oauth/token: " + a.GetError(), a.GetDescription());
                }
                throw new ApiException((int)response.StatusCode, "Error calling /oauth/token: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling /oauth/token: " + response.ErrorMessage, response.ErrorMessage);

            var t = (AdobeSign.Model.ApiToken)this.Deserialize(response.Content, typeof(AdobeSign.Model.ApiToken), response.Headers);

            this.AccessToken = t.AccessToken;
            this.RefreshToken = t.RefreshToken;
            this.TokenExpireDate = DateTime.UtcNow.AddSeconds(t.ExpiresIn);
            
            this.RestClient = new RestClient(this.ApiAccessPoint + "/api/rest/v6");

            return t;

        }



        /// <summary>
        /// https://secure.na1.echosign.com/public/static/oauthDoc.jsp
        /// </summary>
        /// <param name="redirect_uri">must match the value used during the previous step</param>
        /// <param name="code">the authorization code obtained</param>
        /// <param name="state"></param>
        /// <returns></returns>
        public AdobeSign.Model.ApiToken RefreshAccessToken(
            string refresh_token = null,
            string api_access_point = null)
        {
            this.ApiAccessPoint = api_access_point ?? this.ApiAccessPoint ?? "https://api.na2.echosign.com";

            var authRestClient = new RestClient(this.ApiAccessPoint);

            if (refresh_token == null)
                refresh_token = this.RefreshToken;


            if (refresh_token == null)
                throw new ApiException(500, "Missing required 'RefreshToken'.");

            var request = new RestRequest("/oauth/refresh", Method.POST);
            request.AddParameter("grant_type", "refresh_token");
            request.AddParameter("client_id", this.ClientId);
            request.AddParameter("client_secret", this.ClientSecret);
            request.AddParameter("refresh_token", refresh_token );

            var response = authRestClient.Execute(request);



            if (((int)response.StatusCode) >= 400)
            {
                if (response.Content != null && response.ContentType.StartsWith("application/json"))
                {
                    var a = JsonConvert.DeserializeObject<ApiError>(response.Content);
                    throw new ApiException((int)response.StatusCode, "Error calling /oauth/token: " + a.GetError(), a.GetDescription());
                }
                throw new ApiException((int)response.StatusCode, "Error calling /oauth/token: " + response.Content, response.Content);
            }
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, "Error calling /oauth/token: " + response.ErrorMessage, response.ErrorMessage);

            var t = (AdobeSign.Model.ApiToken)this.Deserialize(response.Content, typeof(AdobeSign.Model.ApiToken), response.Headers);
            
            t.RefreshToken = t.RefreshToken ?? refresh_token ;

            this.AccessToken = t.AccessToken;
            this.RefreshToken = t.RefreshToken;
            this.TokenExpireDate = DateTime.UtcNow.AddSeconds(t.ExpiresIn);


            this.RestClient = new RestClient(this.ApiAccessPoint + "/api/rest/v6");

            return t;

        }


        ///////////////////////////// /////////////////////////////

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        internal RestClient RestClient { get; set; }


        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        /// <returns>Object</returns>
        internal IRestResponse CallApi(String path, RestSharp.Method method, Dictionary<String, String> queryParams, String postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams, 
            Dictionary<String, FileParameter> fileParams, String[] authSettings)
        {

            var request = new RestRequest(path, method);


            if (headerParams == null)
                headerParams = new Dictionary<string, string>();
            if (!headerParams.ContainsKey("Authorization"))
            {
                if (this.AccessToken==null)
                    throw new ApiException(400, "Missing required 'AccessToken' when calling the API");
                if (this.TokenExpireDate.HasValue && this.TokenExpireDate< DateTime.UtcNow)
                {
                    if (this.RefreshToken == null)
                        throw new ApiException(400, "Expired 'AccessToken'");

                    RefreshAccessToken();
                }
                headerParams.Add("Authorization", this.ParameterToString("Bearer " + this.AccessToken));
            }

            // add header parameter, if any
            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            if (queryParams != null)
            {
                // add query parameter, if any
                foreach (var param in queryParams)
                    request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);

            }
            if (formParams != null)
            {
                // add form parameter, if any
                foreach (var param in formParams)
                    request.AddParameter(param.Key, param.Value, ParameterType.GetOrPost);
            }

            if (fileParams != null)
            {
                // add file parameter, if any
                foreach (var param in fileParams)
                    request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentLength, param.Value.ContentType);
            }
            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);

            var response = RestClient.Execute(request);
            if (((int)response.StatusCode) >= 400)
            {
                ApiError a = null;
                try
                {
                    if (response.Content != null && response.ContentType.StartsWith("application/json"))
                        a = JsonConvert.DeserializeObject<ApiError>(response.Content);
                }
                catch { }

                if (a != null)
                    throw new ApiException((int)response.StatusCode, $"Error calling {method} {path}: {a.GetError()}", a.GetDescription());
                else
                    throw new ApiException((int)response.StatusCode, $"Error calling {method} {path}: {response.Content}", response.Content);
            }
            else if (((int)response.StatusCode) == 0)
                throw new ApiException((int)response.StatusCode, $"Error calling {method} {path}: {response.ErrorMessage}", response.ErrorMessage);


            return response;

        }

       

        /// <summary>
        /// Makes the HTTP GET request
        /// </summary>
        internal IRestResponse GetRequest(String path, Dictionary<String, String> queryParams = null)
        {

            var response = this.CallApi(path, Method.GET, queryParams, null, null, null, null, null);

            
            return response;

        }
        /// <summary>
        /// Makes the HTTP GET request
        /// </summary>
        internal T GetRequest<T>(String path, Dictionary<String, String> queryParams=null)
        {
            var response = GetRequest(path, queryParams);
            return (T)this.Deserialize(response.Content, typeof(T), response.Headers);
        }



        /// <summary>
        /// Makes the HTTP GET request
        /// </summary>
        internal T FileRequest<T>(String path, byte[] data, string fileName, string mimeType)
        {

            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();

            if (fileName != null) formParams.Add("File-Name", this.ParameterToString(fileName)); // form parameter
            if (mimeType != null) formParams.Add("Mime-Type", this.ParameterToString(mimeType)); // form parameter

            fileParams.Add("File", FileParameter.Create("File", data, fileName ?? "no_file_name_provided", mimeType));

            var response = this.CallApi(path, Method.POST, null, null, null, formParams, fileParams, null);


            return (T)this.Deserialize(response.Content, typeof(T), response.Headers);

        }
        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        internal string EscapeString(string str)
        {
            return HttpUtility.UrlEncode(str);
            
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        internal FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, stream.ReadAsBytes(), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, stream.ReadAsBytes(), "no_file_name_provided");
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list of string, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        internal string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString ("o");
            else if (obj is List<string>)
                return String.Join(",", (obj as List<string>).ToArray());
            else
                return Convert.ToString (obj);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="content">HTTP body (e.g. string, JSON).</param>
        /// <param name="type">Object type.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal object Deserialize(string content, Type type, IList<Parameter> headers=null)
        {
            if (type == typeof(Object)) // return an object
            {
                return content;
            }

            if (type == typeof(Stream))
            {
                var filePath = Path.GetTempPath();

                var fileName = filePath + Guid.NewGuid();
                if (headers != null)
                {
                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                    var match = regex.Match(headers.ToString());
                    if (match.Success)
                        fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                }
                File.WriteAllText(fileName, content);
                return new FileStream(fileName, FileMode.Open);

            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(content, type); 
            }
    
            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(content, type);
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        internal string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }



        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        internal static string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// </summary>
        /// <param name="fromObject">Object to be casted</param>
        /// <param name="toObject">Target type</param>
        /// <returns>Casted object</returns>
        internal static Object ConvertType(Object fromObject, Type toObject) {
            return Convert.ChangeType(fromObject, toObject);
        }
  
    }
}
