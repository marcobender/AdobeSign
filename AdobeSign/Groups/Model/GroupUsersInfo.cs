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
  public class GroupUsersInfo {
    /// <summary>
    /// The list of users in the account.
    /// </summary>
    /// <value>The list of users in the account.</value>
    [DataMember(Name="userInfoList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userInfoList")]
    public List<GroupUserInfo> UserInfoList { get; set; }

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
      sb.Append("class GroupUsersInfo {\n");
      sb.Append("  UserInfoList: ").Append(UserInfoList).Append("\n");
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
