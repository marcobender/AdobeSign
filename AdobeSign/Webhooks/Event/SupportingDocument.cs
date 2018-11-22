using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{
    public  class SupportingDocument
    {
        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("numPages")]
        public int? NumPages { get; set; }
    }
}
