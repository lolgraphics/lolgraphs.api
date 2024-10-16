using Postgres.Models.Match.InfoMatch;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match
{

    [Table("MetadataInfoMatch")]
    public class MetadataInfoMatchModel
    {
        public long Id { get; set; } // Primary Key
        public long DataVersion { get; set; }
        public required string MatchId { get; set; }
        public required List<ParticipantsIdModel> Participants { get; set; } 
    }
}
