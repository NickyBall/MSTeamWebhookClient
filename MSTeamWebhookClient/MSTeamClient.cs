using MSTeamWebhookClient.Cards;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MSTeamWebhookClient
{
    public class MSTeamClient
    {
        private readonly string WebhookUrl;
        private readonly HttpClient Client = new HttpClient();

        public MSTeamClient(string webhookUrl)
        {
            WebhookUrl = webhookUrl;
        }

        public async Task<HttpResponseMessage> SendMessageAsync(MessageCard Message)
        {
            var Content = new StringContent(JsonConvert.SerializeObject(Message));
            HttpResponseMessage Response = await Client.PostAsync(WebhookUrl, Content);
            return Response;
        }
    }
}
