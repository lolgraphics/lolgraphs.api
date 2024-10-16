using Postgres.Models.Match;
using Postgres.Models.Match.infoMatchTimeLine;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatchTimeLine
{

    [Table("InfoTimeLine")]
    public class InfoTimeLineModel
    {
        public long Id { get; set; } // Primary Key

        public string? EndOfGameResult { get; set; }

        public long FrameInterval { get; set; }

        public List<FrameModel> Frames { get; set; }

        public List<ParticipantTimeLineModel> ParticipantsTimeLine { get; set; }

        public long GameId { get; set; }


        // Foreign key relationship to InfoMatchTimeLineModel
        public required List<InfoMatchTimeLineModel> InfoMatchTimeLines { get; set; }
    }
}
