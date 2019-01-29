using MSTeamWebhookClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSTeamWebhookClient.Cards
{
    public class MessageCard
    {
        public MessageCard() : this(string.Empty) { }

        public MessageCard(string summary, params MessageSection[] sections)
        {
            Summary = summary;
            Sections = sections;
        }

        [JsonProperty(PropertyName = "@type")]
        public string Type => "MessageCard";
        [JsonProperty(PropertyName = "@context")]
        public string Context => "http://schema.org/extensions";
        [JsonProperty(PropertyName = "themeColor")]
        public string ThemeColor => "0076D7";

        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

        [JsonProperty(PropertyName = "sections")]
        public MessageSection[] Sections { get; set; }
    }
}
