using Postgres.Models.InfoMatchTimeLine;
using Postgres.Models.Match.InfoMatch;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.infoMatchTimeLine
{

    [Table("MetadataTimeLine")]
    public class MetadataTimeLineModel
    {

        public long Id { get; set; } // Primary Key

        public long DataVersion { get; set; }
        public required string MatchId { get; set; }

        // Foreign key relationship to InfoMatchTimeLineModel
        public required List<InfoMatchTimeLineModel> InfoMatchTimeLines { get; set; }
    }
}
