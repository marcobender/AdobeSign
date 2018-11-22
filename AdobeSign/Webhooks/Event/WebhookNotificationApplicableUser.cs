using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{

    public class WebhookNotificationApplicableUser
    {
        /// <summary>
        /// The unique identifier of the user for which the notification is applicable.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Email address of the user for which the notification is applicable.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Role of the user in the workflow.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// Indicates whether the payload attached to this notification is fetched in the context of this user or not. The boolean will be true for one and only one of the users in the webhookNotificationApplicableUsers array.
        /// </summary>
        [JsonProperty("payloadApplicable")]
        public bool? PayloadApplicable { get; set; }
    }
}
