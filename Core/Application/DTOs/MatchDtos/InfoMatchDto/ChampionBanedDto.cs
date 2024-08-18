using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatchDto
{
    public class ChampionBanedDto
    {
        [JsonProperty("championId")]
        public bool ChampionId { get; set; }

        [JsonProperty("pickTurn")]
        public long PickTurn { get; set; }
    }
}
