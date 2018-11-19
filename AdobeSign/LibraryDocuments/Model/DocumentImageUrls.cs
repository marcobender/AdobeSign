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
  public class DocumentImageUrls {
    /// <summary>
    /// A list of image url (one per page).
    /// </summary>
    /// <value>A list of image url (one per page).</value>
    [DataMember(Name="imageURLs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageURLs")]
    public List<PageImageUrl> ImageURLs { get; set; }

    /// <summary>
    /// true if images for the associated image size is available, else false.
    /// </summary>
    /// <value>true if images for the associated image size is available, else false.</value>
    [DataMember(Name="imagesAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imagesAvailable")]
    public bool? ImagesAvailable { get; set; }

    /// <summary>
    /// ImageSize corresponding to the imageUrl returned 
    /// </summary>
    /// <value>ImageSize corresponding to the imageUrl returned </value>
    [DataMember(Name="imageSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageSize")]
    public string ImageSize { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentImageUrls {\n");
      sb.Append("  ImageURLs: ").Append(ImageURLs).Append("\n");
      sb.Append("  ImagesAvailable: ").Append(ImagesAvailable).Append("\n");
      sb.Append("  ImageSize: ").Append(ImageSize).Append("\n");
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
