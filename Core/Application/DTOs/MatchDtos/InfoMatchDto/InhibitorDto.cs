using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class InhibitorDto
    {
        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }
    }
}
