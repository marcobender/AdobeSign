using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSign.Model
{
    public class ApiToken
    {

        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "token_type")]
        public string TokenType { get; set; }

        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshToken { get; set; }
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expires_in")]
        public int ExpiresIn { get; set; }
    }
}
