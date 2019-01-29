using MSTeamWebhookClient.Cards;
using MSTeamWebhookClient.Constants;
using MSTeamWebhookClient.Helpers;
using MSTeamWebhookClient.Models;
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
        private static string MsTeamWebhookUrl = "https://outlook.office.com/webhook/e5919028-b41e-4efb-bfec-62564e26becf@1bf12a4f-2277-4d37-83db-525780663f76/IncomingWebhook/809dbd1a9d804b03a15ce5c4ce7c28b9/b89b96b3-7b9a-4d34-ae36-e83156f15335";

        static void Main(string[] args)
        {
            //AdaptiveCard AdapCard = new AdaptiveCard();
            //AdapCard.Body = new BodyObject[]
            //{
            //    new BodyObject()
            //    {
            //        Type = ObjectType.TextBlock,
            //        Text = $"This is some {TextGenerator.CreateBoldText("bold")} text"
            //    },
            //    new BodyObject()
            //    {
            //        Type = ObjectType.TextBlock,
            //        Text = $"This is some {TextGenerator.CreateItalicText("italic")} text"
            //    },
            //    new BodyObject()
            //    {
            //        Type = ObjectType.TextBlock,
            //        Text = TextGenerator.CreateBulletText("Bullet", "List"),
            //        Wrap = true
            //    },
            //    new BodyObject()
            //    {
            //        Type = ObjectType.TextBlock,
            //        Text = TextGenerator.CreateNumberedText("Numered", "List"),
            //        Wrap = true
            //    },
            //    new BodyObject()
            //    {
            //        Type = ObjectType.TextBlock,
            //        Text = $"Check out {TextGenerator.CreateLinkText("http://adaptivecards.io", "Adaptive Cards")}"
            //    },
            //};

            MSTeamClient MsClient = new MSTeamClient(MsTeamWebhookUrl);

            MessageCard messageCard = new MessageCard()
            {
                Summary = "This is a Summary",
                Sections = new[]
                {
                    new MessageSection()
                    {
                        ActivityTitle = "![TestImage](https://47a92947.ngrok.io/Content/Images/default.png)Larry Bryant created a new taskxx",
                        ActivitySubtitle = "On Project Tango",
                        ActivityImage = "https://teamsnodesample.azurewebsites.net/static/img/image5.png",
                        Markdown = true,
                        Facts = new[]
                        {
                            new SectionFact()
                            {
                                Name = "Assigned to",
                                Value = "Unassigned"
                            }
                        }
                    }
                }
            };

            var Result = JsonConvert.SerializeObject(messageCard);
            Console.WriteLine(Result);

            MsClient.SendMessageAsync(messageCard).GetAwaiter().GetResult();

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
