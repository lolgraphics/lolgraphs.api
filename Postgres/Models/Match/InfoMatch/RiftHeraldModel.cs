﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{
    [Table("RiftHerald")]
    public class RiftHeraldModel
    {
        public int Id { get; set; } // primary key
        public bool First { get; set; }
        public long Kills { get; set; }

        // Foreign Key
        public long ObjectivesId { get; set; } // Chave estrangeira para ObjectivesModel
        public ObjectivesModel Objectives { get; set; } // Navegação para ObjectivesModel
    }
}
