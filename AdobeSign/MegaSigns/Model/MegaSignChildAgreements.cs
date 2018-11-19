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
  public class MegaSignChildAgreements {
    /// <summary>
    /// Pagination information for navigating through the response
    /// </summary>
    /// <value>Pagination information for navigating through the response</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public PageInfo Page { get; set; }

    /// <summary>
    /// A array of MegaSign child agreements
    /// </summary>
    /// <value>A array of MegaSign child agreements</value>
    [DataMember(Name="megaSignChildAgreementList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "megaSignChildAgreementList")]
    public List<MegaSignChildAgreement> MegaSignChildAgreementList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignChildAgreements {\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  MegaSignChildAgreementList: ").Append(MegaSignChildAgreementList).Append("\n");
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
