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
  public class AgreementCancellationInfo {
    /// <summary>
    /// An optional comment describing to the recipients why you want to cancel the transaction
    /// </summary>
    /// <value>An optional comment describing to the recipients why you want to cancel the transaction</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Whether or not you would like the recipients to be notified that the transaction has been cancelled. The default value is false
    /// </summary>
    /// <value>Whether or not you would like the recipients to be notified that the transaction has been cancelled. The default value is false</value>
    [DataMember(Name="notifyOthers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifyOthers")]
    public bool? NotifyOthers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementCancellationInfo {\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  NotifyOthers: ").Append(NotifyOthers).Append("\n");
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
