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
  public class WidgetInfo {
    /// <summary>
    /// List of all the participants in the widget except widget signer
    /// </summary>
    /// <value>List of all the participants in the widget except widget signer</value>
    [DataMember(Name="additionalParticipantSetsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalParticipantSetsInfo")]
    public List<WidgetAdditionalParticipationSetInfo> AdditionalParticipantSetsInfo { get; set; }

    /// <summary>
    /// Email of widget creator. Only returned in GET response. Cannot be provided in POST/PUT request. If provided in POST, it will simply be ignored
    /// </summary>
    /// <value>Email of widget creator. Only returned in GET response. Cannot be provided in POST/PUT request. If provided in POST, it will simply be ignored</value>
    [DataMember(Name="creatorEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creatorEmail")]
    public string CreatorEmail { get; set; }

    /// <summary>
    /// The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the widget creator
    /// </summary>
    /// <value>The locale associated with this widget - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the widget creator</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Vaulting properties that allows Adobe Sign to securely store documents with a vault provider
    /// </summary>
    /// <value>Vaulting properties that allows Adobe Sign to securely store documents with a vault provider</value>
    [DataMember(Name="vaultingInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vaultingInfo")]
    public VaultingInfo VaultingInfo { get; set; }

    /// <summary>
    /// Secondary security parameters for the widget
    /// </summary>
    /// <value>Secondary security parameters for the widget</value>
    [DataMember(Name="securityOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOption")]
    public SecurityOption SecurityOption { get; set; }

    /// <summary>
    /// Represents widget participant for whom email should not be provided
    /// </summary>
    /// <value>Represents widget participant for whom email should not be provided</value>
    [DataMember(Name="widgetParticipantSetInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "widgetParticipantSetInfo")]
    public WidgetParticipantSetInfo WidgetParticipantSetInfo { get; set; }

    /// <summary>
    /// A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file
    /// </summary>
    /// <value>A list of one or more email addresses that you want to copy on this transaction. The email addresses will each receive an email when the final agreement created through widget is signed. The email addresses will also receive a copy of the document, attached as a PDF file</value>
    [DataMember(Name="ccs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ccs")]
    public List<WidgetCcInfo> Ccs { get; set; }

    /// <summary>
    /// Date when widget was created. If provided in POST, it will simply be ignored. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>Date when widget was created. If provided in POST, it will simply be ignored. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The name of the widget that will be used to identify it, in emails, website and other places
    /// </summary>
    /// <value>The name of the widget that will be used to identify it, in emails, website and other places</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// URL and associated properties for the success page the widget signer will be taken to after performing desired action on the widget
    /// </summary>
    /// <value>URL and associated properties for the success page the widget signer will be taken to after performing desired action on the widget</value>
    [DataMember(Name="completionInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "completionInfo")]
    public WidgetRedirectionInfo CompletionInfo { get; set; }

    /// <summary>
    /// URL and associated properties for the error page the widget signer will be taken after failing to authenticate
    /// </summary>
    /// <value>URL and associated properties for the error page the widget signer will be taken after failing to authenticate</value>
    [DataMember(Name="authFailureInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "authFailureInfo")]
    public WidgetRedirectionInfo AuthFailureInfo { get; set; }

    /// <summary>
    /// A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified
    /// </summary>
    /// <value>A list of one or more files (or references to files) that will be used to create the widget. If more than one file is provided, they will be combined before the widget is created. Library documents are not permitted. Note: Only one of the four parameters in every FileInfo object must be specified</value>
    [DataMember(Name="fileInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileInfos")]
    public List<FileInfo> FileInfos { get; set; }

    /// <summary>
    /// A resource identifier that can be used to uniquely identify the widget in other apis. If provided in POST, it will simply be ignored
    /// </summary>
    /// <value>A resource identifier that can be used to uniquely identify the widget in other apis. If provided in POST, it will simply be ignored</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID
    /// </summary>
    /// <value>The state in which the widget should land. For example in order to create a widget in DRAFT state, field should be DRAFT. The state field will never get returned in GET /widgets/{ID} and will be ignored if provided in PUT /widgets/{ID} call. The eventual status of the widget can be obtained from GET /widgets/ID</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Status of the Widget. If provided in POST, it will simply be ignored
    /// </summary>
    /// <value>Status of the Widget. If provided in POST, it will simply be ignored</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WidgetInfo {\n");
      sb.Append("  AdditionalParticipantSetsInfo: ").Append(AdditionalParticipantSetsInfo).Append("\n");
      sb.Append("  CreatorEmail: ").Append(CreatorEmail).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
      sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
      sb.Append("  WidgetParticipantSetInfo: ").Append(WidgetParticipantSetInfo).Append("\n");
      sb.Append("  Ccs: ").Append(Ccs).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CompletionInfo: ").Append(CompletionInfo).Append("\n");
      sb.Append("  AuthFailureInfo: ").Append(AuthFailureInfo).Append("\n");
      sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
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
