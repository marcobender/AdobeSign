using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// A predicate used to determine whether the condtion succeeds
  /// </summary>
  [DataContract]
  public class FormFieldConditionPredicate {
    /// <summary>
    /// Name of the field whose value is the basis of predicate
    /// </summary>
    /// <value>Name of the field whose value is the basis of predicate</value>
    [DataMember(Name="fieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// Value to compare against the value of the predicate's form field, using the specified operator
    /// </summary>
    /// <value>Value to compare against the value of the predicate's form field, using the specified operator</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Operator to be applied on the value of the predicate field.
    /// </summary>
    /// <value>Operator to be applied on the value of the predicate field.</value>
    [DataMember(Name="operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operator")]
    public string _Operator { get; set; }

    /// <summary>
    /// Index of the location of the form field used in the predicate
    /// </summary>
    /// <value>Index of the location of the form field used in the predicate</value>
    [DataMember(Name="fieldLocationIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldLocationIndex")]
    public int FieldLocationIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldConditionPredicate {\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  FieldLocationIndex: ").Append(FieldLocationIndex).Append("\n");
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
