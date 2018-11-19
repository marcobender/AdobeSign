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
  public class DocumentImageUrlsInfo {
    /// <summary>
    /// A list of documents image URLs.
    /// </summary>
    /// <value>A list of documents image URLs.</value>
    [DataMember(Name="documentImageUrlsList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentImageUrlsList")]
    public List<DocumentImageUrls> DocumentImageUrlsList { get; set; }

    /// <summary>
    /// Id of the document
    /// </summary>
    /// <value>Id of the document</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentImageUrlsInfo {\n");
      sb.Append("  DocumentImageUrlsList: ").Append(DocumentImageUrlsList).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
