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
  public class AgreementStateInfo {
    /// <summary>
    /// Cancellation information for the agreement
    /// </summary>
    /// <value>Cancellation information for the agreement</value>
    [DataMember(Name="agreementCancellationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementCancellationInfo")]
    public AgreementCancellationInfo AgreementCancellationInfo { get; set; }

    /// <summary>
    /// The state in which the agreement should land
    /// </summary>
    /// <value>The state in which the agreement should land</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementStateInfo {\n");
      sb.Append("  AgreementCancellationInfo: ").Append(AgreementCancellationInfo).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
