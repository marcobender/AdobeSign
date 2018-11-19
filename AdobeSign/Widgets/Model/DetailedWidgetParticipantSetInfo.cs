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
  public class DetailedWidgetParticipantSetInfo {
    /// <summary>
    /// Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>Role assumed by all participants in the set (signer, approver etc.). This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// The unique identifier of the participant set. This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>The unique identifier of the participant set. This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set
    /// </summary>
    /// <value>Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set</value>
    [DataMember(Name="memberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberInfos")]
    public List<DetailedParticipantInfo> MemberInfos { get; set; }

    /// <summary>
    /// Index indicating sequential signing group (specified for hybrid routing). This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>Index indicating sequential signing group (specified for hybrid routing). This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedWidgetParticipantSetInfo {\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MemberInfos: ").Append(MemberInfos).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
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
