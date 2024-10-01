using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class InfoMatchDTO
    {
        [JsonProperty("metadata")]
        public required MetadataDTO Metadata { get; set; }

        [JsonProperty("info")]
        public required InfoDTO Info { get; set; }
    }
}
