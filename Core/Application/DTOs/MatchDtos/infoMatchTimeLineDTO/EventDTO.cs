using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public partial class EventDTO
    {
        [JsonProperty("realTimestamp")]
        public long? RealTimestamp { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("levelUpType")]
        public string? LevelUpType { get; set; }

        [JsonProperty("participantId")]
        public long? ParticipantId { get; set; }

        [JsonProperty("skillSlot")]
        public long? SkillSlot { get; set; }

        [JsonProperty("itemId")]
        public long? ItemId { get; set; }

        [JsonProperty("creatorId")]
        public long? CreatorId { get; set; }

        [JsonProperty("wardType")]
        public string WardType { get; set; }

        [JsonProperty("assistingParticipantIds")]
        public List<long> AssistingParticipantIds { get; set; }

        [JsonProperty("bounty")]
        public long? Bounty { get; set; }

        [JsonProperty("killStreakLength")]
        public long? KillStreakLength { get; set; }

        [JsonProperty("killerId")]
        public long? KillerId { get; set; }

        [JsonProperty("position")]
        public PositionDTO Position { get; set; }

        [JsonProperty("shutdownBounty")]
        public long? ShutdownBounty { get; set; }

        [JsonProperty("victimDamageDealt")]
        public List<VictimDamageDealDTO> VictimDamageDealt { get; set; }

        [JsonProperty("victimDamageReceived")]
        public List<VictimDamageReceivedDTO> VictimDamageReceived { get; set; }

        [JsonProperty("victimId")]
        public long? VictimId { get; set; }

        [JsonProperty("killType")]
        public string? KillType { get; set; }

        [JsonProperty("multiKillLength")]
        public long? MultiKillLength { get; set; }

        [JsonProperty("level")]
        public long? Level { get; set; }

        [JsonProperty("laneType")]
        public string LaneType { get; set; }

        [JsonProperty("teamId")]
        public long? TeamId { get; set; }

        [JsonProperty("killerTeamId")]
        public long? KillerTeamId { get; set; }

        [JsonProperty("monsterType")]
        public string MonsterType { get; set; }

        [JsonProperty("afterId")]
        public long? AfterId { get; set; }

        [JsonProperty("beforeId")]
        public long? BeforeId { get; set; }

        [JsonProperty("goldGain")]
        public long? GoldGain { get; set; }

        [JsonProperty("buildingType")]
        public string BuildingType { get; set; }

        [JsonProperty("towerType")]
        public string TowerType { get; set; }

        [JsonProperty("monsterSubType")]
        public string MonsterSubType { get; set; }

        [JsonProperty("actualStartTime")]
        public long? ActualStartTime { get; set; }

        [JsonProperty("gameId")]
        public long? GameId { get; set; }

        [JsonProperty("winningTeam")]
        public long? WinningTeam { get; set; }
    }
}
