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
  public class UserViewResponse {
    /// <summary>
    /// List of user views
    /// </summary>
    /// <value>List of user views</value>
    [DataMember(Name="userViewList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userViewList")]
    public List<UserView> UserViewList { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserViewResponse {\n");
      sb.Append("  UserViewList: ").Append(UserViewList).Append("\n");
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
