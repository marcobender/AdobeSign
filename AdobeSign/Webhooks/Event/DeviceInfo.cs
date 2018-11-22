using System;
using Newtonsoft.Json;
namespace AdobeSign.Webhooks.Event
{
    public class DeviceInfo
    {
        [JsonProperty("applicationDescription")]
        public string ApplicationDescription { get; set; }

        [JsonProperty("deviceDescription")]
        public string DeviceDescription { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("deviceTime")]
        public DateTime? DeviceTime { get; set; }
    }
}
