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
  public class MegaSignChildAgreementsFileInfo {
    /// <summary>
    /// Transient id of the input file which contains participantSetsInfos. Currently only csv format is suppported. More details about CSV format <a href='https://www.adobe.com/go/documentcloud_megasigncsv'>here</a>  
    /// </summary>
    /// <value>Transient id of the input file which contains participantSetsInfos. Currently only csv format is suppported. More details about CSV format <a href='https://www.adobe.com/go/documentcloud_megasigncsv'>here</a>  </value>
    [DataMember(Name="transientDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transientDocumentId")]
    public string TransientDocumentId { get; set; }

    /// <summary>
    /// Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients.
    /// </summary>
    /// <value>Input type through which participantSetsInfos will be provided. Whichever input type is provided, the values should be provided in its corresponding value object. Currently we are supporting CSV file format for providing megaSIgn child recipients.</value>
    [DataMember(Name="fileType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileType")]
    public string FileType { get; set; }

    /// <summary>
    /// id of the file containg information about the existing childAgreementsInfo associated with the megaSign. Will be ignored in POST call and in case of GET call, this is the only thing that will be returned. The content of the file can be fetched through GET /megaSigns/{megaSignId}/childAgreementsInfo/{childAgreementsInfoFileId} endpoint.
    /// </summary>
    /// <value>id of the file containg information about the existing childAgreementsInfo associated with the megaSign. Will be ignored in POST call and in case of GET call, this is the only thing that will be returned. The content of the file can be fetched through GET /megaSigns/{megaSignId}/childAgreementsInfo/{childAgreementsInfoFileId} endpoint.</value>
    [DataMember(Name="childAgreementsInfoFileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childAgreementsInfoFileId")]
    public string ChildAgreementsInfoFileId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignChildAgreementsFileInfo {\n");
      sb.Append("  TransientDocumentId: ").Append(TransientDocumentId).Append("\n");
      sb.Append("  FileType: ").Append(FileType).Append("\n");
      sb.Append("  ChildAgreementsInfoFileId: ").Append(ChildAgreementsInfoFileId).Append("\n");
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
