using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public partial class ParticipantFrameDTO
    {
        [JsonProperty("championStats")]
        public Dictionary<string, long> ChampionStats { get; set; }

        [JsonProperty("currentGold")]
        public long CurrentGold { get; set; }

        [JsonProperty("damageStats")]
        public Dictionary<string, long> DamageStats { get; set; }

        [JsonProperty("goldPerSecond")]
        public long GoldPerSecond { get; set; }

        [JsonProperty("jungleMinionsKilled")]
        public long JungleMinionsKilled { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("minionsKilled")]
        public long MinionsKilled { get; set; }

        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("position")]
        public PositionDTO Position { get; set; }

        [JsonProperty("timeEnemySpentControlled")]
        public long TimeEnemySpentControlled { get; set; }

        [JsonProperty("totalGold")]
        public long TotalGold { get; set; }

        [JsonProperty("xp")]
        public long Xp { get; set; }
    }
}
