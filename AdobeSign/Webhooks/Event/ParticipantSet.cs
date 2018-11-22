using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{

    public  class ParticipantSet
    {
        [JsonProperty("memberInfos")]
        public MemberInfo[] MemberInfos { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("privateMessage")]
        public string PrivateMessage { get; set; }
    }
}
