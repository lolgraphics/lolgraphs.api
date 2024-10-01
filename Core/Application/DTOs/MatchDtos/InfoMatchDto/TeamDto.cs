using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public  class TeamDTO
    {
        [JsonProperty("bans")]
        public required List<object> Bans { get; set; }

        [JsonProperty("objectives")]
        public required ObjectivesDTO Objectives { get; set; }

        [JsonProperty("teamId")]
        public required long TeamId { get; set; }

        [JsonProperty("win")]
        public required bool Win { get; set; }
    }

}
