using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class WebhookUrlInfo
    {
        /// <summary>
        /// HTTPS URL of the webhook
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
