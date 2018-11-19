using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Users.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DetailedUserInfo {
    /// <summary>
    /// The first name of the user
    /// </summary>
    /// <value>The first name of the user</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The last name of the user
    /// </summary>
    /// <value>The last name of the user</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// True if the user is account admin
    /// </summary>
    /// <value>True if the user is account admin</value>
    [DataMember(Name="isAccountAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAccountAdmin")]
    public bool? IsAccountAdmin { get; set; }

    /// <summary>
    /// The phone number of the user
    /// </summary>
    /// <value>The phone number of the user</value>
    [DataMember(Name="phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// The initials of the user
    /// </summary>
    /// <value>The initials of the user</value>
    [DataMember(Name="initials", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initials")]
    public string Initials { get; set; }

    /// <summary>
    /// Type of account to which the user belongs (null if no account)
    /// </summary>
    /// <value>Type of account to which the user belongs (null if no account)</value>
    [DataMember(Name="accountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// The name of company of the user
    /// </summary>
    /// <value>The name of company of the user</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// A unique identifier of the user resource for REST APIs as issued by Sign.
    /// </summary>
    /// <value>A unique identifier of the user resource for REST APIs as issued by Sign.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The UI locale of the user
    /// </summary>
    /// <value>The UI locale of the user</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// The job title of the user
    /// </summary>
    /// <value>The job title of the user</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// The email address of the user
    /// </summary>
    /// <value>The email address of the user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Status of the user
    /// </summary>
    /// <value>Status of the user</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedUserInfo {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  IsAccountAdmin: ").Append(IsAccountAdmin).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
      sb.Append("  Initials: ").Append(Initials).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
