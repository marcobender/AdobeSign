using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{
    public class MegaSign
    {
        /// <summary>
        /// The unique identifier of the agreement; it can be used to query status and download signed documents.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the agreement that will be used to identify it, in emails and on the website.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The current status of the agreement. (OUT_FOR_SIGNATURE, SIGNED, APPROVED, ACCEPTED, DELIVERED, FORM_FILLED, ABORTED, EXPIRED, OUT_FOR_APPROVAL, OUT_FOR_ACCEPTANCE, OUT_FOR_DELIVERY, OUT_FOR_FORM_FILLING, or CANCELLED)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ccs")]
        public Cc[] Ccs { get; set; }

        [JsonProperty("childAgreementsInfo")]
        public ChildAgreementsInfo ChildAgreementsInfo { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("externalId")]
        public ExternalId ExternalId { get; set; }

        [JsonProperty("firstReminderDelay")]
        public string FirstReminderDelay { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("postSignOption")]
        public PostSignOption PostSignOption { get; set; }

        [JsonProperty("reminderFrequency")]
        public string ReminderFrequency { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("vaultingInfo")]
        public VaultingInfo VaultingInfo { get; set; }
    }

}
