using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatchDTO
{
    public class ChampionBanedDTO
    {
        [JsonProperty("championId")]
        public bool ChampionId { get; set; }

        [JsonProperty("pickTurn")]
        public long PickTurn { get; set; }
    }
}
