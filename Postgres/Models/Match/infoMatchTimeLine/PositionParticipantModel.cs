using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{

    [Table("PositionParticipant")]
    public class PositionParticipantModel
    {
        public long Id { get; set; } // Primary Key

        public long X { get; set; }

        public long Y { get; set; }

        public long ParticipantFrameModelId { get; set; } // Foreign Key
        public required ParticipantFrameModel ParticipantFrame { get; set; } // Navigation property
    }
}
