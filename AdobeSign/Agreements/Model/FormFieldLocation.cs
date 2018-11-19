using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Agreements.Model {

  /// <summary>
  /// Location information for form fields
  /// </summary>
  [DataContract]
  public class FormFieldLocation {
    /// <summary>
    /// Number of the page where form field has to be placed, starting from 1.
    /// </summary>
    /// <value>Number of the page where form field has to be placed, starting from 1.</value>
    [DataMember(Name="pageNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageNumber")]
    public int? PageNumber { get; set; }

    /// <summary>
    /// No. of pixels from bottom of the page for form field placement
    /// </summary>
    /// <value>No. of pixels from bottom of the page for form field placement</value>
    [DataMember(Name="top", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "top")]
    public double? Top { get; set; }

    /// <summary>
    /// No. of pixels from left of the page for form field placement
    /// </summary>
    /// <value>No. of pixels from left of the page for form field placement</value>
    [DataMember(Name="left", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "left")]
    public double? Left { get; set; }

    /// <summary>
    /// Width of the form field in pixels
    /// </summary>
    /// <value>Width of the form field in pixels</value>
    [DataMember(Name="width", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "width")]
    public double? Width { get; set; }

    /// <summary>
    /// Height of the form field in pixels
    /// </summary>
    /// <value>Height of the form field in pixels</value>
    [DataMember(Name="height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "height")]
    public double? Height { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FormFieldLocation {\n");
      sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
      sb.Append("  Top: ").Append(Top).Append("\n");
      sb.Append("  Left: ").Append(Left).Append("\n");
      sb.Append("  Width: ").Append(Width).Append("\n");
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
