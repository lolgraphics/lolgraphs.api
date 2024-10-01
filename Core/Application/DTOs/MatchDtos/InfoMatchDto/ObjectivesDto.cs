using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public class ObjectivesDTO
    {
        [JsonProperty("baron")]
        public required BaronDTO Baron { get; set; }

        [JsonProperty("champion")]
        public required ChampionDTO Champion { get; set; }

        [JsonProperty("dragon")]
        public required DragonDTO Dragon { get; set; }

        [JsonProperty("horde")]
        public required HordeDTO Horde { get; set; }

        [JsonProperty("inhibitor")]
        public required InhibitorDTO Inhibitor { get; set; }

        [JsonProperty("riftHerald")]
        public required RiftHeraldDTO RiftHerald { get; set; }

        [JsonProperty("tower")]
        public required TowerDTO Tower { get; set; }
    }
}
