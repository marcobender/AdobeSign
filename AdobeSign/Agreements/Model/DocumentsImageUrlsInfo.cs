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
  public class DocumentsImageUrlsInfo {
    /// <summary>
    /// A list of supporting document image URLs info.
    /// </summary>
    /// <value>A list of supporting document image URLs info.</value>
    [DataMember(Name="supportingDocumentsImageUrlsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportingDocumentsImageUrlsInfo")]
    public List<DocumentImageUrlsInfo> SupportingDocumentsImageUrlsInfo { get; set; }

    /// <summary>
    /// A list of original document image URLs info.
    /// </summary>
    /// <value>A list of original document image URLs info.</value>
    [DataMember(Name="originalDocumentsImageUrlsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalDocumentsImageUrlsInfo")]
    public List<DocumentImageUrlsInfo> OriginalDocumentsImageUrlsInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsImageUrlsInfo {\n");
      sb.Append("  SupportingDocumentsImageUrlsInfo: ").Append(SupportingDocumentsImageUrlsInfo).Append("\n");
      sb.Append("  OriginalDocumentsImageUrlsInfo: ").Append(OriginalDocumentsImageUrlsInfo).Append("\n");
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
