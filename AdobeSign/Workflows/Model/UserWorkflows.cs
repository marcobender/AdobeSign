using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Workflows.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserWorkflows {
    /// <summary>
    /// An array of workflows
    /// </summary>
    /// <value>An array of workflows</value>
    [DataMember(Name="userWorkflowList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userWorkflowList")]
    public List<UserWorkflow> UserWorkflowList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWorkflows {\n");
      sb.Append("  UserWorkflowList: ").Append(UserWorkflowList).Append("\n");
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
