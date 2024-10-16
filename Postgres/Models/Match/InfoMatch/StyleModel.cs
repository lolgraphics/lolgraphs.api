using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("Style")]
    public class StyleModel
    {
        public long StyleModelId { get; set; } // Primary Key
        public required string Description { get; set; }
        public long StyleStyle { get; set; }

        // Foreign Key
        public long PerksModelId { get; set; }
        public PerksModel Perks { get; set; } // Relacionamento de Navegação

        public required List<SelectionModel> Selections { get; set; }
    }
}
