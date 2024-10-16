using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public partial class FrameDTO
    {
        [JsonProperty("events")]
        public List<EventDTO> Events { get; set; }

        [JsonProperty("participantFrames")]
        public Dictionary<string, ParticipantFrameDTO> ParticipantFrames { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }
    }
}
