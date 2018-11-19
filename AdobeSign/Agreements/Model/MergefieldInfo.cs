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
  public class MergefieldInfo {
    /// <summary>
    /// The name of the field
    /// </summary>
    /// <value>The name of the field</value>
    [DataMember(Name="fieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// The default value of the field
    /// </summary>
    /// <value>The default value of the field</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MergefieldInfo {\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
