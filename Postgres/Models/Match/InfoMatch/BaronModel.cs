using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("Baron")]
    public class BaronModel
    {
        public long Id { get; set; } // Primary key

        public bool First { get; set; }
        public long Kills { get; set; }

        // Foreign Key
        public long ObjectivesId { get; set; } // Chave estrangeira para ObjectivesModel
        public ObjectivesModel Objectives { get; set; } // Navegação para ObjectivesModel
    }
}
