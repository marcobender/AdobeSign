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
  public class DisplayParticipantSetInfo {
    /// <summary>
    /// Displays the info about user set
    /// </summary>
    /// <value>Displays the info about user set</value>
    [DataMember(Name="displayUserSetMemberInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayUserSetMemberInfos")]
    public List<DisplayParticipantInfo> DisplayUserSetMemberInfos { get; set; }

    /// <summary>
    /// The name of the display user set. Returned only, if the API caller is the sender of agreement. 
    /// </summary>
    /// <value>The name of the display user set. Returned only, if the API caller is the sender of agreement. </value>
    [DataMember(Name="displayUserSetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayUserSetName")]
    public string DisplayUserSetName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DisplayParticipantSetInfo {\n");
      sb.Append("  DisplayUserSetMemberInfos: ").Append(DisplayUserSetMemberInfos).Append("\n");
      sb.Append("  DisplayUserSetName: ").Append(DisplayUserSetName).Append("\n");
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
