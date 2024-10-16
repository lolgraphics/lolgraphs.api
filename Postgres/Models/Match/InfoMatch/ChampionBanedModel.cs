using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{

    [Table("ChampionBaned")]
    public class ChampionBanedModel
    {
        public int Id { get; set; } // primary key
        public long ChampionId { get; set; }
        public long PickTurn { get; set; }

        // Foreign Key
        public long TeamId { get; set; } // Chave estrangeira para Team
        public TeamModel Team { get; set; } // Navegação para o Team
    }

}
