/*
 * Copyright 2019 Jakkrit Junrat

 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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
