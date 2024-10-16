using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{

    public class MetadataTimeLineDTO
    {
        [JsonProperty("dataVersion")]
        public required long DataVersion { get; set; }

        [JsonProperty("matchId")]
        public required string MatchId { get; set; }

        [JsonProperty("participants")]
        public required List<string> Participants { get; set; }
    }
}
