using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Users.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserGroupInfo {
    /// <summary>
    /// True if user is group admin.
    /// </summary>
    /// <value>True if user is group admin.</value>
    [DataMember(Name="isGroupAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isGroupAdmin")]
    public bool? IsGroupAdmin { get; set; }

    /// <summary>
    /// Name of the group. This will be ignored as part of PUT call.
    /// </summary>
    /// <value>Name of the group. This will be ignored as part of PUT call.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Unique identifier of the group
    /// </summary>
    /// <value>Unique identifier of the group</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserGroupInfo {\n");
      sb.Append("  IsGroupAdmin: ").Append(IsGroupAdmin).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
