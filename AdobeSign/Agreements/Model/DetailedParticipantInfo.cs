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
  public class DetailedParticipantInfo {
    /// <summary>
    /// The name of the participant, if available. This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>The name of the participant, if available. This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// True if this participant is the same user that is calling the API. Returned as part of Get. Ignored (not required) if modifying a participant set (PUT).
    /// </summary>
    /// <value>True if this participant is the same user that is calling the API. Returned as part of Get. Ignored (not required) if modifying a participant set (PUT).</value>
    [DataMember(Name="self", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "self")]
    public bool? Self { get; set; }

    /// <summary>
    /// The company of the participant, if available. This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>The company of the participant, if available. This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// The unique identifier of the participant. This will be returned as part of Get call but is not mandatory to be passed as part of PUT call for agreements/{id}/members/participantSets/{id}.
    /// </summary>
    /// <value>The unique identifier of the participant. This will be returned as part of Get call but is not mandatory to be passed as part of PUT call for agreements/{id}/members/participantSets/{id}.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Fax of the participant. New Agreements can not be created with fax option. This is only returned for legacy agreements created with fax as participants
    /// </summary>
    /// <value>Fax of the participant. New Agreements can not be created with fax option. This is only returned for legacy agreements created with fax as participants</value>
    [DataMember(Name="fax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fax")]
    public string Fax { get; set; }

    /// <summary>
    /// The private message of the participant, if available. This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>The private message of the participant, if available. This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="privateMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "privateMessage")]
    public string PrivateMessage { get; set; }

    /// <summary>
    /// Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input
    /// </summary>
    /// <value>Email of the participant. In case of modifying a participant set (PUT) this is a required field. In case of GET, this is the required field and will always be returned unless it is a fax workflow (legacy agreements) that were created using fax as input</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Security options that apply to the participant. This cannot be changed as part of the PUT call
    /// </summary>
    /// <value>Security options that apply to the participant. This cannot be changed as part of the PUT call</value>
    [DataMember(Name="securityOption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "securityOption")]
    public ParticipantSecurityOption SecurityOption { get; set; }

    /// <summary>
    /// The status of the participant. This cannot be changed as part of the PUT call.
    /// </summary>
    /// <value>The status of the participant. This cannot be changed as part of the PUT call.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedParticipantInfo {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Self: ").Append(Self).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Fax: ").Append(Fax).Append("\n");
      sb.Append("  PrivateMessage: ").Append(PrivateMessage).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  SecurityOption: ").Append(SecurityOption).Append("\n");
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
