using System;
using Newtonsoft.Json;

namespace AdobeSign.Webhooks.Event
{
    public class ParticipantSetsInfo
    {
        [JsonProperty("participantSets")]
        public ParticipantSet[] ParticipantSets { get; set; }

        [JsonProperty("additionalParticipantSets")]
        public ParticipantSet[] AdditionalParticipantSets { get; set; }

        [JsonProperty("widgetParticipantSet")]
        public ParticipantSet WidgetParticipantSet { get; set; }
    }
}
