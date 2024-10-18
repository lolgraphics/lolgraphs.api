
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Postgres.Models.InfoMatchTimeLine;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{
    [Table("Frame")]
    public class FrameModel
    {
        public long Id { get; set; } // Primary Key

        public List<EventModel> Events { get; set; }

        public List<ParticipantFrameModel> ParticipantFrames { get; set; }

        public long Timestamp { get; set; }

        // Foreign key relationship back to InfoTimeLineModel
        public long InfoTimeLineModelId { get; set; } // Foreign Key
        public required InfoTimeLineModel InfoTimeLine { get; set; } // Navigation property
    }
}
