using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserWebhooks {
    /// <summary>
    /// An array of widget items
    /// </summary>
    /// <value>An array of widget items</value>
    [DataMember(Name="userWebhookList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userWebhookList")]
    public List<UserWebhook> UserWebhookList { get; set; }

    /// <summary>
    /// Pagination information for navigating through the response
    /// </summary>
    /// <value>Pagination information for navigating through the response</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public PageInfo Page { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWebhooks {\n");
      sb.Append("  UserWebhookList: ").Append(UserWebhookList).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
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
