using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace AdobeSign.Webhooks.Event
{

    public partial class Agreement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("signatureType")]
        public string SignatureType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ccs")]
        public Cc[] Ccs { get; set; }

        [JsonProperty("deviceInfo")]
        public DeviceInfo DeviceInfo { get; set; }

        [JsonProperty("documentVisibilityEnabled")]
        public string DocumentVisibilityEnabled { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("expirationTime")]
        public string ExpirationTime { get; set; }

        [JsonProperty("externalId")]
        public ExternalId ExternalId { get; set; }

        [JsonProperty("postSignOption")]
        public PostSignOption PostSignOption { get; set; }

        [JsonProperty("firstReminderDelay")]
        public string FirstReminderDelay { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("reminderFrequency")]
        public string ReminderFrequency { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("vaultingInfo")]
        public VaultingInfo VaultingInfo { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }

        [JsonProperty("participantSetsInfo")]
        public ParticipantSetsInfo ParticipantSetsInfo { get; set; }

        [JsonProperty("documentsInfo")]
        public DocumentsInfo DocumentsInfo { get; set; }

        [JsonProperty("signedDocumentInfo")]
        public SignedDocumentInfo SignedDocumentInfo { get; set; }
    }

    public partial class Cc
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("visiblePages")]
        public string[] VisiblePages { get; set; }
    }

    public partial class DeviceInfo
    {
        [JsonProperty("applicationDescription")]
        public string ApplicationDescription { get; set; }

        [JsonProperty("deviceDescription")]
        public string DeviceDescription { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("deviceTime")]
        public string DeviceTime { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public partial class DocumentsInfo
    {
        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("supportingDocuments")]
        public SupportingDocument[] SupportingDocuments { get; set; }
    }

    public partial class Document
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numPages")]
        public string NumPages { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class SupportingDocument
    {
        [JsonProperty("displayLabel")]
        public string DisplayLabel { get; set; }

        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("numPages")]
        public string NumPages { get; set; }
    }

    public partial class ExternalId
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class ParticipantSetsInfo
    {
        [JsonProperty("participantSets")]
        public ParticipantSet[] ParticipantSets { get; set; }
    }

    public partial class ParticipantSet
    {
        [JsonProperty("memberInfos")]
        public MemberInfo[] MemberInfos { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

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

    public partial class PostSignOption
    {
        [JsonProperty("redirectDelay")]
        public string RedirectDelay { get; set; }

        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }
    }

    public partial class SignedDocumentInfo
    {
        [JsonProperty("document")]
        public string Document { get; set; }
    }

    public partial class VaultingInfo
    {
        [JsonProperty("enabled")]
        public string Enabled { get; set; }
    }

    public partial class WebhookNotificationApplicableUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("payloadApplicable")]
        public string PayloadApplicable { get; set; }
    }

    public partial class WebhookUrlInfo
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class WebhookNotificationPayload
    {
        public static WebhookNotificationPayload FromJson(string json) => JsonConvert.DeserializeObject<WebhookNotificationPayload>(json, QuickType.Converter.Settings);
    }

}
