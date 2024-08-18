using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public  class PerksDto
    {
        [JsonProperty("statPerks")]
        public required StatPerksDto StatPerks { get; set; }

        [JsonProperty("styles")]
        public required List<StyleDto> Styles { get; set; }
    }
}
