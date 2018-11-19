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
  public class WebhookConditionalParams {
    /// <summary>
    /// Conditional parameters for webhook widget events
    /// </summary>
    /// <value>Conditional parameters for webhook widget events</value>
    [DataMember(Name="webhookWidgetEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookWidgetEvents")]
    public WebhookWidgetEvents WebhookWidgetEvents { get; set; }

    /// <summary>
    /// Conditional parameters for webhook megasign events
    /// </summary>
    /// <value>Conditional parameters for webhook megasign events</value>
    [DataMember(Name="webhookMegaSignEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookMegaSignEvents")]
    public WebhookMegaSignEvents WebhookMegaSignEvents { get; set; }

    /// <summary>
    /// Conditional parameters for webhook library document events
    /// </summary>
    /// <value>Conditional parameters for webhook library document events</value>
    [DataMember(Name="webhookLibraryDocumentEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookLibraryDocumentEvents")]
    public WebhookLibraryDocumentEvents WebhookLibraryDocumentEvents { get; set; }

    /// <summary>
    /// Conditional parameters for webhook agreement events
    /// </summary>
    /// <value>Conditional parameters for webhook agreement events</value>
    [DataMember(Name="webhookAgreementEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookAgreementEvents")]
    public WebhookAgreementEvents WebhookAgreementEvents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhookConditionalParams {\n");
      sb.Append("  WebhookWidgetEvents: ").Append(WebhookWidgetEvents).Append("\n");
      sb.Append("  WebhookMegaSignEvents: ").Append(WebhookMegaSignEvents).Append("\n");
      sb.Append("  WebhookLibraryDocumentEvents: ").Append(WebhookLibraryDocumentEvents).Append("\n");
      sb.Append("  WebhookAgreementEvents: ").Append(WebhookAgreementEvents).Append("\n");
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
