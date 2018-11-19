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
  public class UserWorkflow {
    /// <summary>
    /// Identifier of scope. Currently it is applicable for scope GROUP only and the value will be groupId.
    /// </summary>
    /// <value>Identifier of scope. Currently it is applicable for scope GROUP only and the value will be groupId.</value>
    [DataMember(Name="scopeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scopeId")]
    public string ScopeId { get; set; }

    /// <summary>
    /// The date on which the workflow was created. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The date on which the workflow was created. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="created", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// The display name of the workflow.
    /// </summary>
    /// <value>The display name of the workflow.</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The workflow scope (ACCOUNT or GROUP or OTHER)
    /// </summary>
    /// <value>The workflow scope (ACCOUNT or GROUP or OTHER)</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// The name of the workflow.
    /// </summary>
    /// <value>The name of the workflow.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Description provided for this workflow at the time of its creation
    /// </summary>
    /// <value>Description provided for this workflow at the time of its creation</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The unique identifier of a workflow
    /// </summary>
    /// <value>The unique identifier of a workflow</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The workflow status (ACTIVE or DRAFT or INACTIVE or OTHER)
    /// </summary>
    /// <value>The workflow status (ACTIVE or DRAFT or INACTIVE or OTHER)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWorkflow {\n");
      sb.Append("  ScopeId: ").Append(ScopeId).Append("\n");
      sb.Append("  Created: ").Append(Created).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
