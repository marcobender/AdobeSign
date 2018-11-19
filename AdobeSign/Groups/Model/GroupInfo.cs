using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Groups.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class GroupInfo {
    /// <summary>
    /// Name of the group
    /// </summary>
    /// <value>Name of the group</value>
    [DataMember(Name="groupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupName")]
    public string GroupName { get; set; }

    /// <summary>
    /// Unique identifier of the group
    /// </summary>
    /// <value>Unique identifier of the group</value>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public string GroupId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupInfo {\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
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
