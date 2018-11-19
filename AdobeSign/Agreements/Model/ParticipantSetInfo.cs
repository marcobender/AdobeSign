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
  public class ParticipantSetInfo {
    /// <summary>
    /// Role assumed by all participants in the set (signer, approver etc.)
    /// </summary>
    /// <value>Role assumed by all participants in the set (signer, approver etc.)</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public string Role { get; set; }

    /// <summary>
    /// When you enable limited document visibility (documentVisibilityEnabled), you can specify which file (fileInfo) should be made visible to which specific participant set.<br>Specify one or more label values of a fileInfos element.<br>Each signer participant sets must contain at least one required signature field in at least one visible file included in this API call; if not a page with a signature field is automatically appended for any missing participant sets. If there is a possibility that one or more participant sets do not have a required signature field in the files included in the API call, all signer participant sets should include a special index value of '0' to make this automatically appended signature page visible to the signer. Not doing so may result in an error. For all other roles, you may omit this value to exclude this page.
    /// </summary>
    /// <value>When you enable limited document visibility (documentVisibilityEnabled), you can specify which file (fileInfo) should be made visible to which specific participant set.<br>Specify one or more label values of a fileInfos element.<br>Each signer participant sets must contain at least one required signature field in at least one visible file included in this API call; if not a page with a signature field is automatically appended for any missing participant sets. If there is a possibility that one or more participant sets do not have a required signature field in the files included in the API call, all signer participant sets should include a special index value of '0' to make this automatically appended signature page visible to the signer. Not doing so may result in an error. For all other roles, you may omit this value to exclude this page.</value>
    [DataMember(Name="visiblePages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visiblePages")]
    public List<string> VisiblePages { get; set; }

    /// <summary>
    /// Name of the participant set (it can be empty, but needs not to be unique in a single agreement). Maximum no of characters in participant set name is restricted to 255
    /// </summary>
    /// <value>Name of the participant set (it can be empty, but needs not to be unique in a single agreement). Maximum no of characters in participant set name is restricted to 255</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique label of a participant set.<br>For custom workflows, label specified in the participation set should map it to the participation step in the custom workflow.
    /// </summary>
    /// <value>The unique label of a participant set.<br>For custom workflows, label specified in the participation set should map it to the participation step in the custom workflow.</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// Participant set's private message - all participants in the set will receive the same message
    /// </summary>
    /// <value>Participant set's private message - all participants in the set will receive the same message</value>
    [DataMember(Name="privateMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateMessage")]
    public string PrivateMessage { get; set; }

    /// <summary>
    /// Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set
    /// </summary>
    /// <value>Array of ParticipantInfo objects, containing participant-specific data (e.g. email). All participants in the array belong to the same set</value>
    [DataMember(Name="memberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberInfos")]
    public List<ParticipantSetMemberInfo> MemberInfos { get; set; }

    /// <summary>
    /// Index indicating position at which signing group needs to sign. Signing group to sign at first place is assigned a 1 index. Different signingOrder specified in input should form a valid consecutive increasing sequence of integers. Otherwise signingOrder will be considered invalid. No signingOrder should be specified for SHARE role
    /// </summary>
    /// <value>Index indicating position at which signing group needs to sign. Signing group to sign at first place is assigned a 1 index. Different signingOrder specified in input should form a valid consecutive increasing sequence of integers. Otherwise signingOrder will be considered invalid. No signingOrder should be specified for SHARE role</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public int? Order { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParticipantSetInfo {\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  VisiblePages: ").Append(VisiblePages).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
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
