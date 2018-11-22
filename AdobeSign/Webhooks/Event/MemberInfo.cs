using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{

    public partial class MemberInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("privateMessage")]
        public string PrivateMessage { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
