using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public partial class TimeFrameParticipantDTO
    {
        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }
    }
}
