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
  public class LibraryDocumentInfo {
    /// <summary>
    /// Date when library document was created. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>Date when library document was created. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// A list of one or more library template types
    /// </summary>
    /// <value>A list of one or more library template types</value>
    [DataMember(Name="templateTypes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "templateTypes")]
    public List<string> TemplateTypes { get; set; }

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
    /// The name of the library template that will be used to identify it, in emails and on the website
    /// </summary>
    /// <value>The name of the library template that will be used to identify it, in emails and on the website</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified
    /// </summary>
    /// <value>A list of one or more files (or references to files) that will be used to create the template. If more than one file is provided, they will be combined into one PDF. Note: Only a single parameter in every FileInfo object must be specified</value>
    [DataMember(Name="fileInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileInfos")]
    public List<FileInfo> FileInfos { get; set; }

    /// <summary>
    /// The unique identifier that is used to refer to the library template. It will be ignored in POST call
    /// </summary>
    /// <value>The unique identifier that is used to refer to the library template. It will be ignored in POST call</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// State of the library document.
    /// </summary>
    /// <value>State of the library document.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

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
      sb.Append("class LibraryDocumentInfo {\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  TemplateTypes: ").Append(TemplateTypes).Append("\n");
      sb.Append("  CreatorEmail: ").Append(CreatorEmail).Append("\n");
      sb.Append("  SharingMode: ").Append(SharingMode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
