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
  public class UserWidget {
    /// <summary>
    /// True if agreement is hidden for the user
    /// </summary>
    /// <value>True if agreement is hidden for the user</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// The date on which the widget was last modified. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>The date on which the widget was last modified. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="modifiedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedDate")]
    public DateTime? ModifiedDate { get; set; }

    /// <summary>
    /// The name of the widget.
    /// </summary>
    /// <value>The name of the widget.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier of a widget
    /// </summary>
    /// <value>The unique identifier of a widget</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The embedded javascript code of the widget
    /// </summary>
    /// <value>The embedded javascript code of the widget</value>
    [DataMember(Name="javascript", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "javascript")]
    public string Javascript { get; set; }

    /// <summary>
    /// The hosted url of the widget
    /// </summary>
    /// <value>The hosted url of the widget</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// The widget status (AUTHORING, ACTIVE, DRAFT, DISABLED)
    /// </summary>
    /// <value>The widget status (AUTHORING, ACTIVE, DRAFT, DISABLED)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWidget {\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Javascript: ").Append(Javascript).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
