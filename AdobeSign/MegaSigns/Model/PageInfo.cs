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
  public class PageInfo {
    /// <summary>
    /// Used to navigate to the next page. If not returned, there are no further pages.
    /// </summary>
    /// <value>Used to navigate to the next page. If not returned, there are no further pages.</value>
    [DataMember(Name="nextCursor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextCursor")]
    public string NextCursor { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PageInfo {\n");
      sb.Append("  NextCursor: ").Append(NextCursor).Append("\n");
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
