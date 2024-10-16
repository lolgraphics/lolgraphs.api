using Postgres.Models.Match.InfoMatch;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("Perks")]
    public class PerksModel
    {
        public long PerksModelId { get; set; } // Primary Key
        public required StatPerksModel StatPerks { get; set; }
        public required List<StyleModel> Styles { get; set; }

        // Foreign Key
        public long ParticipantModelId { get; set; } // Mantenha o nome da chave estrangeira
        public ParticipantModel Participant { get; set; } // Navegação
    }
}
