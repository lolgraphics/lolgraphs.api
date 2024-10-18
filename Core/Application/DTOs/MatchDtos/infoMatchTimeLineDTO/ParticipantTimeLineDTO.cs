using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public class ParticipantTimeLineDTO
    {
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("puuid")]
        public string Puuid { get; set; }
    }
}
