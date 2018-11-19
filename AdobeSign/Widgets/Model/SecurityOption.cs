using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Widgets.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SecurityOption {
    /// <summary>
    /// The secondary password that will be used to secure the PDF document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties
    /// </summary>
    /// <value>The secondary password that will be used to secure the PDF document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties</value>
    [DataMember(Name="openPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openPassword")]
    public string OpenPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecurityOption {\n");
      sb.Append("  OpenPassword: ").Append(OpenPassword).Append("\n");
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
