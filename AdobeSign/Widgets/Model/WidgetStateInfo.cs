using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Widgets.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetStateInfo {
    /// <summary>
    /// Specify custom message which will be displayed  to the user or the URL to which user will be redirected when the widget is accessed in disabled state. This can be specified only in PUT request
    /// </summary>
    /// <value>Specify custom message which will be displayed  to the user or the URL to which user will be redirected when the widget is accessed in disabled state. This can be specified only in PUT request</value>
    [DataMember(Name="widgetInActiveInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetInActiveInfo")]
    public WidgetInActiveInfo WidgetInActiveInfo { get; set; }

    /// <summary>
    /// State of the Widget
    /// </summary>
    /// <value>State of the Widget</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetStateInfo {\n");
      sb.Append("  WidgetInActiveInfo: ").Append(WidgetInActiveInfo).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
