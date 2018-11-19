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
  public class WidgetViews {
    /// <summary>
    /// List of widget views
    /// </summary>
    /// <value>List of widget views</value>
    [DataMember(Name="widgetViewList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetViewList")]
    public List<WidgetView> WidgetViewList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetViews {\n");
      sb.Append("  WidgetViewList: ").Append(WidgetViewList).Append("\n");
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
