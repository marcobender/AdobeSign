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
  public class SigningUrlSetInfo {
    /// <summary>
    /// An array of urls for current signer set.
    /// </summary>
    /// <value>An array of urls for current signer set.</value>
    [DataMember(Name="signingUrls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingUrls")]
    public List<SigningUrl> SigningUrls { get; set; }

    /// <summary>
    /// The name of the current signer set. Returned only, if the API caller is the sender of agreement
    /// </summary>
    /// <value>The name of the current signer set. Returned only, if the API caller is the sender of agreement</value>
    [DataMember(Name="signingUrlSetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signingUrlSetName")]
    public string SigningUrlSetName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SigningUrlSetInfo {\n");
      sb.Append("  SigningUrls: ").Append(SigningUrls).Append("\n");
      sb.Append("  SigningUrlSetName: ").Append(SigningUrlSetName).Append("\n");
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
