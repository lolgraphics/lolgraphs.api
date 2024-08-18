using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class StatPerksDto
    {
        [JsonProperty("defense")]
        public long Defense { get; set; }

        [JsonProperty("flex")]
        public long Flex { get; set; }

        [JsonProperty("offense")]
        public long Offense { get; set; }
    }

}
