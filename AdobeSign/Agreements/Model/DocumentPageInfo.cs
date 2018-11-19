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
  public class DocumentPageInfo {
    /// <summary>
    /// Rotation angle of the page in clockwise direction in degree
    /// </summary>
    /// <value>Rotation angle of the page in clockwise direction in degree</value>
    [DataMember(Name="rotation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rotation")]
    public double? Rotation { get; set; }

    /// <summary>
    /// Width of the page
    /// </summary>
    /// <value>Width of the page</value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public double? Width { get; set; }

    /// <summary>
    /// Index of the page in combined document starting from 1
    /// </summary>
    /// <value>Index of the page in combined document starting from 1</value>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int Index { get; set; }

    /// <summary>
    /// Height of the page
    /// </summary>
    /// <value>Height of the page</value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public double? Height { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentPageInfo {\n");
      sb.Append("  Rotation: ").Append(Rotation).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
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
