using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.MegaSigns.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MegaSignStateInfo {
    /// <summary>
    /// The state to which the megaSign is to be updated. The only valid state for this variable is currently, CANCELLED
    /// </summary>
    /// <value>The state to which the megaSign is to be updated. The only valid state for this variable is currently, CANCELLED</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Cancellation information for the agreement. Mandatory while cancelling a megaSign
    /// </summary>
    /// <value>Cancellation information for the agreement. Mandatory while cancelling a megaSign</value>
    [DataMember(Name="megaSignCancellationInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "megaSignCancellationInfo")]
    public AgreementCancellationInfo MegaSignCancellationInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignStateInfo {\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  MegaSignCancellationInfo: ").Append(MegaSignCancellationInfo).Append("\n");
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
