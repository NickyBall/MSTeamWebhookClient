using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTeamWebhookClient.Cards
{
    public class AdaptiveCard
    {
        [JsonProperty(PropertyName = "$schema")]
        public string Schema => "http://adaptivecards.io/schemas/adaptive-card.json";
        [JsonProperty(PropertyName = "type")]
        public string Type => "AdaptiveCard";
        [JsonProperty(PropertyName = "version")]
        public string Version => "1.0";

        [JsonProperty(PropertyName = "body")]
        public BodyObject[] Body { get; set; }
    }
}
