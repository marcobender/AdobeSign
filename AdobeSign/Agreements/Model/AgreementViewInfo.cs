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
  public class AgreementViewInfo {
    /// <summary>
    /// Compose page view configuration
    /// </summary>
    /// <value>Compose page view configuration</value>
    [DataMember(Name="composeViewConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "composeViewConfiguration")]
    public ComposeViewConfiguration ComposeViewConfiguration { get; set; }

    /// <summary>
    /// Common view configuration for all the available views
    /// </summary>
    /// <value>Common view configuration for all the available views</value>
    [DataMember(Name="commonViewConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonViewConfiguration")]
    public CommonViewConfiguration CommonViewConfiguration { get; set; }

    /// <summary>
    /// Name of the requested agreement view
    /// </summary>
    /// <value>Name of the requested agreement view</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementViewInfo {\n");
      sb.Append("  ComposeViewConfiguration: ").Append(ComposeViewConfiguration).Append("\n");
      sb.Append("  CommonViewConfiguration: ").Append(CommonViewConfiguration).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
