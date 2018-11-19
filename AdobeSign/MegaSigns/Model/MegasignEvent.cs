using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.MegaSigns.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MegasignEvent {
    /// <summary>
    /// The date of the audit event. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The date of the audit event. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Full name of the user that initiated the event on behalf of the acting user when the account is shared. Will be empty if there is no account sharing in effect
    /// </summary>
    /// <value>Full name of the user that initiated the event on behalf of the acting user when the account is shared. Will be empty if there is no account sharing in effect</value>
    [DataMember(Name="initiatingUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initiatingUserName")]
    public string InitiatingUserName { get; set; }

    /// <summary>
    /// A description of the audit event
    /// </summary>
    /// <value>A description of the audit event</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the acting user
    /// </summary>
    /// <value>The name of the acting user</value>
    [DataMember(Name="actingUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actingUserName")]
    public string ActingUserName { get; set; }

    /// <summary>
    /// The IP address of the user that created the event
    /// </summary>
    /// <value>The IP address of the user that created the event</value>
    [DataMember(Name="actingUserIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actingUserIpAddress")]
    public string ActingUserIpAddress { get; set; }

    /// <summary>
    /// Email address of the user that is the participant for the event. This may be different than the acting user for certain event types. For example, for a DELEGATION event, this is the user who was delegated to
    /// </summary>
    /// <value>Email address of the user that is the participant for the event. This may be different than the acting user for certain event types. For example, for a DELEGATION event, this is the user who was delegated to</value>
    [DataMember(Name="participantEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantEmail")]
    public string ParticipantEmail { get; set; }

    /// <summary>
    /// Type of MegaSign event
    /// </summary>
    /// <value>Type of MegaSign event</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Role assumed by all participants in the participant set the participant belongs to (signer, approver etc.).
    /// </summary>
    /// <value>Role assumed by all participants in the participant set the participant belongs to (signer, approver etc.).</value>
    [DataMember(Name="participantRole", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantRole")]
    public string ParticipantRole { get; set; }

    /// <summary>
    /// The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null)
    /// </summary>
    /// <value>The identifier assigned by the vault provider for the vault event (if vaulted, otherwise null)</value>
    [DataMember(Name="vaultEventId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vaultEventId")]
    public string VaultEventId { get; set; }

    /// <summary>
    /// The unique identifier of the participant for the event. This may be different than the acting user for certain event types. For example, for a DELEGATION event, this is the user who was delegated to
    /// </summary>
    /// <value>The unique identifier of the participant for the event. This may be different than the acting user for certain event types. For example, for a DELEGATION event, this is the user who was delegated to</value>
    [DataMember(Name="participantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantId")]
    public string ParticipantId { get; set; }

    /// <summary>
    /// An ID which uniquely identifies the version of the document associated with this audit event
    /// </summary>
    /// <value>An ID which uniquely identifies the version of the document associated with this audit event</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Email address of the user that created the event
    /// </summary>
    /// <value>Email address of the user that created the event</value>
    [DataMember(Name="actingUserEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actingUserEmail")]
    public string ActingUserEmail { get; set; }

    /// <summary>
    /// Phone number from the device used when the participation is completed on a mobile phone
    /// </summary>
    /// <value>Phone number from the device used when the participation is completed on a mobile phone</value>
    [DataMember(Name="devicePhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "devicePhoneNumber")]
    public string DevicePhoneNumber { get; set; }

    /// <summary>
    /// Email address of the user that initiated the event on behalf of the acting user when the account is shared. Will be empty if there is no account sharing in effect
    /// </summary>
    /// <value>Email address of the user that initiated the event on behalf of the acting user when the account is shared. Will be empty if there is no account sharing in effect</value>
    [DataMember(Name="initiatingUserEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initiatingUserEmail")]
    public string InitiatingUserEmail { get; set; }

    /// <summary>
    /// This is present for ESIGNED events when the participation is signed digitally
    /// </summary>
    /// <value>This is present for ESIGNED events when the participation is signed digitally</value>
    [DataMember(Name="digitalSignatureInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "digitalSignatureInfo")]
    public DigitalSignatureInfo DigitalSignatureInfo { get; set; }

    /// <summary>
    /// Name of the vault provider for the vault event (if vaulted, otherwise null)
    /// </summary>
    /// <value>Name of the vault provider for the vault event (if vaulted, otherwise null)</value>
    [DataMember(Name="vaultProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vaultProviderName")]
    public string VaultProviderName { get; set; }

    /// <summary>
    /// The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE or SHARE, the message from the acting user to the participant
    /// </summary>
    /// <value>The event comment. For RECALLED or REJECTED, the reason given by the user that initiates the event. For DELEGATE or SHARE, the message from the acting user to the participant</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// A unique identifier linking offline events to synchronization events (specified for offline signing events and synchronization events, else null)
    /// </summary>
    /// <value>A unique identifier linking offline events to synchronization events (specified for offline signing events and synchronization events, else null)</value>
    [DataMember(Name="synchronizationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "synchronizationId")]
    public string SynchronizationId { get; set; }

    /// <summary>
    /// Location of the device that generated the event (This value may be null due to limited privileges)
    /// </summary>
    /// <value>Location of the device that generated the event (This value may be null due to limited privileges)</value>
    [DataMember(Name="deviceLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceLocation")]
    public DeviceLocation DeviceLocation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegasignEvent {\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  InitiatingUserName: ").Append(InitiatingUserName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ActingUserName: ").Append(ActingUserName).Append("\n");
      sb.Append("  ActingUserIpAddress: ").Append(ActingUserIpAddress).Append("\n");
      sb.Append("  ParticipantEmail: ").Append(ParticipantEmail).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ParticipantRole: ").Append(ParticipantRole).Append("\n");
      sb.Append("  VaultEventId: ").Append(VaultEventId).Append("\n");
      sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  ActingUserEmail: ").Append(ActingUserEmail).Append("\n");
      sb.Append("  DevicePhoneNumber: ").Append(DevicePhoneNumber).Append("\n");
      sb.Append("  InitiatingUserEmail: ").Append(InitiatingUserEmail).Append("\n");
      sb.Append("  DigitalSignatureInfo: ").Append(DigitalSignatureInfo).Append("\n");
      sb.Append("  VaultProviderName: ").Append(VaultProviderName).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  SynchronizationId: ").Append(SynchronizationId).Append("\n");
      sb.Append("  DeviceLocation: ").Append(DeviceLocation).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
