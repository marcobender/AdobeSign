using System;
using System.Collections.Generic;
using RestSharp;
using AdobeSign.Client;
using AdobeSign.BaseUris.Model;

namespace AdobeSign.BaseUris.Api
{
   
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BaseUrisApi 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUrisApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient</param>
        /// <returns></returns>
        public BaseUrisApi(ApiClient apiClient)
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
        /// Gets the base uri to access other APIs. In case other APIs are accessed from a different end point, it will be considered an invalid request. 
        /// </summary>
        /// <returns>BaseUriInfo</returns>            
        public BaseUriInfo GetBaseUris ()
        {
            
            return ApiClient.CallApiGet<BaseUriInfo>("/baseUris");

        }
    
    }
}
