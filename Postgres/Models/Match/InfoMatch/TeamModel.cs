using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("Teams")]
    public class TeamModel
    {
        public long Id { get; set; } // Chave primária

        public required List<ChampionBanedModel> Bans { get; set; }

        public required ObjectivesModel Objectives { get; set; } 

        public bool Win { get; set; }

        public int TeamId { get; set; }

        // Foreign key to InfoModel
        public long InfoId { get; set; } // Chave estrangeira
        public InfoModel InfoModel { get; set; } // Propriedade de navegação
    }
}