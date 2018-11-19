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
  public class WidgetParticipantSetInfo {
    /// <summary>
    /// Role assumed by all participants in the set (signer, approver, etc.) Widget First Participant will only have roles - Signer, Approver, Acceptor and Form Filler
    /// </summary>
    /// <value>Role assumed by all participants in the set (signer, approver, etc.) Widget First Participant will only have roles - Signer, Approver, Acceptor and Form Filler</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// Array of ParticipantInfo objects, containing participant - specific data (email, e.g.). All participants in the array belong to the same set. Currently we are supporting only one member in the set. Since the email of the widget signer is unknown at the time of widget creation, the email should be left empty and its optional security options should be provided. 
    /// </summary>
    /// <value>Array of ParticipantInfo objects, containing participant - specific data (email, e.g.). All participants in the array belong to the same set. Currently we are supporting only one member in the set. Since the email of the widget signer is unknown at the time of widget creation, the email should be left empty and its optional security options should be provided. </value>
    [DataMember(Name="memberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberInfos")]
    public List<ParticipantSetMemberInfo> MemberInfos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetParticipantSetInfo {\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  MemberInfos: ").Append(MemberInfos).Append("\n");
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
