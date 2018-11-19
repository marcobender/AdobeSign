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
  public class AgreementView {
    /// <summary>
    /// True if this view is the current view
    /// </summary>
    /// <value>True if this view is the current view</value>
    [DataMember(Name="isCurrent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isCurrent")]
    public bool? IsCurrent { get; set; }

    /// <summary>
    /// Embedded code of url of resource 
    /// </summary>
    /// <value>Embedded code of url of resource </value>
    [DataMember(Name="embeddedCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "embeddedCode")]
    public string EmbeddedCode { get; set; }

    /// <summary>
    /// Name of the requested agreement view
    /// </summary>
    /// <value>Name of the requested agreement view</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Expiration of user url 
    /// </summary>
    /// <value>Expiration of user url </value>
    [DataMember(Name="expiration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiration")]
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// Url of resource location
    /// </summary>
    /// <value>Url of resource location</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementView {\n");
      sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
      sb.Append("  EmbeddedCode: ").Append(EmbeddedCode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Expiration: ").Append(Expiration).Append("\n");
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
