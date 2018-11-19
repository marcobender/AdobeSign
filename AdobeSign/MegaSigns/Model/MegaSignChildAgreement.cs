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
  public class MegaSignChildAgreement {
    /// <summary>
    /// The display date for the agreement. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The display date for the agreement. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="displayDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayDate")]
    public DateTime? DisplayDate { get; set; }

    /// <summary>
    /// True if this is an e-sign document
    /// </summary>
    /// <value>True if this is an e-sign document</value>
    [DataMember(Name="esign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "esign")]
    public bool? Esign { get; set; }

    /// <summary>
    /// Name of the Agreement
    /// </summary>
    /// <value>Name of the Agreement</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier of the agreement.If provided in POST, it will simply be ignored
    /// </summary>
    /// <value>The unique identifier of the agreement.If provided in POST, it will simply be ignored</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// This is a server generated attribute which provides the detailed status of an agreement with respect to the apiCaller
    /// </summary>
    /// <value>This is a server generated attribute which provides the detailed status of an agreement with respect to the apiCaller</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignChildAgreement {\n");
      sb.Append("  DisplayDate: ").Append(DisplayDate).Append("\n");
      sb.Append("  Esign: ").Append(Esign).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
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
