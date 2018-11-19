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
  public class ParticipantSecurityOption {
    /// <summary>
    /// The password required for the participant to view and sign the document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. The password will not be returned in GET call. In case of PUT call, password associated with Agreement resource will remain unchanged if no password is specified but authentication method is provided as PASSWORD
    /// </summary>
    /// <value>The password required for the participant to view and sign the document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. The password will not be returned in GET call. In case of PUT call, password associated with Agreement resource will remain unchanged if no password is specified but authentication method is provided as PASSWORD</value>
    [DataMember(Name="password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "password")]
    public string Password { get; set; }

    /// <summary>
    /// The authentication method for the participants to have access to view and sign the document
    /// </summary>
    /// <value>The authentication method for the participants to have access to view and sign the document</value>
    [DataMember(Name="authenticationMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authenticationMethod")]
    public string AuthenticationMethod { get; set; }

    /// <summary>
    /// The phoneInfo required for the participant to view and sign the document
    /// </summary>
    /// <value>The phoneInfo required for the participant to view and sign the document</value>
    [DataMember(Name="phoneInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ParticipantSecurityOption {\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  AuthenticationMethod: ").Append(AuthenticationMethod).Append("\n");
      sb.Append("  PhoneInfo: ").Append(PhoneInfo).Append("\n");
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
