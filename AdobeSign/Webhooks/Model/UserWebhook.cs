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
  public class UserWebhook {
    /// <summary>
    /// Id of the resource type for which you want to create webhook. Provide agreementId if webhook needs to be created for an agreement. Similarly, widgetId if webhook needs to be created for a widget, megaSignId if webhook needs to be created for a megaSign and libraryDocumentId if webhook needs to be created for a library document. Need to specify only if scope is 'RESOURCE'. Can't be modified in PUT request
    /// </summary>
    /// <value>Id of the resource type for which you want to create webhook. Provide agreementId if webhook needs to be created for an agreement. Similarly, widgetId if webhook needs to be created for a widget, megaSignId if webhook needs to be created for a megaSign and libraryDocumentId if webhook needs to be created for a library document. Need to specify only if scope is 'RESOURCE'. Can't be modified in PUT request</value>
    [DataMember(Name="resourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceId")]
    public string ResourceId { get; set; }

    /// <summary>
    /// Info of webhook url
    /// </summary>
    /// <value>Info of webhook url</value>
    [DataMember(Name="webhookUrlInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookUrlInfo")]
    public WebhookUrlInfo WebhookUrlInfo { get; set; }

    /// <summary>
    /// Determines events for which the webhook is triggered. The possible values are <br> AGREEMENT_CREATED : When an agreement is created <br>, AGREEMENT_ACTION_DELEGATED : When an agreement is delegated <br>, AGREEMENT_RECALLED : When an agreement is recalled <br>, AGREEMENT_REJECTED : When an agreement is rejected <br>, AGREEMENT_EXPIRED : When an agreement expires <br>, AGREEMENT_ACTION_COMPLETED : When an agreement action is completed <br>, AGREEMENT_WORKFLOW_COMPLETED : When an agreement workflow is completed <br>, AGREEMENT_EMAIL_VIEWED : When an agreement's email is viewed <br>, AGREEMENT_MODIFIED : When an agreement is modified <br>, AGREEMENT_SHARED : When an agreement is shared <br>, AGREEMENT_VAULTED : When an agreement is vaulted <br>, AGREEMENT_ACTION_REQUESTED : When an agreement action is requested <br>, AGREEMENT_ACTION_REPLACED_SIGNER : When signer is replaced for an agreement <br>, AGREEMENT_AUTO_CANCELLED_CONVERSION_PROBLEM : When an agreement is auto-cancelled due to conversion problem <br>, AGREEMENT_DOCUMENTS_DELETED : When an agreement documents are deleted <br>, AGREEMENT_EMAIL_BOUNCED : When an agreement email gets bounced <br>, AGREEMENT_KBA_AUTHENTICATED : When an agreement KBA is authenticated <br>, AGREEMENT_OFFLINE_SYNC : When an agreement is synced offline <br>, AGREEMENT_USER_ACK_AGREEMENT_MODIFIED : User Acknowledgement when an agreement is modified <br>, AGREEMENT_UPLOADED_BY_SENDER : When an agreement is uploaded by sender <br>, AGREEMENT_WEB_IDENTITY_AUTHENTICATED : When an agreement web identity is authenticated <br>, AGREEMENT_ALL : All the supported agreement events for Webhooks <br>, MEGASIGN_CREATED : When a megaSign is created <br>, MEGASIGN_RECALLED : When a megaSign is recalled <br>, MEGASIGN_SHARED : When a megaSign is shared <br>, MEGASIGN_ALL : All the supported megaSign events for Webhooks <br>, WIDGET_CREATED : When a widget is created <br>, WIDGET_MODIFIED : When a widget is modified <br>, WIDGET_SHARED : When a widget is shared <br>, WIDGET_ENABLED : When a widget is enabled <br>, WIDGET_DISABLED : When a widget is disabled <br>, WIDGET_AUTO_CANCELLED_CONVERSION_PROBLEM : When a widget is auto-cancelled due to conversion problem <br>, WIDGET_ALL : All the supported widget events for Webhooks <br>, LIBRARY_DOCUMENT_CREATED : When a library document  is created <br>, LIBRARY_DOCUMENT_AUTO_CANCELLED_CONVERSION_PROBLEM : When a library document is auto-cancelled due to conversion problem <br>, LIBRARY_DOCUMENT_MODIFIED : When a library document is modified <br>, LIBRARY_DOCUMENT_ALL : All the supported library document  events for Webhooks
    /// </summary>
    /// <value>Determines events for which the webhook is triggered. The possible values are <br> AGREEMENT_CREATED : When an agreement is created <br>, AGREEMENT_ACTION_DELEGATED : When an agreement is delegated <br>, AGREEMENT_RECALLED : When an agreement is recalled <br>, AGREEMENT_REJECTED : When an agreement is rejected <br>, AGREEMENT_EXPIRED : When an agreement expires <br>, AGREEMENT_ACTION_COMPLETED : When an agreement action is completed <br>, AGREEMENT_WORKFLOW_COMPLETED : When an agreement workflow is completed <br>, AGREEMENT_EMAIL_VIEWED : When an agreement's email is viewed <br>, AGREEMENT_MODIFIED : When an agreement is modified <br>, AGREEMENT_SHARED : When an agreement is shared <br>, AGREEMENT_VAULTED : When an agreement is vaulted <br>, AGREEMENT_ACTION_REQUESTED : When an agreement action is requested <br>, AGREEMENT_ACTION_REPLACED_SIGNER : When signer is replaced for an agreement <br>, AGREEMENT_AUTO_CANCELLED_CONVERSION_PROBLEM : When an agreement is auto-cancelled due to conversion problem <br>, AGREEMENT_DOCUMENTS_DELETED : When an agreement documents are deleted <br>, AGREEMENT_EMAIL_BOUNCED : When an agreement email gets bounced <br>, AGREEMENT_KBA_AUTHENTICATED : When an agreement KBA is authenticated <br>, AGREEMENT_OFFLINE_SYNC : When an agreement is synced offline <br>, AGREEMENT_USER_ACK_AGREEMENT_MODIFIED : User Acknowledgement when an agreement is modified <br>, AGREEMENT_UPLOADED_BY_SENDER : When an agreement is uploaded by sender <br>, AGREEMENT_WEB_IDENTITY_AUTHENTICATED : When an agreement web identity is authenticated <br>, AGREEMENT_ALL : All the supported agreement events for Webhooks <br>, MEGASIGN_CREATED : When a megaSign is created <br>, MEGASIGN_RECALLED : When a megaSign is recalled <br>, MEGASIGN_SHARED : When a megaSign is shared <br>, MEGASIGN_ALL : All the supported megaSign events for Webhooks <br>, WIDGET_CREATED : When a widget is created <br>, WIDGET_MODIFIED : When a widget is modified <br>, WIDGET_SHARED : When a widget is shared <br>, WIDGET_ENABLED : When a widget is enabled <br>, WIDGET_DISABLED : When a widget is disabled <br>, WIDGET_AUTO_CANCELLED_CONVERSION_PROBLEM : When a widget is auto-cancelled due to conversion problem <br>, WIDGET_ALL : All the supported widget events for Webhooks <br>, LIBRARY_DOCUMENT_CREATED : When a library document  is created <br>, LIBRARY_DOCUMENT_AUTO_CANCELLED_CONVERSION_PROBLEM : When a library document is auto-cancelled due to conversion problem <br>, LIBRARY_DOCUMENT_MODIFIED : When a library document is modified <br>, LIBRARY_DOCUMENT_ALL : All the supported library document  events for Webhooks</value>
    [DataMember(Name="webhookSubscriptionEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "webhookSubscriptionEvents")]
    public List<string> WebhookSubscriptionEvents { get; set; }

    /// <summary>
    /// Scope of webhook. Can't be modified in PUT request. The possible values are ACCOUNT, GROUP, USER or RESOURCE
    /// </summary>
    /// <value>Scope of webhook. Can't be modified in PUT request. The possible values are ACCOUNT, GROUP, USER or RESOURCE</value>
    [DataMember(Name="scope", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scope")]
    public string Scope { get; set; }

    /// <summary>
    /// The name of the webhook
    /// </summary>
    /// <value>The name of the webhook</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The unique identifier of the webhook. Will only be returned in GET request. Can't be modified in PUT request
    /// </summary>
    /// <value>The unique identifier of the webhook. Will only be returned in GET request. Can't be modified in PUT request</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Timestamp when the webhook was last updated. Will only be returned in GET request. Can't be modified in PUT request
    /// </summary>
    /// <value>Timestamp when the webhook was last updated. Will only be returned in GET request. Can't be modified in PUT request</value>
    [DataMember(Name="lastModified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModified")]
    public DateTime? LastModified { get; set; }

    /// <summary>
    /// The display name of the application through which webhook is created
    /// </summary>
    /// <value>The display name of the application through which webhook is created</value>
    [DataMember(Name="applicationDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationDisplayName")]
    public string ApplicationDisplayName { get; set; }

    /// <summary>
    /// The name of the application through which webhook is created
    /// </summary>
    /// <value>The name of the application through which webhook is created</value>
    [DataMember(Name="applicationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationName")]
    public string ApplicationName { get; set; }

    /// <summary>
    /// The resource for which you want to create webhook. Need to specify only if scope is 'RESOURCE'. Can't be modified in PUT request. The possible values are AGREEMENT, WIDGET,  MEGASIGN AND LIBRARY_DOCUMENT
    /// </summary>
    /// <value>The resource for which you want to create webhook. Need to specify only if scope is 'RESOURCE'. Can't be modified in PUT request. The possible values are AGREEMENT, WIDGET,  MEGASIGN AND LIBRARY_DOCUMENT</value>
    [DataMember(Name="resourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resourceType")]
    public string ResourceType { get; set; }

    /// <summary>
    /// Status of the webhook. Determines whether the webhook will be actually triggered. Default: ACTIVE, if ACTIVE, this webhook will receive event requests. If INACTIVE, this webhook will not receive event requests. Can't provide status in POST/PUT requests.
    /// </summary>
    /// <value>Status of the webhook. Determines whether the webhook will be actually triggered. Default: ACTIVE, if ACTIVE, this webhook will receive event requests. If INACTIVE, this webhook will not receive event requests. Can't provide status in POST/PUT requests.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserWebhook {\n");
      sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
      sb.Append("  WebhookUrlInfo: ").Append(WebhookUrlInfo).Append("\n");
      sb.Append("  WebhookSubscriptionEvents: ").Append(WebhookSubscriptionEvents).Append("\n");
      sb.Append("  Scope: ").Append(Scope).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastModified: ").Append(LastModified).Append("\n");
      sb.Append("  ApplicationDisplayName: ").Append(ApplicationDisplayName).Append("\n");
      sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
      sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
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
