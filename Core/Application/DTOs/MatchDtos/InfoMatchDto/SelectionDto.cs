using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class SelectionDTO
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
