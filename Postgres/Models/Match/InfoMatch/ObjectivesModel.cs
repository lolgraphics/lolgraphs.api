using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("Objectives")]
    public class ObjectivesModel
    {
        public long Id { get; set; } // Chave primária

        public required BaronModel Baron { get; set; }
        public required ChampionModel Champion { get; set; }
        public required DragonModel Dragon { get; set; }
        public required HordeModel Horde { get; set; }
        public required InhibitorModel Inhibitor { get; set; }
        public required RiftHeraldModel RiftHerald { get; set; }
        public required TowerModel Tower { get; set; }

        // Foreign Key
        public long TeamId { get; set; } // Chave estrangeira para Team
        public TeamModel Team { get; set; } // Navegação para o Team
    }
}