using Core.Application.Enum;
using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public partial class EventDTO
    {
        [JsonProperty("realTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? RealTimestamp { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("levelUpType", NullValueHandling = NullValueHandling.Ignore)]
        public string LevelUpType { get; set; }

        [JsonProperty("participantId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParticipantId { get; set; }

        [JsonProperty("skillSlot", NullValueHandling = NullValueHandling.Ignore)]
        public long? SkillSlot { get; set; }

        [JsonProperty("itemId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ItemId { get; set; }

        [JsonProperty("creatorId", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatorId { get; set; }

        [JsonProperty("wardType", NullValueHandling = NullValueHandling.Ignore)]
        public string WardType { get; set; }

        [JsonProperty("assistingParticipantIds", NullValueHandling = NullValueHandling.Ignore)]
        public long[] AssistingParticipantIds { get; set; }

        [JsonProperty("bounty", NullValueHandling = NullValueHandling.Ignore)]
        public long? Bounty { get; set; }

        [JsonProperty("killStreakLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillStreakLength { get; set; }

        [JsonProperty("killerId", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillerId { get; set; }

        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public PositionDTO Position { get; set; }

        [JsonProperty("shutdownBounty", NullValueHandling = NullValueHandling.Ignore)]
        public long? ShutdownBounty { get; set; }

        [JsonProperty("victimDamageDealt", NullValueHandling = NullValueHandling.Ignore)]
        public VictimDamageDTO[] VictimDamageDealt { get; set; }

        [JsonProperty("victimDamageReceived", NullValueHandling = NullValueHandling.Ignore)]
        public VictimDamageDTO[] VictimDamageReceived { get; set; }

        [JsonProperty("victimId", NullValueHandling = NullValueHandling.Ignore)]
        public long? VictimId { get; set; }

        [JsonProperty("killType", NullValueHandling = NullValueHandling.Ignore)]
        public string? KillType { get; set; }

        [JsonProperty("multiKillLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MultiKillLength { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public long? Level { get; set; }

        [JsonProperty("laneType", NullValueHandling = NullValueHandling.Ignore)]
        public string LaneType { get; set; }

        [JsonProperty("teamId", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamId { get; set; }

        [JsonProperty("killerTeamId", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillerTeamId { get; set; }

        [JsonProperty("monsterType", NullValueHandling = NullValueHandling.Ignore)]
        public string MonsterType { get; set; }

        [JsonProperty("afterId", NullValueHandling = NullValueHandling.Ignore)]
        public long? AfterId { get; set; }

        [JsonProperty("beforeId", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeforeId { get; set; }

        [JsonProperty("goldGain", NullValueHandling = NullValueHandling.Ignore)]
        public long? GoldGain { get; set; }

        [JsonProperty("buildingType", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildingType { get; set; }

        [JsonProperty("towerType", NullValueHandling = NullValueHandling.Ignore)]
        public string TowerType { get; set; }

        [JsonProperty("monsterSubType", NullValueHandling = NullValueHandling.Ignore)]
        public string MonsterSubType { get; set; }

        [JsonProperty("actualStartTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActualStartTime { get; set; }

        [JsonProperty("gameId", NullValueHandling = NullValueHandling.Ignore)]
        public long? GameId { get; set; }

        [JsonProperty("winningTeam", NullValueHandling = NullValueHandling.Ignore)]
        public long? WinningTeam { get; set; }
    }
}
