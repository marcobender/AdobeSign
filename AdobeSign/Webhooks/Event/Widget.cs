using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{

    public class Widget
    {

        /// <summary>
        /// The unique identifier of widget that can be used to retrieve the data entered by the signers
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The name of the widget that will be used to identify it, in emails, website, and other places
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The current status of the widget (DRAFT or ACTIVE or AUTHORING)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }


        [JsonProperty("authFailureInfo")]
        public Info AuthFailureInfo { get; set; }

        [JsonProperty("ccs")]
        public Cc[] Ccs { get; set; }

        [JsonProperty("completionInfo")]
        public Info CompletionInfo { get; set; }

        [JsonProperty("disabledWidgetOptions")]
        public DisabledWidgetOptions DisabledWidgetOptions { get; set; }

        [JsonProperty("creatorEmail")]
        public string CreatorEmail { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("vaultingInfo")]
        public VaultingInfo VaultingInfo { get; set; }

        [JsonProperty("participantSetsInfo")]
        public ParticipantSetsInfo ParticipantSetsInfo { get; set; }

        [JsonProperty("documentsInfo")]
        public DocumentsInfo DocumentsInfo { get; set; }
    }

   



}
