using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.TransientDocuments.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TransientDocumentResponse {
    /// <summary>
    /// The unique identifier of the uploaded document that can be used in an agreement or a megaSign or widget creation call
    /// </summary>
    /// <value>The unique identifier of the uploaded document that can be used in an agreement or a megaSign or widget creation call</value>
    [DataMember(Name="transientDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transientDocumentId")]
    public string TransientDocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransientDocumentResponse {\n");
      sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
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
