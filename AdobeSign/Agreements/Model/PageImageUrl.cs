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
  public class PageImageUrl {
    /// <summary>
    /// Page number within the document.
    /// </summary>
    /// <value>Page number within the document.</value>
    [DataMember(Name="pageNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageNumber")]
    public int PageNumber { get; set; }

    /// <summary>
    /// An image url.
    /// </summary>
    /// <value>An image url.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageImageUrl {\n");
      sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
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
