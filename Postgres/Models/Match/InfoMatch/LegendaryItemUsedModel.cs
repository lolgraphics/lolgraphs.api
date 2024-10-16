using Postgres.Models.InfoMatch;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.InfoMatch
{
    [Table("LegendaryItemUsed")]
    public class LegendaryItemUsedModel
    {
        public long LegendaryItemUsedModelId { get; set; }
        public required long LegendaryItemId { get; set; } 
        public long ChallengesModelId { get; set; }
        public ChallengesModel Challenges { get; set; } 
    }
}
