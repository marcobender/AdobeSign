using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// Hyperlink-specific data for hyperlink form fields
  /// </summary>
  [DataContract]
  public class FormFieldHyperlink {
    /// <summary>
    /// Type of link in an agreement.
    /// </summary>
    /// <value>Type of link in an agreement.</value>
    [DataMember(Name="linkType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkType")]
    public string LinkType { get; set; }

    /// <summary>
    /// Location on the document pointed by the link in case of INTERNAL type link
    /// </summary>
    /// <value>Location on the document pointed by the link in case of INTERNAL type link</value>
    [DataMember(Name="documentLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentLocation")]
    public FormFieldLocation DocumentLocation { get; set; }

    /// <summary>
    /// URL, in case of EXTERNAL type link
    /// </summary>
    /// <value>URL, in case of EXTERNAL type link</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldHyperlink {\n");
      sb.Append("  LinkType: ").Append(LinkType).Append("\n");
      sb.Append("  DocumentLocation: ").Append(DocumentLocation).Append("\n");
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
