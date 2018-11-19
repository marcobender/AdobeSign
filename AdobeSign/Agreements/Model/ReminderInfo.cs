using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ReminderInfo {
    /// <summary>
    /// An optional message sent to the recipients, describing why their participation is required
    /// </summary>
    /// <value>An optional message sent to the recipients, describing why their participation is required</value>
    [DataMember(Name="note", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "note")]
    public string Note { get; set; }

    /// <summary>
    /// The date when the reminder was last sent. Only provided in GET. Cannot be provided in POST request. If provided in POST, it will be ignored. Cannot be updated in a PUT. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The date when the reminder was last sent. Only provided in GET. Cannot be provided in POST request. If provided in POST, it will be ignored. Cannot be updated in a PUT. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="lastSentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastSentDate")]
    public DateTime? LastSentDate { get; set; }

    /// <summary>
    /// The date when the reminder is scheduled to be sent next. When provided in POST request, frequency needs to be ONCE (or not specified), startReminderCounterFrom needs to be REMINDER_CREATION (or not specified) and firstReminderDelay needs to be 0 (or not specified). Cannot be updated in a PUT. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The date when the reminder is scheduled to be sent next. When provided in POST request, frequency needs to be ONCE (or not specified), startReminderCounterFrom needs to be REMINDER_CREATION (or not specified) and firstReminderDelay needs to be 0 (or not specified). Cannot be updated in a PUT. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="nextSentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextSentDate")]
    public DateTime? NextSentDate { get; set; }

    /// <summary>
    /// An identifier of the reminder resource created on the server. If provided in POST or PUT, it will be ignored
    /// </summary>
    /// <value>An identifier of the reminder resource created on the server. If provided in POST or PUT, it will be ignored</value>
    [DataMember(Name="reminderId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderId")]
    public string ReminderId { get; set; }

    /// <summary>
    /// Integer which specifies the delay in hours before sending the first reminder.<br>This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.<br>If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.<br>i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT
    /// </summary>
    /// <value>Integer which specifies the delay in hours before sending the first reminder.<br>This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.<br>If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.<br>i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT</value>
    [DataMember(Name="firstReminderDelay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstReminderDelay")]
    public int? FirstReminderDelay { get; set; }

    /// <summary>
    /// A list of one or more participant IDs that the reminder should be sent to. These must be recipients of the agreement and not sharees or cc's.
    /// </summary>
    /// <value>A list of one or more participant IDs that the reminder should be sent to. These must be recipients of the agreement and not sharees or cc's.</value>
    [DataMember(Name="recipientParticipantIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recipientParticipantIds")]
    public List<string> RecipientParticipantIds { get; set; }

    /// <summary>
    /// Reminder can be sent based on when the agreement becomes available or when the reminder is created<br>AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.<br>REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.<br>Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT
    /// </summary>
    /// <value>Reminder can be sent based on when the agreement becomes available or when the reminder is created<br>AGREEMENT_AVAILABILITY: If the agreement is not available to the participant at the time of reminder creation, the reminder will be sent for the first time, only when the agreement becomes available to the participant taking the firstReminderDelay into account. Subsequent reminders will be sent based on the frequency specified.  If the agreement is already available to the participant at the time of reminder creation, the first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time.<br>REMINDER_CREATION: The first reminder will be sent after the delay specified by firstReminderDelay from the reminder creation time only if the agreement is available at that time. Subsequent reminders will be triggered based on the frequency specified and will be sent only if the agreement is available at that time.  For agreements in authoring state, creating reminder with startReminderCounterFrom as REMINDER_CREATION is not allowed.<br>Note : If firstReminderDelay, frequency and startReminderCounterFrom fields are not specified in POST, reminder will be sent right now if the agreement is available. If agreement is not available, an error will be thrown.  Cannot be updated in a PUT</value>
    [DataMember(Name="startReminderCounterFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startReminderCounterFrom")]
    public string StartReminderCounterFrom { get; set; }

    /// <summary>
    /// The frequency at which reminder will be sent until the agreement is completed.<br>If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT
    /// </summary>
    /// <value>The frequency at which reminder will be sent until the agreement is completed.<br>If frequency is not provided, the reminder will be sent once (if the agreement is available at the specified time) with the delay based on the firstReminderDelay field and will never repeat again. If the agreement is not available at that time, reminder will not be sent. Cannot be updated in a PUT</value>
    [DataMember(Name="frequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "frequency")]
    public string Frequency { get; set; }

    /// <summary>
    /// Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST.
    /// </summary>
    /// <value>Current status of the reminder.  The only valid update in a PUT is from ACTIVE to CANCELED.  Must be provided as ACTIVE in a POST.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReminderInfo {\n");
      sb.Append("  Note: ").Append(Note).Append("\n");
      sb.Append("  LastSentDate: ").Append(LastSentDate).Append("\n");
      sb.Append("  NextSentDate: ").Append(NextSentDate).Append("\n");
      sb.Append("  ReminderId: ").Append(ReminderId).Append("\n");
      sb.Append("  FirstReminderDelay: ").Append(FirstReminderDelay).Append("\n");
      sb.Append("  RecipientParticipantIds: ").Append(RecipientParticipantIds).Append("\n");
      sb.Append("  StartReminderCounterFrom: ").Append(StartReminderCounterFrom).Append("\n");
      sb.Append("  Frequency: ").Append(Frequency).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
