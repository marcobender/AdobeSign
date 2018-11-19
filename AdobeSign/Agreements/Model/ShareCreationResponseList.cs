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
  public class ShareCreationResponseList {
    /// <summary>
    /// List of ShareCreationResponse
    /// </summary>
    /// <value>List of ShareCreationResponse</value>
    [DataMember(Name="shareCreationResponseList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shareCreationResponseList")]
    public List<ShareCreationResponse> _ShareCreationResponseList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShareCreationResponseList {\n");
      sb.Append("  _ShareCreationResponseList: ").Append(_ShareCreationResponseList).Append("\n");
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
