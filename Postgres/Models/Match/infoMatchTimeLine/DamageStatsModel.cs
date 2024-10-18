using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{
    [Table("DamageStats")]
    public class DamageStatsModel
    {
        public long Id { get; set; } // Primary Key
        public int MagicDamageDone { get; set; }
        public int MagicDamageDoneToChampions { get; set; }
        public int MagicDamageTaken { get; set; }
        public int PhysicalDamageDone { get; set; }
        public int PhysicalDamageDoneToChampions { get; set; }
        public int PhysicalDamageTaken { get; set; }
        public int TotalDamageDone { get; set; }
        public int TotalDamageDoneToChampions { get; set; }
        public int TotalDamageTaken { get; set; }
        public int TrueDamageDone { get; set; }
        public int TrueDamageDoneToChampions { get; set; }
        public int TrueDamageTaken { get; set; }

        // Novo campo para identificar o participante
        public int ParticipantId { get; set; }

        // Navigation property back to ParticipantFrameModel
        public List<ParticipantFrameModel> ParticipantFrames { get; set; }
    }
}
