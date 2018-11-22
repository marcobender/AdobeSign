using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class FileInfo
    {
        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("childAgreementsInfoFileId")]
        public string ChildAgreementsInfoFileId { get; set; }
    }
}
