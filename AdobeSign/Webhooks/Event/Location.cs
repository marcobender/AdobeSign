using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }
}
