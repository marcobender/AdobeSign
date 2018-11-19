using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.MegaSigns.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MegaSignSecurityOption {
    /// <summary>
    /// The authentication method for the participants to have access to view and sign the document.
    /// </summary>
    /// <value>The authentication method for the participants to have access to view and sign the document.</value>
    [DataMember(Name="externalAuthenticationMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalAuthenticationMethod")]
    public string ExternalAuthenticationMethod { get; set; }

    /// <summary>
    /// The authentication method for the participants to have access to view and sign the document.
    /// </summary>
    /// <value>The authentication method for the participants to have access to view and sign the document.</value>
    [DataMember(Name="internalAuthenticationMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalAuthenticationMethod")]
    public string InternalAuthenticationMethod { get; set; }

    /// <summary>
    /// The secondary password that will be used to protect signing the document for internal signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for internal signers or all signers
    /// </summary>
    /// <value>The secondary password that will be used to protect signing the document for internal signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for internal signers or all signers</value>
    [DataMember(Name="externalPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalPassword")]
    public string ExternalPassword { get; set; }

    /// <summary>
    /// The secondary password that will be used to protect signing the document for external signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for external signers or all signers
    /// </summary>
    /// <value>The secondary password that will be used to protect signing the document for external signers. Note that Adobe Sign will never show this password to anyone, so you will need to separately communicate it to any relevant parties. This password is applied only if password protection is specified for external signers or all signers</value>
    [DataMember(Name="internalPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "internalPassword")]
    public string InternalPassword { get; set; }

    /// <summary>
    /// The secondary password that will be used to secure the PDF document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties
    /// </summary>
    /// <value>The secondary password that will be used to secure the PDF document. Note that AdobeSign will never show this password to anyone, so you will need to separately communicate it to any relevant parties</value>
    [DataMember(Name="openPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openPassword")]
    public string OpenPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignSecurityOption {\n");
      sb.Append("  ExternalAuthenticationMethod: ").Append(ExternalAuthenticationMethod).Append("\n");
      sb.Append("  InternalAuthenticationMethod: ").Append(InternalAuthenticationMethod).Append("\n");
      sb.Append("  ExternalPassword: ").Append(ExternalPassword).Append("\n");
      sb.Append("  InternalPassword: ").Append(InternalPassword).Append("\n");
      sb.Append("  OpenPassword: ").Append(OpenPassword).Append("\n");
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
