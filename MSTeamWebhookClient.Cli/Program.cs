using MSTeamWebhookClient.Cards;
using MSTeamWebhookClient.Constants;
using MSTeamWebhookClient.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MSTeamWebhookClient.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            AdaptiveCard AdapCard = new AdaptiveCard();
            AdapCard.Body = new BodyObject[]
            {
                new BodyObject()
                {
                    Type = ObjectType.TextBlock,
                    Text = $"This is some {TextGenerator.CreateBoldText("bold")} text"
                },
                new BodyObject()
                {
                    Type = ObjectType.TextBlock,
                    Text = $"This is some {TextGenerator.CreateItalicText("italic")} text"
                },
                new BodyObject()
                {
                    Type = ObjectType.TextBlock,
                    Text = TextGenerator.CreateBulletText("Bullet", "List"),
                    Wrap = true
                },
                new BodyObject()
                {
                    Type = ObjectType.TextBlock,
                    Text = TextGenerator.CreateNumberedText("Numered", "List"),
                    Wrap = true
                },
                new BodyObject()
                {
                    Type = ObjectType.TextBlock,
                    Text = $"Check out {TextGenerator.CreateLinkText("http://adaptivecards.io", "Adaptive Cards")}"
                },
            };

            var Result = JsonConvert.SerializeObject(AdapCard);
            Console.WriteLine(Result);

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
