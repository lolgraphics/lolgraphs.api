
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{

    [Table("Event")]
    public class EventModel
    {
        public long Id { get; set; } // Primary Key

        public long? RealTimestamp { get; set; }

        public long Timestamp { get; set; }

        public string? Type { get; set; }

        public string? LevelUpType { get; set; }

        public long? ParticipantId { get; set; }

        public long? SkillSlot { get; set; }

        public long? ItemId { get; set; }

        public long? CreatorId { get; set; }

        public string? WardType { get; set; }

        // Relationship to AssistingParticipantIds
        public List<AssistingParticipantIdsModel> AssistingParticipantIds { get; set; }

        public long? Bounty { get; set; }

        public long? KillStreakLength { get; set; }

        public long? KillerId { get; set; }

        // Navigation property for PositionModel
        public PositionEventModel Position { get; set; }

        public long? ShutdownBounty { get; set; }

        // Relationship to VictimDamageReceivedModel
        public List<VictimDamageDealtModel> VictimDamageDealt { get; set; }

        public List<VictimDamageReceivedModel> VictimDamageReceived { get; set; }

        public long? VictimId { get; set; }

        public string? KillType { get; set; }

        public long? MultiKillLength { get; set; }

        public long? Level { get; set; }

        public string? LaneType { get; set; }

        public long? TeamId { get; set; }

        public long? KillerTeamId { get; set; }

        public string? MonsterType { get; set; }

        public long? AfterId { get; set; }

        public long? BeforeId { get; set; }

        public long? GoldGain { get; set; }

        public string? BuildingType { get; set; }

        public string? TowerType { get; set; }

        public string? MonsterSubType { get; set; }
            
        public long? ActualStartTime { get; set; }

        public long? GameId { get; set; }

        public long? WinningTeam { get; set; }

        // Foreign key relationship back to FrameModel
        public long FrameModelId { get; set; } // Foreign Key
        public required FrameModel Frame { get; set; } // Navigation property
    }
}

