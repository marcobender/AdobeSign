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
  public class WidgetInActiveInfo {
    /// <summary>
    /// Redirect the user to this URL when the widget is accessed. This is required if message is not provided. Both message and redirectUrl can not be specified.
    /// </summary>
    /// <value>Redirect the user to this URL when the widget is accessed. This is required if message is not provided. Both message and redirectUrl can not be specified.</value>
    [DataMember(Name="redirectUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "redirectUrl")]
    public string RedirectUrl { get; set; }

    /// <summary>
    /// Display this custom message to the user when the widget is accessed. Note that this can contain wiki markup to include clickable links in the message. This is required if redirectUrl is not provided. Both message and redirectUrl can not be specified.
    /// </summary>
    /// <value>Display this custom message to the user when the widget is accessed. Note that this can contain wiki markup to include clickable links in the message. This is required if redirectUrl is not provided. Both message and redirectUrl can not be specified.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetInActiveInfo {\n");
      sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
