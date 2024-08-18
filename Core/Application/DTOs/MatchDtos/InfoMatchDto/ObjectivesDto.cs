using Confluent.Kafka;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class ObjectivesDto
    {
        [JsonProperty("baron")]
        public required BaronDto Baron { get; set; }

        [JsonProperty("champion")]
        public required ChampionDto Champion { get; set; }

        [JsonProperty("dragon")]
        public required DragonDto Dragon { get; set; }

        [JsonProperty("horde")]
        public required HordeDto Horde { get; set; }

        [JsonProperty("inhibitor")]
        public required InhibitorDto Inhibitor { get; set; }

        [JsonProperty("riftHerald")]
        public required RiftHeraldDto RiftHerald { get; set; }

        [JsonProperty("tower")]
        public required TowerDto Tower { get; set; }
    }
}
