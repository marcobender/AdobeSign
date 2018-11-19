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
  public class CombinedDocumentPagesInfo {
    /// <summary>
    /// List of basic information of all pages of the combined document of an Agreement.
    /// </summary>
    /// <value>List of basic information of all pages of the combined document of an Agreement.</value>
    [DataMember(Name="documentPagesInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentPagesInfo")]
    public List<DocumentPageInfo> DocumentPagesInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CombinedDocumentPagesInfo {\n");
      sb.Append("  DocumentPagesInfo: ").Append(DocumentPagesInfo).Append("\n");
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
