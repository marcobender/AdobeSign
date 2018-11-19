using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Widgets.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class WidgetMembersInfo {
    /// <summary>
    /// Information of CC participants of the widget.
    /// </summary>
    /// <value>Information of CC participants of the widget.</value>
    [DataMember(Name="ccsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ccsInfo")]
    public List<CCParticipantInfo> CcsInfo { get; set; }

    /// <summary>
    /// Information about the widget additional participant Sets
    /// </summary>
    /// <value>Information about the widget additional participant Sets</value>
    [DataMember(Name="additionalParticipantSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalParticipantSets")]
    public List<DetailedWidgetParticipantSetInfo> AdditionalParticipantSets { get; set; }

    /// <summary>
    /// Information about the widget participant Set
    /// </summary>
    /// <value>Information about the widget participant Set</value>
    [DataMember(Name="widgetParticipantSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetParticipantSet")]
    public DetailedWidgetParticipantSetInfo WidgetParticipantSet { get; set; }

    /// <summary>
    /// Information of the participants with whom the widget has been shared.
    /// </summary>
    /// <value>Information of the participants with whom the widget has been shared.</value>
    [DataMember(Name="sharesInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharesInfo")]
    public List<ShareParticipantInfo> SharesInfo { get; set; }

    /// <summary>
    /// Information of the creator of the widget.
    /// </summary>
    /// <value>Information of the creator of the widget.</value>
    [DataMember(Name="creatorInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creatorInfo")]
    public SenderInfo CreatorInfo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetMembersInfo {\n");
      sb.Append("  CcsInfo: ").Append(CcsInfo).Append("\n");
      sb.Append("  AdditionalParticipantSets: ").Append(AdditionalParticipantSets).Append("\n");
      sb.Append("  WidgetParticipantSet: ").Append(WidgetParticipantSet).Append("\n");
      sb.Append("  SharesInfo: ").Append(SharesInfo).Append("\n");
      sb.Append("  CreatorInfo: ").Append(CreatorInfo).Append("\n");
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
