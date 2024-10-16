using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{

    [Table("StatPerks")]
    public class StatPerksModel
    {
        public long StatPerksModelId { get; set; } // Primary Key
        public long Defense { get; set; }
        public long Flex { get; set; }
        public long Offense { get; set; }

        // Foreign Key
        public long PerksModelId { get; set; } // Mantenha o nome da chave estrangeira
        public PerksModel Perks { get; set; } // Navegação
    }
}
