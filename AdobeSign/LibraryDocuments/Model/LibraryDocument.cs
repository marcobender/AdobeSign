using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.LibraryDocuments.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class LibraryDocument {
    /// <summary>
    /// A list of one or more library template types
    /// </summary>
    /// <value>A list of one or more library template types</value>
    [DataMember(Name="templateTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateTypes")]
    public List<string> TemplateTypes { get; set; }

    /// <summary>
    /// True if Library Document is hidden
    /// </summary>
    /// <value>True if Library Document is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Email address of the library document creator. It will be ignored in POST call
    /// </summary>
    /// <value>Email address of the library document creator. It will be ignored in POST call</value>
    [DataMember(Name="creatorEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creatorEmail")]
    public string CreatorEmail { get; set; }

    /// <summary>
    /// Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT calls
    /// </summary>
    /// <value>Specifies who should have access to this library document. GLOBAL sharing mode is not applicable in POST/PUT calls</value>
    [DataMember(Name="sharingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharingMode")]
    public string SharingMode { get; set; }

    /// <summary>
    /// The date on which the library document was last modified. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The date on which the library document was last modified. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The name of the library document
    /// </summary>
    /// <value>The name of the library document</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier that is used to refer to the library template
    /// </summary>
    /// <value>The unique identifier that is used to refer to the library template</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Status of the library document
    /// </summary>
    /// <value>Status of the library document</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LibraryDocument {\n");
      sb.Append("  TemplateTypes: ").Append(TemplateTypes).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  CreatorEmail: ").Append(CreatorEmail).Append("\n");
      sb.Append("  SharingMode: ").Append(SharingMode).Append("\n");
      sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
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
