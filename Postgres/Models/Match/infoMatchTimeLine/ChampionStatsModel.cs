using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{
    [Table("ChampionStats")]
    public class ChampionStatsModel
    {
        public long Id { get; set; } // Primary Key
        public int AbilityHaste { get; set; }
        public int AbilityPower { get; set; }
        public int Armor { get; set; }
        public int ArmorPen { get; set; }
        public int ArmorPenPercent { get; set; }
        public int AttackDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int BonusArmorPenPercent { get; set; }
        public int BonusMagicPenPercent { get; set; }
        public int CcReduction { get; set; }
        public int CooldownReduction { get; set; }
        public int Health { get; set; }
        public int HealthMax { get; set; }
        public int HealthRegen { get; set; }
        public int Lifesteal { get; set; }
        public int MagicPen { get; set; }
        public int MagicPenPercent { get; set; }
        public int MagicResist { get; set; }
        public int MovementSpeed { get; set; }
        public int Omnivamp { get; set; }
        public int PhysicalVamp { get; set; }
        public int Power { get; set; }
        public int PowerMax { get; set; }
        public int PowerRegen { get; set; }
        public int SpellVamp { get; set; }

        // Novo campo para identificar o participante
        public int ParticipantId { get; set; }

        // Navigation property back to ParticipantFrameModel
        public List<ParticipantFrameModel> ParticipantFrames { get; set; }
    }
}
