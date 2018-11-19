using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Users.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CommonViewConfiguration {
    /// <summary>
    /// Auto LogIn Flag. If true, the URL returned will automatically log the user in. If false, the URL returned will require the credentials. By default its value is false
    /// </summary>
    /// <value>Auto LogIn Flag. If true, the URL returned will automatically log the user in. If false, the URL returned will require the credentials. By default its value is false</value>
    [DataMember(Name="autoLoginUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "autoLoginUser")]
    public bool? AutoLoginUser { get; set; }

    /// <summary>
    /// No Chrome Flag. If true, the embedded page is shown without a navigation header or footer. If false, the standard page header and footer will be present. By default its value is false
    /// </summary>
    /// <value>No Chrome Flag. If true, the embedded page is shown without a navigation header or footer. If false, the standard page header and footer will be present. By default its value is false</value>
    [DataMember(Name="noChrome", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noChrome")]
    public bool? NoChrome { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommonViewConfiguration {\n");
      sb.Append("  AutoLoginUser: ").Append(AutoLoginUser).Append("\n");
      sb.Append("  NoChrome: ").Append(NoChrome).Append("\n");
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
