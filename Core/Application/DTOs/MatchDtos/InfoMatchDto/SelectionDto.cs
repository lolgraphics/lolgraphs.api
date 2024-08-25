using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class SelectionDto
    {
        [JsonProperty("perk")]
        public long Perk { get; set; }

        [JsonProperty("var1")]
        public long Var1 { get; set; }

        [JsonProperty("var2")]
        public long Var2 { get; set; }

        [JsonProperty("var3")]
        public long Var3 { get; set; }
    }
}
