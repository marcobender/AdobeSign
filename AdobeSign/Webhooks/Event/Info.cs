using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class Info
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("deframe")]
        public string Deframe { get; set; }

        [JsonProperty("delay")]
        public string Delay { get; set; }
    }
}
