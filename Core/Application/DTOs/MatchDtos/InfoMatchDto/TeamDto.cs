using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public  class TeamDto
    {
        [JsonProperty("bans")]
        public required List<object> Bans { get; set; }

        [JsonProperty("objectives")]
        public required ObjectivesDto Objectives { get; set; }

        [JsonProperty("teamId")]
        public required long TeamId { get; set; }

        [JsonProperty("win")]
        public required bool Win { get; set; }
    }

}
