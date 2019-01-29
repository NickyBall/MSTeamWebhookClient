using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTeamWebhookClient.Models
{
    public class MessageSection
    {
        [JsonProperty(PropertyName = "activityTitle")]
        public string ActivityTitle { get; set; }
        [JsonProperty(PropertyName = "activitySubtitle")]
        public string ActivitySubtitle { get; set; }
        [JsonProperty(PropertyName = "activityImage")]
        public string ActivityImage { get; set; }
        [JsonProperty(PropertyName = "facts")]
        public SectionFact[] Facts { get; set; }
        [JsonProperty(PropertyName = "markdown")]
        public bool Markdown { get; set; }

    }
}
