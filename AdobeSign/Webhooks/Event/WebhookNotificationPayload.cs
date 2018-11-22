using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace AdobeSign.Webhooks.Event
{
    [DataContract]
    public partial class WebhookNotificationPayload
    {
        /// <summary>
        /// Webhook identifier of the webhook for which the notification is being sent
        /// </summary>
        [DataMember(Name = "webhookId", EmitDefaultValue = false)]
        [JsonProperty("webhookId")]
        public string WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook which was provided while creating a webhook
        /// </summary>
        [DataMember(Name = "webhookName", EmitDefaultValue = false)]
        [JsonProperty("webhookName")]
        public string WebhookName { get; set; }

        /// <summary>
        /// The unique identifier of the webhook notification. This will be helpful in identifying duplicate notifications, if any.
        /// </summary>
        [JsonProperty("webhookNotificationId")]
        public string WebhookNotificationId { get; set; }

        /// <summary>
        /// URL on which this HTTPS POST notification is triggered.
        /// </summary>
        [JsonProperty("webhookUrlInfo")]
        public WebhookUrlInfo WebhookUrlInfo { get; set; }

        /// <summary>
        /// Scope of the webhook (ACCOUNT,GROUP,USER,RESOURCE)
        /// </summary>
        [JsonProperty("webhookScope")]
        public string WebhookScope { get; set; }

        /// <summary>
        /// An array of the details of the users for which this notification is delivered. For example: Say User A and User B are in a Group G1. Say User C is in Group G2. Say both these groups and all 3 users are in Account A. Assume, group level “webhook W1” is registered on Group G1 and group level “webhook W2” is registered on Group G2. Now an agreement is sent by User A and to User B. And User B delegates the signing to User C. In the above case, the sign will generate only two notifications (corresponding to W1 and W2) for the delegation event. Current field for W1 notification will be an array of details of User A and User B. Current field for W2 notifica
        /// </summary>
        [JsonProperty("webhookNotificationApplicableUsers")]
        public WebhookNotificationApplicableUser[] WebhookNotificationApplicableUsers { get; set; }

        /// <summary>
        /// Event for which the webhook notification is triggered
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Subevent for which the webhook notification is triggered. This field is event specific and returned with only few events, please look into individual event for the details
        /// </summary>
        [JsonProperty("subEvent")]
        public string SubEvent { get; set; }

        /// <summary>
        /// Timestamp of when the event happened.
        /// </summary>
        [JsonProperty("eventDate")]
        public string EventDate { get; set; }

        /// <summary>
        /// The resource type on which the event is triggered.
        /// </summary>
        [JsonProperty("eventResourceType")]
        public string EventResourceType { get; set; }

        /// <summary>
        /// In case of agreements, it is possible that the agreement is created by signing a widget or while creating a megasign. This field informs about such cases. Only added in payloads of agreement type resources.
        /// </summary>
        [JsonProperty("eventResourceParentType")]
        public string EventResourceParentType { get; set; }

        /// <summary>
        /// Unique identifier of the widget or megasign from which this agreement is created. Only added in payloads of agreement type resources.
        /// </summary>
        [JsonProperty("eventResourceParentId")]
        public string EventResourceParentId { get; set; }

        /// <summary>
        /// This key will be returned only with the event AGREEMENT_ACTION_COMPLETED.
        /// </summary>
        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        /// <summary>
        /// Role assumed by all participants in the participant set to which the participant belongs (signer, approver etc.). This is the role of the participantUser. This key will be returned only for the following events: AGREEMENT_WORKFLOW_COMPLETED, AGREEMENT_ACTION_COMPLETED, AGREEMENT_ACTION_DELEGATED, AGREEMENT_ACTION_REQUESTED
        /// </summary>
        [JsonProperty("participantRole")]
        public string ParticipantRole { get; set; }

        /// <summary>
        /// Details (user ID and email) of the last action taker. This can be the signer or the delegatee.
        /// </summary>
        [JsonProperty("participantUserId")]
        public string ParticipantUserId { get; set; }

        /// <summary>
        /// Details (user ID and email) of the last action taker. This can be the signer or the delegatee.
        /// </summary>
        [JsonProperty("participantUserEmail")]
        public string ParticipantUserEmail { get; set; }

        /// <summary>
        /// Details (user ID and email) of the last action taker. This can be the signer or the delegatee.
        /// </summary>
        [JsonProperty("actingUserId")]
        public string ActingUserId { get; set; }

        /// <summary>
        /// Details (user ID and email) of the last action taker. This can be the signer or the delegatee.
        /// </summary>
        [JsonProperty("actingUserEmail")]
        public string ActingUserEmail { get; set; }

        /// <summary>
        /// IP address of user that triggered the event
        /// </summary>
        [JsonProperty("actingUserIpAddress")]
        public string ActingUserIpAddress { get; set; }

        [JsonProperty("initiatingUserId")]
        public string InitiatingUserId { get; set; }

        [JsonProperty("initiatingUserEmail")]
        public string InitiatingUserEmail { get; set; }

        /// <summary>
        /// Information about the agreement on which the event occurred. This key will be returned only if the event is an agreement event.
        /// </summary>
        [JsonProperty("agreement")]
        public Agreement Agreement { get; set; }
    }

}


