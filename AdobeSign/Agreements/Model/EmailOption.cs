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
  public class EmailOption {
    /// <summary>
    /// Specify emails to be sent to different participants at different steps of the agreement process. Note: ALL means  emails for the events will be sent to all participants. NONE means emails for the events will not be sent to any participant
    /// </summary>
    /// <value>Specify emails to be sent to different participants at different steps of the agreement process. Note: ALL means  emails for the events will be sent to all participants. NONE means emails for the events will not be sent to any participant</value>
    [DataMember(Name="sendOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sendOptions")]
    public SendOptions SendOptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EmailOption {\n");
      sb.Append("  SendOptions: ").Append(SendOptions).Append("\n");
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
