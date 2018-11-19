using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// Information required to add or update agreement form fields
  /// </summary>
  [DataContract]
  public class FormFieldPostInfo {
    /// <summary>
    /// The ID of the template from which to add new fields
    /// </summary>
    /// <value>The ID of the template from which to add new fields</value>
    [DataMember(Name="templateId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateId")]
    public string TemplateId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldPostInfo {\n");
      sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
