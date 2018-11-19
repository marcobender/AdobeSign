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
  public class SenderInfo {
    /// <summary>
    ///  The unique identifier of the creator of the widget.
    /// </summary>
    /// <value> The unique identifier of the creator of the widget.</value>
    [DataMember(Name="participantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantId")]
    public string ParticipantId { get; set; }

    /// <summary>
    /// Name of the creator, if available.
    /// </summary>
    /// <value>Name of the creator, if available.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// True if the creator of the widget is the same user that is calling the API.
    /// </summary>
    /// <value>True if the creator of the widget is the same user that is calling the API.</value>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public bool? Self { get; set; }

    /// <summary>
    /// Company of the creator, if available.
    /// </summary>
    /// <value>Company of the creator, if available.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// Email of the creator of the widget.
    /// </summary>
    /// <value>Email of the creator of the widget.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SenderInfo {\n");
      sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
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
