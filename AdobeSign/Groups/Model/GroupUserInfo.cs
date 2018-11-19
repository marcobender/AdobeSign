using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AdobeSign.Groups.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class GroupUserInfo {
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
    /// True if user is group admin
    /// </summary>
    /// <value>True if user is group admin</value>
    [DataMember(Name="isGroupAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isGroupAdmin")]
    public bool? IsGroupAdmin { get; set; }

    /// <summary>
    /// The name of company of the user
    /// </summary>
    /// <value>The name of company of the user</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public string Company { get; set; }

    /// <summary>
    /// A unique identifier of the user resource for REST APIs. This identifier can not be used in SOAP APIs
    /// </summary>
    /// <value>A unique identifier of the user resource for REST APIs. This identifier can not be used in SOAP APIs</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The email address of the user
    /// </summary>
    /// <value>The email address of the user</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupUserInfo {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  IsGroupAdmin: ").Append(IsGroupAdmin).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
