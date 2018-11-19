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
  public class WidgetAdditionalParticipationSetInfo {
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
    /// Index indicating position at which signing group needs to sign. Additional participant to sign at first place is assigned a index of 1. Widget participant should not have any order specified. Widget participant should not have any email address and and can not have phone authentication applied. Different signingOrder specified in input should form a valid consecutive increasing sequence of integers. Otherwise signingOrder will be considered invalid
    /// </summary>
    /// <value>Index indicating position at which signing group needs to sign. Additional participant to sign at first place is assigned a index of 1. Widget participant should not have any order specified. Widget participant should not have any email address and and can not have phone authentication applied. Different signingOrder specified in input should form a valid consecutive increasing sequence of integers. Otherwise signingOrder will be considered invalid</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetAdditionalParticipationSetInfo {\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
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
