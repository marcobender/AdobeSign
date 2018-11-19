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
  public class DelegatedParticipantSetInfo {
    /// <summary>
    /// Participant set's private message - all participants in the set will receive the same message. This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>Participant set's private message - all participants in the set will receive the same message. This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="privateMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateMessage")]
    public string PrivateMessage { get; set; }

    /// <summary>
    /// Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set
    /// </summary>
    /// <value>Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set</value>
    [DataMember(Name="memberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberInfos")]
    public List<DelegatedParticipantInfo> MemberInfos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DelegatedParticipantSetInfo {\n");
      sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
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
