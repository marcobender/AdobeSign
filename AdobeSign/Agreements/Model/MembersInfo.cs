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
  public class MembersInfo {
    /// <summary>
    /// Information about the participant Sets.
    /// </summary>
    /// <value>Information about the participant Sets.</value>
    [DataMember(Name="participantSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantSets")]
    public List<DetailedParticipantSetInfo> ParticipantSets { get; set; }

    /// <summary>
    /// Information of CC participants of the agreement.
    /// </summary>
    /// <value>Information of CC participants of the agreement.</value>
    [DataMember(Name="ccsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ccsInfo")]
    public List<CCParticipantInfo> CcsInfo { get; set; }

    /// <summary>
    /// Information of next participant sets.
    /// </summary>
    /// <value>Information of next participant sets.</value>
    [DataMember(Name="nextParticipantSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextParticipantSets")]
    public List<DetailedParticipantSetInfo> NextParticipantSets { get; set; }

    /// <summary>
    /// Information of the sender of the agreement.
    /// </summary>
    /// <value>Information of the sender of the agreement.</value>
    [DataMember(Name="senderInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "senderInfo")]
    public SenderInfo SenderInfo { get; set; }

    /// <summary>
    /// Information of the participants with whom the agreement has been shared.
    /// </summary>
    /// <value>Information of the participants with whom the agreement has been shared.</value>
    [DataMember(Name="sharesInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharesInfo")]
    public List<ShareParticipantInfo> SharesInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MembersInfo {\n");
      sb.Append("  ParticipantSets: ").Append(ParticipantSets).Append("\n");
      sb.Append("  CcsInfo: ").Append(CcsInfo).Append("\n");
      sb.Append("  NextParticipantSets: ").Append(NextParticipantSets).Append("\n");
      sb.Append("  SenderInfo: ").Append(SenderInfo).Append("\n");
      sb.Append("  SharesInfo: ").Append(SharesInfo).Append("\n");
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
