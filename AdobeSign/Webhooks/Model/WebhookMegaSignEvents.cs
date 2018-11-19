using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WebhookMegaSignEvents {
    /// <summary>
    /// Determines whether megaign detailed info will be returned in the response payload
    /// </summary>
    /// <value>Determines whether megaign detailed info will be returned in the response payload</value>
    [DataMember(Name="includeDetailedInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeDetailedInfo")]
    public bool? IncludeDetailedInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhookMegaSignEvents {\n");
      sb.Append("  IncludeDetailedInfo: ").Append(IncludeDetailedInfo).Append("\n");
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
