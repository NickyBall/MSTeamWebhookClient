using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTeamWebhookClient.Helpers
{
    public class TextGenerator
    {
        public static string CreateBulletText(params string[] Items)
        {
            StringBuilder StrBuilder = new StringBuilder("");
            foreach (string Item in Items)
            {
                StrBuilder.Append($"- {Item} \r");
            }
            return StrBuilder.ToString();
        }

        public static string CreateNumberedText(params string[] Items)
        {
            StringBuilder StrBuilder = new StringBuilder("");
            for (int i = 0; i < Items.Count(); i++)
            {
                string Item = Items[i];
                StrBuilder.Append($"{i+1}. {Item} \r");
            }
            return StrBuilder.ToString();
        }

        public static string CreateLinkText(string Url, string DisplayText) => $"[{DisplayText}]({Url})";

        public static string CreateBoldText(string Text) => $"**{Text}**";

        public static string CreateItalicText(string Text) => $"_{Text}_";
    }
}
