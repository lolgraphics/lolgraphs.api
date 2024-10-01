using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class MetadataDTO
    {
        [JsonProperty("dataVersion")]
        public required long DataVersion { get; set; }

        [JsonProperty("matchId")]
        public required string MatchId { get; set; }

        [JsonProperty("participants")]
        public required List<string> Participants { get; set; }
    }
}
