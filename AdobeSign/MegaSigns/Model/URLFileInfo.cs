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
  public class URLFileInfo {
    /// <summary>
    /// The original system file name of the document being sent
    /// </summary>
    /// <value>The original system file name of the document being sent</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The mime type of the referenced file, used to determine if the file can be accepted and the necessary conversion steps can be performed
    /// </summary>
    /// <value>The mime type of the referenced file, used to determine if the file can be accepted and the necessary conversion steps can be performed</value>
    [DataMember(Name="mimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }

    /// <summary>
    /// A publicly accessible URL for retrieving the raw file content
    /// </summary>
    /// <value>A publicly accessible URL for retrieving the raw file content</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class URLFileInfo {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
