using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{

    public class VaultingInfo
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }
}
