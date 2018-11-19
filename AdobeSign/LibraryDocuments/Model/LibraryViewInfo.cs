using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.LibraryDocuments.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LibraryViewInfo {
    /// <summary>
    /// Common view configuration for all the available views
    /// </summary>
    /// <value>Common view configuration for all the available views</value>
    [DataMember(Name="commonViewConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonViewConfiguration")]
    public CommonViewConfiguration CommonViewConfiguration { get; set; }

    /// <summary>
    /// Name of the requested libraryDocument view
    /// </summary>
    /// <value>Name of the requested libraryDocument view</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Send page view configuration. This will be ignored for views other than SEND.
    /// </summary>
    /// <value>Send page view configuration. This will be ignored for views other than SEND.</value>
    [DataMember(Name="sendViewConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendViewConfiguration")]
    public SendViewConfiguration SendViewConfiguration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LibraryViewInfo {\n");
      sb.Append("  CommonViewConfiguration: ").Append(CommonViewConfiguration).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  SendViewConfiguration: ").Append(SendViewConfiguration).Append("\n");
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
