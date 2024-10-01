using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class StatPerksDTO
    {
        [JsonProperty("defense")]
        public long Defense { get; set; }

        [JsonProperty("flex")]
        public long Flex { get; set; }

        [JsonProperty("offense")]
        public long Offense { get; set; }
    }

}
