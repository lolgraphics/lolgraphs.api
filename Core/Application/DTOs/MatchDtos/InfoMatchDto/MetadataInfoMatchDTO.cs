using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDtos.InfoMatchDto
{
    public class MetadataInfoMatchDTO
    {
        [JsonProperty("dataVersion")]
        public required long DataVersion { get; set; }

        [JsonProperty("matchId")]
        public required string MatchId { get; set; }

        [JsonProperty("participants")]
        public required List<string> Participants { get; set; }
    }
}
