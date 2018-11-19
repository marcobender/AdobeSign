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
  public class DelegatedParticipantSecurityOption {
    /// <summary>
    /// The phoneInfo required for the participant to view and sign the document
    /// </summary>
    /// <value>The phoneInfo required for the participant to view and sign the document</value>
    [DataMember(Name="phoneInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DelegatedParticipantSecurityOption {\n");
      sb.Append("  PhoneInfo: ").Append(PhoneInfo).Append("\n");
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
