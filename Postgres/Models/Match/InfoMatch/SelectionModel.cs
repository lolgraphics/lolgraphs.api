using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("Selection")]
    public class SelectionModel
    {
        public long SelectionModelId { get; set; } // Primary Key
        public long Perk { get; set; }
        public long Var1 { get; set; }
        public long Var2 { get; set; }
        public long Var3 { get; set; }

        // Foreign Key
        public long StyleModelId { get; set; } // Mantenha o nome da chave estrangeira
        public StyleModel Style { get; set; } // Navegação
    }
}
