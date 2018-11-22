using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class DocumentsInfo
    {
        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("supportingDocuments")]
        public SupportingDocument[] SupportingDocuments { get; set; }
    }
}
