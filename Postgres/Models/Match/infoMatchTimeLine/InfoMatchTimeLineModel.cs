using Postgres.Models.Match.infoMatchTimeLine;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatchTimeLine
{
    [Table("InfoMatchTimeLine")]
    public class InfoMatchTimeLineModel
    {

        public string Puuid { get; set; }

        public string MatchId { get; set; } 

        // Foreign key relationship to MetadataModel
        public long MetadataModelId { get; set; } // Foreign Key
        public required MetadataTimeLineModel Metadata { get; set; } // Navigation property

        // Foreign key relationship to InfoTimeLineModel
        public long InfoTimeLineModelId { get; set; } // Foreign Key
        public required InfoTimeLineModel Info { get; set; } // Navigation property
    }
}
