using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public  class PerksDTO
    {
        [JsonProperty("statPerks")]
        public required StatPerksDTO StatPerks { get; set; }

        [JsonProperty("styles")]
        public required List<StyleDTO> Styles { get; set; }
    }
}
