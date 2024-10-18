

using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{
    [Table("AssistingParticipantIds")]
    public class AssistingParticipantIdsModel
    {
        public long Id { get; set; } // Primary Key
        public long AssistingParticipantId { get; set; } // Corrected property name

        // Foreign key relationship back to EventModel
        public long EventModelId { get; set; } // Foreign Key
        public  EventModel Event { get; set; } // Navigation property
    }
}
