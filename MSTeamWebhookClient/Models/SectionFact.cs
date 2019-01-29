using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTeamWebhookClient.Models
{
    public class SectionFact
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
