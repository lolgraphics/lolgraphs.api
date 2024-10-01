using Newtonsoft.Json;
using Core.Application.Enum;

namespace Core.Application.DTOs.MatchDTOs.InfoMatch
{
    public partial class VictimDamageDTO
    {
        [JsonProperty("basic")]
        public bool Basic { get; set; }

        [JsonProperty("magicDamage")]
        public long MagicDamage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("participantId")]
        public long ParticipantId { get; set; }

        [JsonProperty("physicalDamage")]
        public long PhysicalDamage { get; set; }

        [JsonProperty("spellName")]
        public string SpellName { get; set; }

        [JsonProperty("spellSlot")]
        public long SpellSlot { get; set; }

        [JsonProperty("trueDamage")]
        public long TrueDamage { get; set; }

        [JsonProperty("type")]
        public VictimDamageDealtType Type { get; set; }
    }
}
