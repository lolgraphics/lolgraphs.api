using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{

    [Table("PositionEvent")]
    public class PositionEventModel
    {
        public long Id { get; set; } // Primary Key

        public long X { get; set; }

        public long Y { get; set; }

        // Foreign key relationship back to EventModel
        public long EventModelId { get; set; } // Foreign Key
        public required EventModel Event { get; set; } // Navigation property
    }
}
