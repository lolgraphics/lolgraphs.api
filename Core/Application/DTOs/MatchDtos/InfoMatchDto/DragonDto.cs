using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class DragonDTO
    {
        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }
    }
}
