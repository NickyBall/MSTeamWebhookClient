using MSTeamWebhookClient.Constants;
using Newtonsoft.Json;

namespace MSTeamWebhookClient.Cards
{
    public class BodyObject
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "wrap")]
        public bool Wrap { get; set; }
    }
}