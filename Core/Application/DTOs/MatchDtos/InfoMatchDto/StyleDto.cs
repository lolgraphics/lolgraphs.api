using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class StyleDTO
    {
        [JsonProperty("description")]
        public required string Description { get; set; }

        [JsonProperty("selections")]
        public required List<SelectionDTO> Selections { get; set; }

        [JsonProperty("style")]
        public required long StyleStyle { get; set; }
    }
}
