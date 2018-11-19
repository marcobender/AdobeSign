using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Widgets.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ShareParticipantInfo {
    /// <summary>
    /// The unique identifier of the sharee participant of the widget.
    /// </summary>
    /// <value>The unique identifier of the sharee participant of the widget.</value>
    [DataMember(Name="participantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantId")]
    public string ParticipantId { get; set; }

    /// <summary>
    /// Name of the sharee participant of the widget, if available.
    /// </summary>
    /// <value>Name of the sharee participant of the widget, if available.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier of the participant who shared the widget.
    /// </summary>
    /// <value>The unique identifier of the participant who shared the widget.</value>
    [DataMember(Name="sharerParticipantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharerParticipantId")]
    public string SharerParticipantId { get; set; }

    /// <summary>
    /// Company of the sharee participant of the widget, if available.
    /// </summary>
    /// <value>Company of the sharee participant of the widget, if available.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Email of the sharee participant of the widget.
    /// </summary>
    /// <value>Email of the sharee participant of the widget.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShareParticipantInfo {\n");
      sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SharerParticipantId: ").Append(SharerParticipantId).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
