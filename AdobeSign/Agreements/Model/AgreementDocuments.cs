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
  public class AgreementDocuments {
    /// <summary>
    /// A list of documents
    /// </summary>
    /// <value>A list of documents</value>
    [DataMember(Name="documents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documents")]
    public List<Document> Documents { get; set; }

    /// <summary>
    /// A list of supporting documents
    /// </summary>
    /// <value>A list of supporting documents</value>
    [DataMember(Name="supportingDocuments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportingDocuments")]
    public List<SupportingDocument> SupportingDocuments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementDocuments {\n");
      sb.Append("  Documents: ").Append(Documents).Append("\n");
      sb.Append("  SupportingDocuments: ").Append(SupportingDocuments).Append("\n");
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
