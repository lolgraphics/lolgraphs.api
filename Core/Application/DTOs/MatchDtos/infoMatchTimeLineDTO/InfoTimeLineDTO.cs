using Newtonsoft.Json;
using Core.Application.DTOs.MatchDtos.InfoMatchDto;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;

namespace Core.Application.DTOs.MatchDTOs.infoMatchTimeLineDTO
{
    public class InfoTimeLineDTO
    {
        [JsonProperty("endOfGameResult")]
        public string EndOfGameResult { get; set; }

        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }

        [JsonProperty("frames")]
        public List<FrameDTO> Frames { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("participants")]
        public List<ParticipantTimeLineDTO> Participants { get; set; }
    }
}
