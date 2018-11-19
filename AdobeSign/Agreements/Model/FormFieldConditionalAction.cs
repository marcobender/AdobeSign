using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// Conditional actions to perfom on this form field.
  /// </summary>
  [DataContract]
  public class FormFieldConditionalAction {
    /// <summary>
    /// The predicates to be evaluated in order to determine whether this condition is true
    /// </summary>
    /// <value>The predicates to be evaluated in order to determine whether this condition is true</value>
    [DataMember(Name="predicates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predicates")]
    public List<FormFieldConditionPredicate> Predicates { get; set; }

    /// <summary>
    /// It indicates if any one of the conditions or all of them have to be true.
    /// </summary>
    /// <value>It indicates if any one of the conditions or all of them have to be true.</value>
    [DataMember(Name="anyOrAll", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "anyOrAll")]
    public string AnyOrAll { get; set; }

    /// <summary>
    /// Action to show/hide the form field is to be taken on the basis of evaluation of conditions.
    /// </summary>
    /// <value>Action to show/hide the form field is to be taken on the basis of evaluation of conditions.</value>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldConditionalAction {\n");
      sb.Append("  Predicates: ").Append(Predicates).Append("\n");
      sb.Append("  AnyOrAll: ").Append(AnyOrAll).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
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
