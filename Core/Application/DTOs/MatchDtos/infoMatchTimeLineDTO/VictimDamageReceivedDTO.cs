using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public class VictimDamageReceivedDTO
    {
        public bool Basic { get; set; }

        public long MagicDamage { get; set; }

        public string Name { get; set; }

        public long ParticipantId { get; set; }

        public long PhysicalDamage { get; set; }

        public string SpellName { get; set; }

        public long SpellSlot { get; set; }

        public long TrueDamage { get; set; }

        public string Type { get; set; }
    }
}

