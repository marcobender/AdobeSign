using System;
using Newtonsoft.Json;


namespace AdobeSign.Webhooks.Event
{
    public class ChildAgreementsInfo
    {
        [JsonProperty("fileInfo")]
        public FileInfo FileInfo { get; set; }
    }
}
