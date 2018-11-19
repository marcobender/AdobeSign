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
  public class FileUploadOptions {
    /// <summary>
    /// Whether local file upload button should appear or not. Default value is taken as true
    /// </summary>
    /// <value>Whether local file upload button should appear or not. Default value is taken as true</value>
    [DataMember(Name="localFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "localFile")]
    public bool? LocalFile { get; set; }

    /// <summary>
    /// Whether link to attach documents from web sources like Dropbox should appear or not. Default value is taken as true
    /// </summary>
    /// <value>Whether link to attach documents from web sources like Dropbox should appear or not. Default value is taken as true</value>
    [DataMember(Name="webConnectors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webConnectors")]
    public bool? WebConnectors { get; set; }

    /// <summary>
    /// Whether library documents link should appear or not. Default value is taken as true
    /// </summary>
    /// <value>Whether library documents link should appear or not. Default value is taken as true</value>
    [DataMember(Name="libraryDocument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryDocument")]
    public bool? LibraryDocument { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileUploadOptions {\n");
      sb.Append("  LocalFile: ").Append(LocalFile).Append("\n");
      sb.Append("  WebConnectors: ").Append(WebConnectors).Append("\n");
      sb.Append("  LibraryDocument: ").Append(LibraryDocument).Append("\n");
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
