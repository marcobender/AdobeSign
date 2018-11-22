using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{
    public  class ExternalId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
