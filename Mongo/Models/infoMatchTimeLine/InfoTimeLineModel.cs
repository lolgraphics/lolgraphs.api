using Newtonsoft.Json;
using Core.Application.DTOs.MatchDTOS;

namespace Mongo.Models.InfoMatchTimeLine
{
    public class InfoTimeLineModel
    {
        [JsonProperty("endOfGameResult")]
        public string EndOfGameResult { get; set; }

        [JsonProperty("frameInterval")]
        public long FrameInterval { get; set; }

        [JsonProperty("frames")]
        public FrameDTO[] Frames { get; set; }

        [JsonProperty("gameId")]
        public long GameId { get; set; }

        [JsonProperty("participants")]
        public ParticipantDTO[] Participants { get; set; }
    }
}
