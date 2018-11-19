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
  public class ChildAgreementsInfo {
    /// <summary>
    /// File info containing per child agreement information of megaSign.
    /// </summary>
    /// <value>File info containing per child agreement information of megaSign.</value>
    [DataMember(Name="fileInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileInfo")]
    public MegaSignChildAgreementsFileInfo FileInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChildAgreementsInfo {\n");
      sb.Append("  FileInfo: ").Append(FileInfo).Append("\n");
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
