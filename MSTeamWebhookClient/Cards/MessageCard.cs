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
