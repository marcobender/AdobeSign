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
  public class WidgetRedirectionInfo {
    /// <summary>
    /// The delay (in seconds) before the user is taken to the resultant page. If this value is greater than 0, the user will first see the standard Adobe Sign result message, and then after a delay will be redirected to your resultant page.   Note that this parameter has no effect for embedded widgets when deframe is true
    /// </summary>
    /// <value>The delay (in seconds) before the user is taken to the resultant page. If this value is greater than 0, the user will first see the standard Adobe Sign result message, and then after a delay will be redirected to your resultant page.   Note that this parameter has no effect for embedded widgets when deframe is true</value>
    [DataMember(Name="delay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delay")]
    public int? Delay { get; set; }

    /// <summary>
    /// If deframe is false, the resultant page will be shown inside the widget frame. If deframe is true, the resultant page will be shown in the full browser window.   Note that in the case of embedded widgets, browser security restrictions do not permit automatic redirection in the full browser window, so if deframe is true the user will instead just see a link to the success page. We recommend this scenario be avoided - in other words, setting deframe to false is recommended for embedded widgets
    /// </summary>
    /// <value>If deframe is false, the resultant page will be shown inside the widget frame. If deframe is true, the resultant page will be shown in the full browser window.   Note that in the case of embedded widgets, browser security restrictions do not permit automatic redirection in the full browser window, so if deframe is true the user will instead just see a link to the success page. We recommend this scenario be avoided - in other words, setting deframe to false is recommended for embedded widgets</value>
    [DataMember(Name="deframe", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deframe")]
    public bool? Deframe { get; set; }

    /// <summary>
    /// A publicly accessible url to which the user will be sent after successfully completing the widget.  If the URL you provide includes information that allows you to identify the specific transaction, such as your own unique identifier, you can use the browser request to this URL as a callback to notify you that this transaction is completed.  In addition, Adobe Sign will append a documentKey parameter to the URL which will contain the Adobe Sign DocumentKey for this signed widget, but only if the sender is the same as the API key user. Your application can use this value to get the form data for this widget
    /// </summary>
    /// <value>A publicly accessible url to which the user will be sent after successfully completing the widget.  If the URL you provide includes information that allows you to identify the specific transaction, such as your own unique identifier, you can use the browser request to this URL as a callback to notify you that this transaction is completed.  In addition, Adobe Sign will append a documentKey parameter to the URL which will contain the Adobe Sign DocumentKey for this signed widget, but only if the sender is the same as the API key user. Your application can use this value to get the form data for this widget</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetRedirectionInfo {\n");
      sb.Append("  Delay: ").Append(Delay).Append("\n");
      sb.Append("  Deframe: ").Append(Deframe).Append("\n");
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
