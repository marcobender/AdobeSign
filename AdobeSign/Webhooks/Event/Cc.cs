using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class Cc
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("visiblePages")]
        public string[] VisiblePages { get; set; }
    }
}
