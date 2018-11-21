using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace AdobeSign.Model
{
    public class ApiError
    {

        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
        [DataMember(Name = "error_description", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "error_description")]
        public string ErrorDescription { get; set; }


        public string GetError()
        {
            return Error ?? Code;
        }
        public string GetDescription()
        {
            return Message ?? ErrorDescription;
        }
    }
}
