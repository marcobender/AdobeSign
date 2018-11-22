using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{

    public partial class LibraryDocument
    {
        /// <summary>
        /// The unique identifier that is used to refer to the library template.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the library template that will be used to identify it, in emails and on the website.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creatorEmail")]
        public string CreatorEmail { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// The current status of the library document.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("sharingMode")]
        public string SharingMode { get; set; }

        [JsonProperty("templateTypes")]
        public string[] TemplateTypes { get; set; }

        [JsonProperty("documentsInfo")]
        public DocumentsInfo DocumentsInfo { get; set; }
    }



    
}
