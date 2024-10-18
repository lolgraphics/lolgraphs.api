using Postgres.Models.Match;
using Postgres.Models.Match.infoMatchTimeLine;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{

    [Table("InfoMatch")]
    public class InfoMatchModel
    {
        public string Puuid { get; set; }

        public string MatchId { get; set; }

        public required MetadataInfoMatchModel Metadata { get; set; }
        public required InfoModel Info { get; set; }
    }
}
