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
  public class SendOptions {
    /// <summary>
    /// Control notification mails for Agreement initiation events - ACTION_REQUESTED and CREATED
    /// </summary>
    /// <value>Control notification mails for Agreement initiation events - ACTION_REQUESTED and CREATED</value>
    [DataMember(Name="initEmails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initEmails")]
    public string InitEmails { get; set; }

    /// <summary>
    /// Control notification mails for agreement-in-process events - DELEGATED, REPLACED
    /// </summary>
    /// <value>Control notification mails for agreement-in-process events - DELEGATED, REPLACED</value>
    [DataMember(Name="inFlightEmails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inFlightEmails")]
    public string InFlightEmails { get; set; }

    /// <summary>
    /// Control notification mails for agreement completion events - COMPLETED, CANCELLED, EXPIRED and REJECTED
    /// </summary>
    /// <value>Control notification mails for agreement completion events - COMPLETED, CANCELLED, EXPIRED and REJECTED</value>
    [DataMember(Name="completionEmails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionEmails")]
    public string CompletionEmails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SendOptions {\n");
      sb.Append("  InitEmails: ").Append(InitEmails).Append("\n");
      sb.Append("  InFlightEmails: ").Append(InFlightEmails).Append("\n");
      sb.Append("  CompletionEmails: ").Append(CompletionEmails).Append("\n");
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
