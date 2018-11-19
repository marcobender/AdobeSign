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
  public class Document {
    /// <summary>
    /// Number of pages in the document
    /// </summary>
    /// <value>Number of pages in the document</value>
    [DataMember(Name="numPages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numPages")]
    public int? NumPages { get; set; }

    /// <summary>
    /// Name of the original document uploaded. This is returned in GET but not accepted back in PUT
    /// </summary>
    /// <value>Name of the original document uploaded. This is returned in GET but not accepted back in PUT</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// ID of the document. In case of PUT call, this is the only field that is accepted in Document structure. Name and mimeType are ignored in case of PUT call
    /// </summary>
    /// <value>ID of the document. In case of PUT call, this is the only field that is accepted in Document structure. Name and mimeType are ignored in case of PUT call</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Label of the document
    /// </summary>
    /// <value>Label of the document</value>
    [DataMember(Name="label", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "label")]
    public string Label { get; set; }

    /// <summary>
    /// mimeType of the original file. This is returned in GET but not accepted back in PUT
    /// </summary>
    /// <value>mimeType of the original file. This is returned in GET but not accepted back in PUT</value>
    [DataMember(Name="mimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Document {\n");
      sb.Append("  NumPages: ").Append(NumPages).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Label: ").Append(Label).Append("\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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
