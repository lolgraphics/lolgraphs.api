

using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{

    [Table("VictimDamageReceived")]
    public class VictimDamageReceivedModel
    {
        public long Id { get; set; } // Primary Key

        public bool Basic { get; set; }

        public long MagicDamage { get; set; }

        public string Name { get; set; }

        public long ParticipantId { get; set; }

        public long PhysicalDamage { get; set; }

        public string SpellName { get; set; }

        public long SpellSlot { get; set; }

        public long TrueDamage { get; set; }

        public string Type { get; set; }

        // Foreign key relationship back to EventModel
        public long EventModelId { get; set; } // Foreign Key
        public required EventModel Event { get; set; } // Navigation property
    }
}
