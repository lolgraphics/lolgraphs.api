using Confluent.Kafka;
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
        [JsonProperty("metadata")]
        public required MetadataDto Metadata { get; set; }

        [JsonProperty("info")]
        public required InfoDto Info { get; set; }
    }
}
