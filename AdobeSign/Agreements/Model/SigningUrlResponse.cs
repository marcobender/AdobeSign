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
  public class SigningUrlResponse {
    /// <summary>
    /// An array of urls for signer sets involved in this agreement.
    /// </summary>
    /// <value>An array of urls for signer sets involved in this agreement.</value>
    [DataMember(Name="signingUrlSetInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingUrlSetInfos")]
    public List<SigningUrlSetInfo> SigningUrlSetInfos { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SigningUrlResponse {\n");
      sb.Append("  SigningUrlSetInfos: ").Append(SigningUrlSetInfos).Append("\n");
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
