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
  public class MegaSignViewResponse {
    /// <summary>
    /// List of mega sign views
    /// </summary>
    /// <value>List of mega sign views</value>
    [DataMember(Name="megaSignViewList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "megaSignViewList")]
    public List<MegaSignView> MegaSignViewList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignViewResponse {\n");
      sb.Append("  MegaSignViewList: ").Append(MegaSignViewList).Append("\n");
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
