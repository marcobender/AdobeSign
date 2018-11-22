using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{
    public  class PostSignOption
    {
        [JsonProperty("redirectDelay")]
        public string RedirectDelay { get; set; }

        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }
    }
}
