using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// A JSON list of all of the fields for a form
  /// </summary>
  [DataContract]
  public class AgreementFormFields {
    /// <summary>
    /// List of the form fields in an agreement
    /// </summary>
    /// <value>List of the form fields in an agreement</value>
    [DataMember(Name="fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fields")]
    public List<FormField> Fields { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementFormFields {\n");
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
