using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class Document
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numPages")]
        public int? NumPages { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
