using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class SignedDocumentInfo
    {
        [JsonProperty("document")]
        public string Document { get; set; }
    }
}
