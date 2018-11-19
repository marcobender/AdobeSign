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
  public class DelegatedParticipantInfo {
    /// <summary>
    /// Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input
    /// </summary>
    /// <value>Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Security options that apply to the participant. This cannot be changed as part of the PUT call
    /// </summary>
    /// <value>Security options that apply to the participant. This cannot be changed as part of the PUT call</value>
    [DataMember(Name="securityOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOption")]
    public DelegatedParticipantSecurityOption SecurityOption { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DelegatedParticipantInfo {\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
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
