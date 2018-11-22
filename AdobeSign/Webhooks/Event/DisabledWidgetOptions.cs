using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class DisabledWidgetOptions
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }
    }
}
