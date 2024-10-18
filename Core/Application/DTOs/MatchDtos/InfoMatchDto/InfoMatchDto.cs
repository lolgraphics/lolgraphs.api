using Confluent.Kafka;
using Core.Application.DTOs.MatchDtos.InfoMatchDto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class InfoMatchDto
    {
        [JsonProperty("Puuid")]
        public string Puuid { get; set; }


        [JsonProperty("MatchId")]
        public string MatchId { get; set; }

        [JsonProperty("metadata")]
        public required MetadataInfoMatchDTO Metadata { get; set; }

        [JsonProperty("info")]
        public required InfoDto Info { get; set; }
    }
}
