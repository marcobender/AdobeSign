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
  public class FileInfo {
    /// <summary>
    /// ID for a transient document that will be added to the library document
    /// </summary>
    /// <value>ID for a transient document that will be added to the library document</value>
    [DataMember(Name="transientDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transientDocumentId")]
    public string TransientDocumentId { get; set; }

    /// <summary>
    /// The unique label value of a file info element. In case of custom workflow this will map a file to corresponding file element in workflow definition. This must be specified in case of custom workflow agreement creation request 
    /// </summary>
    /// <value>The unique label value of a file info element. In case of custom workflow this will map a file to corresponding file element in workflow definition. This must be specified in case of custom workflow agreement creation request </value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// URL for an external document to add to the library document
    /// </summary>
    /// <value>URL for an external document to add to the library document</value>
    [DataMember(Name="urlFileInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "urlFileInfo")]
    public URLFileInfo UrlFileInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FileInfo {\n");
      sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  UrlFileInfo: ").Append(UrlFileInfo).Append("\n");
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
