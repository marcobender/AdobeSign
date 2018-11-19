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
  public class AgreementInfo {
    /// <summary>
    /// The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender
    /// </summary>
    /// <value>The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender</value>
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
    /// Optional secondary security parameters for the agreement. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>Optional secondary security parameters for the agreement. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="securityOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOption")]
    public SecurityOption SecurityOption { get; set; }

    /// <summary>
    /// URL and associated properties for the success page the user will be taken to after completing the signing process. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>URL and associated properties for the success page the user will be taken to after completing the signing process. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="postSignOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postSignOption")]
    public PostSignOption PostSignOption { get; set; }

    /// <summary>
    /// A list of one or more CCs that will be copied in the agreement transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>A list of one or more CCs that will be copied in the agreement transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="ccs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ccs")]
    public List<AgreementCcInfo> Ccs { get; set; }

    /// <summary>
    /// If set to true, enable limited document visibility. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>If set to true, enable limited document visibility. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="documentVisibilityEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentVisibilityEnabled")]
    public bool? DocumentVisibilityEnabled { get; set; }

    /// <summary>
    /// Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored
    /// </summary>
    /// <value>Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored</value>
    [DataMember(Name="senderEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "senderEmail")]
    public string SenderEmail { get; set; }

    /// <summary>
    /// The unique identifier of the agreement.If provided in POST, it will simply be ignored
    /// </summary>
    /// <value>The unique identifier of the agreement.If provided in POST, it will simply be ignored</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The state in which the agreement should land. The state field can only be provided in POST calls, will never get returned in GET /agreements/{ID} and will be ignored if provided in PUT /agreements/{ID} call. The eventual status of the agreement can be obtained from GET /agreements/ID
    /// </summary>
    /// <value>The state in which the agreement should land. The state field can only be provided in POST calls, will never get returned in GET /agreements/{ID} and will be ignored if provided in PUT /agreements/{ID} call. The eventual status of the agreement can be obtained from GET /agreements/ID</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Optional default values for fields to merge into the document. The values will be presented to the signers for editable fields; for read-only fields the provided values will not be editable during the signing process. Merging data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and url are currently supported
    /// </summary>
    /// <value>Optional default values for fields to merge into the document. The values will be presented to the signers for editable fields; for read-only fields the provided values will not be editable during the signing process. Merging data into fields is currently not supported when used with libraryDocumentId or libraryDocumentName. Only file and url are currently supported</value>
    [DataMember(Name="mergeFieldInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mergeFieldInfo")]
    public List<MergefieldInfo> MergeFieldInfo { get; set; }

    /// <summary>
    /// Integer which specifies the delay in hours before sending the first reminder.<br>This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.<br>If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.<br>i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>Integer which specifies the delay in hours before sending the first reminder.<br>This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.<br>If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.<br>i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="firstReminderDelay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstReminderDelay")]
    public int? FirstReminderDelay { get; set; }

    /// <summary>
    /// Email configurations for the agreement. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>Email configurations for the agreement. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="emailOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emailOption")]
    public EmailOption EmailOption { get; set; }

    /// <summary>
    /// Specifies the type of signature you would like to request - written or e-signature. The possible values are <br> ESIGN : Agreement needs to be signed electronically <br>, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system
    /// </summary>
    /// <value>Specifies the type of signature you would like to request - written or e-signature. The possible values are <br> ESIGN : Agreement needs to be signed electronically <br>, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system</value>
    [DataMember(Name="signatureType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signatureType")]
    public string SignatureType { get; set; }

    /// <summary>
    /// An arbitrary value from your system, which can be specified at sending time and then later returned or queried. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>An arbitrary value from your system, which can be specified at sending time and then later returned or queried. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public ExternalId ExternalId { get; set; }

    /// <summary>
    /// An optional message to the participants, describing what is being sent or why their signature is required
    /// </summary>
    /// <value>An optional message to the participants, describing what is being sent or why their signature is required</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Device info of the offline device. It should only be provided in case of offline agreement creation.
    /// </summary>
    /// <value>Device info of the offline device. It should only be provided in case of offline agreement creation.</value>
    [DataMember(Name="deviceInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceInfo")]
    public OfflineDeviceInfo DeviceInfo { get; set; }

    /// <summary>
    /// Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used. Should not be provided in offline agreement creation. If provided in PUT as a different value than the current one, an error will be thrown.
    /// </summary>
    /// <value>Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used. Should not be provided in offline agreement creation. If provided in PUT as a different value than the current one, an error will be thrown.</value>
    [DataMember(Name="reminderFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderFrequency")]
    public string ReminderFrequency { get; set; }

    /// <summary>
    /// Date when agreement was created. This is a server generated attributed and can not be provided in POST/PUT calls. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>Date when agreement was created. This is a server generated attributed and can not be provided in POST/PUT calls. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// A list of one or more participant set. A participant set may have one or more participant. If any member of the participant set takes the action that has been assigned to the set(Sign/Approve/Acknowledge etc ), the action is considered as the action taken by whole participation set. For regular (non-MegaSign) documents, there is no limit on the number of electronic signatures in a single document. Written signatures are limited to four per document
    /// </summary>
    /// <value>A list of one or more participant set. A participant set may have one or more participant. If any member of the participant set takes the action that has been assigned to the set(Sign/Approve/Acknowledge etc ), the action is considered as the action taken by whole participation set. For regular (non-MegaSign) documents, there is no limit on the number of electronic signatures in a single document. Written signatures are limited to four per document</value>
    [DataMember(Name="participantSetsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participantSetsInfo")]
    public List<ParticipantSetInfo> ParticipantSetsInfo { get; set; }

    /// <summary>
    /// Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="expirationTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationTime")]
    public DateTime? ExpirationTime { get; set; }

    /// <summary>
    /// Specifies the form field layer template or source of form fields to apply on the files in this transaction. If specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type. Note: Only one of the four parameters in every FileInfo object must be specified
    /// </summary>
    /// <value>Specifies the form field layer template or source of form fields to apply on the files in this transaction. If specified, the FileInfo for this parameter must refer to a form field layer template via libraryDocumentId or libraryDocumentName, or if specified via transientDocumentId or documentURL, it must be of a supported file type. Note: Only one of the four parameters in every FileInfo object must be specified</value>
    [DataMember(Name="formFieldLayerTemplates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formFieldLayerTemplates")]
    public List<FileInfo> FormFieldLayerTemplates { get; set; }

    /// <summary>
    /// The name of the agreement that will be used to identify it, in emails, website and other places
    /// </summary>
    /// <value>The name of the agreement that will be used to identify it, in emails, website and other places</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A list of one or more files (or references to files) that will be sent out for signature. If more than one file is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every FileInfo object must be specified
    /// </summary>
    /// <value>A list of one or more files (or references to files) that will be sent out for signature. If more than one file is provided, they will be combined into one PDF before being sent out. Note: Only one of the four parameters in every FileInfo object must be specified</value>
    [DataMember(Name="fileInfos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileInfos")]
    public List<FileInfo> FileInfos { get; set; }

    /// <summary>
    /// The identifier of custom workflow which defines the routing path of an agreement. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>The identifier of custom workflow which defines the routing path of an agreement. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="workflowId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflowId")]
    public string WorkflowId { get; set; }

    /// <summary>
    /// This is a server generated attribute which provides the detailed status of an agreement.
    /// </summary>
    /// <value>This is a server generated attribute which provides the detailed status of an agreement.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AgreementInfo {\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
      sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
      sb.Append("  PostSignOption: ").Append(PostSignOption).Append("\n");
      sb.Append("  Ccs: ").Append(Ccs).Append("\n");
      sb.Append("  DocumentVisibilityEnabled: ").Append(DocumentVisibilityEnabled).Append("\n");
      sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  MergeFieldInfo: ").Append(MergeFieldInfo).Append("\n");
      sb.Append("  FirstReminderDelay: ").Append(FirstReminderDelay).Append("\n");
      sb.Append("  EmailOption: ").Append(EmailOption).Append("\n");
      sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  DeviceInfo: ").Append(DeviceInfo).Append("\n");
      sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  ParticipantSetsInfo: ").Append(ParticipantSetsInfo).Append("\n");
      sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
      sb.Append("  FormFieldLayerTemplates: ").Append(FormFieldLayerTemplates).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FileInfos: ").Append(FileInfos).Append("\n");
      sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
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
