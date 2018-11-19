using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.MegaSigns.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class MegaSignCreationInfo {
    /// <summary>
    /// Integer which specifies the delay in hours before sending the first reminder.<br>This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.<br>If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.<br>i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT
    /// </summary>
    /// <value>Integer which specifies the delay in hours before sending the first reminder.<br>This is an optional field. The minimum value allowed is 1 hour and the maximum value can’t be more than the difference of agreement creation and expiry time of the agreement in hours.<br>If this is not specified but the reminder frequency is specified, then the first reminder will be sent based on frequency.<br>i.e. if the reminder is created with frequency specified as daily, the firstReminderDelay will be 24 hours. Cannot be updated in a PUT</value>
    [DataMember(Name="firstReminderDelay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstReminderDelay")]
    public int? FirstReminderDelay { get; set; }

    /// <summary>
    /// Info corresponding to each child agreement of the megaSign 
    /// </summary>
    /// <value>Info corresponding to each child agreement of the megaSign </value>
    [DataMember(Name="childAgreementsInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "childAgreementsInfo")]
    public ChildAgreementsInfo ChildAgreementsInfo { get; set; }

    /// <summary>
    /// Specifies the type of signature you would like to request - written or e-signature. The possible values are <br> ESIGN : Agreement needs to be signed electronically <br>, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system
    /// </summary>
    /// <value>Specifies the type of signature you would like to request - written or e-signature. The possible values are <br> ESIGN : Agreement needs to be signed electronically <br>, WRITTEN : Agreement will be signed using handwritten signature and signed document will be uploaded into the system</value>
    [DataMember(Name="signatureType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "signatureType")]
    public string SignatureType { get; set; }

    /// <summary>
    /// An arbitrary value from your system, which can be specified at sending time and then later returned or queried
    /// </summary>
    /// <value>An arbitrary value from your system, which can be specified at sending time and then later returned or queried</value>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public ExternalId ExternalId { get; set; }

    /// <summary>
    /// The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender
    /// </summary>
    /// <value>The locale associated with this agreement - specifies the language for the signing page and emails, for example en_US or fr_FR. If none specified, defaults to the language configured for the agreement sender</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// An optional message to the participants, describing what is being sent or why their signature is required
    /// </summary>
    /// <value>An optional message to the participants, describing what is being sent or why their signature is required</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Vaulting properties that allows Adobe Sign to securely store documents with a vault provider
    /// </summary>
    /// <value>Vaulting properties that allows Adobe Sign to securely store documents with a vault provider</value>
    [DataMember(Name="vaultingInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vaultingInfo")]
    public VaultingInfo VaultingInfo { get; set; }

    /// <summary>
    /// Optional security parameters for the megasign
    /// </summary>
    /// <value>Optional security parameters for the megasign</value>
    [DataMember(Name="securityOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOption")]
    public MegaSignSecurityOption SecurityOption { get; set; }

    /// <summary>
    /// URL and associated properties for the success page the user will be taken to after completing the signing process
    /// </summary>
    /// <value>URL and associated properties for the success page the user will be taken to after completing the signing process</value>
    [DataMember(Name="postSignOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postSignOption")]
    public PostSignOption PostSignOption { get; set; }

    /// <summary>
    /// Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used
    /// </summary>
    /// <value>Optional parameter that sets how often you want to send reminders to the participants. If it is not specified, the default frequency set for the account will be used</value>
    [DataMember(Name="reminderFrequency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reminderFrequency")]
    public string ReminderFrequency { get; set; }

    /// <summary>
    /// A list of one or more CCs that will be copied in the megasign transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file 
    /// </summary>
    /// <value>A list of one or more CCs that will be copied in the megasign transaction. The CCs will each receive an email at the beginning of the transaction and also when the final document is signed. The email addresses will also receive a copy of the document, attached as a PDF file </value>
    [DataMember(Name="ccs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ccs")]
    public List<MegaSignCcInfo> Ccs { get; set; }

    /// <summary>
    /// Date when megasign was created. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time
    /// </summary>
    /// <value>Date when megasign was created. Format would be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time</value>
    [DataMember(Name="createdDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation.
    /// </summary>
    /// <value>Time after which Agreement expires and needs to be signed before it. Format should be yyyy-MM-dd'T'HH:mm:ssZ. For example, e.g 2016-02-25T18:46:19Z represents UTC time. Should not be provided in offline agreement creation.</value>
    [DataMember(Name="expirationTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expirationTime")]
    public DateTime? ExpirationTime { get; set; }

    /// <summary>
    /// Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored
    /// </summary>
    /// <value>Email of agreement sender. Only provided in GET. Can not be provided in POST/PUT request. If provided in POST/PUT, it will be ignored</value>
    [DataMember(Name="senderEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "senderEmail")]
    public string SenderEmail { get; set; }

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
    /// The unique identifier of megasign 
    /// </summary>
    /// <value>The unique identifier of megasign </value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// State of the Megasign
    /// </summary>
    /// <value>State of the Megasign</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Status of the Megasign
    /// </summary>
    /// <value>Status of the Megasign</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MegaSignCreationInfo {\n");
      sb.Append("  FirstReminderDelay: ").Append(FirstReminderDelay).Append("\n");
      sb.Append("  ChildAgreementsInfo: ").Append(ChildAgreementsInfo).Append("\n");
      sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  VaultingInfo: ").Append(VaultingInfo).Append("\n");
      sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
      sb.Append("  PostSignOption: ").Append(PostSignOption).Append("\n");
      sb.Append("  ReminderFrequency: ").Append(ReminderFrequency).Append("\n");
      sb.Append("  Ccs: ").Append(Ccs).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
      sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
