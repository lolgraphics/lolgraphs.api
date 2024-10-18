using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{

    [Table("ParticipantFrame")]
    public class ParticipantFrameModel
    {

        public long Id { get; set; } // Primary Key

        public long IdParticipantFrame { get; set; }

        public long CurrentGold { get; set; }

        public long GoldPerSecond { get; set; }

        public long JungleMinionsKilled { get; set; }

        public long Level { get; set; }

        public long MinionsKilled { get; set; }

        public long ParticipantId { get; set; }

        public long DamageStatsId { get; set; } // FK para DamageStatsModel
        public long ChampionStatsId { get; set; } // FK para ChampionStatsModel

        public DamageStatsModel DamageStats { get; set; } // Navegação para DamageStats
        public ChampionStatsModel ChampionStats { get; set; } // Navegação para ChampionStats

        // Foreign key relationship to PositionParticipantModel
        public long PositionParticipantModelId { get; set; } // Foreign Key
        public PositionParticipantModel Position { get; set; } // Navigation property


        public long TimeEnemySpentControlled { get; set; }

        public long TotalGold { get; set; }

        public long Xp { get; set; }

        // Foreign key relationship back to FrameModel
        public long FrameModelId { get; set; } // Foreign Key
        public required FrameModel Frame { get; set; } // Navigation property
    }
}
