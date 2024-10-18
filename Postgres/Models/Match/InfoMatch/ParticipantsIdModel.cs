using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.Match.InfoMatch
{
    [Table("ParticipantsId")]
    public class ParticipantsIdModel
    {
        public int Id { get; set; }
        public string ParticipantsPuuid { get; set; }

        // Foreign Key to MetadataModelInfoMatchModel
        public long MetadataModelInfoMatchModelId { get; set; } // Chave estrangeira para MetadataModelInfoMatchModel
        public MetadataInfoMatchModel MetadataInfoMatch { get; set; } // Navegação para MetadataModelInfoMatchModel
    }
}
