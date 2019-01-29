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
