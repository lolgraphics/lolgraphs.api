using Newtonsoft.Json;
using Postgres.Models.InfoMatchTimeLine;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postgres.Models.Match.infoMatchTimeLine
{
    [Table("ParticipantTimeLine")]
    public class ParticipantTimeLineModel
    {
        public int Id { get; set; }

        public int ParticipantId { get; set; }

        public string Puuid { get; set; }

        // Foreign key relationship back to InfoTimeLineModel
        public long InfoTimeLineModelId { get; set; } // Foreign Key
        public required InfoTimeLineModel InfoTimeLine { get; set; } // Navigation property
    }
}
