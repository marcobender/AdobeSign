using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// Information required to add or replace agreement form fields
  /// </summary>
  [DataContract]
  public class FormFieldPutInfo {
    /// <summary>
    /// The list of fields to update or replace. PDF_SIGNATURE inputType field is currently not supported.
    /// </summary>
    /// <value>The list of fields to update or replace. PDF_SIGNATURE inputType field is currently not supported.</value>
    [DataMember(Name="fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fields")]
    public List<FormField> Fields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldPutInfo {\n");
      sb.Append("  Fields: ").Append(Fields).Append("\n");
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
