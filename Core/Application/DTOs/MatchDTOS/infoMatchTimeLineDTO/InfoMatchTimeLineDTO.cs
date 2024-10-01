using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.DTOs.MatchDTOs.infoMatchTimeLineDTO;
using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public class InfoMatchTimeLineDTO
    {
        [JsonProperty("metadata")]
        public MetadataDTO Metadata { get; set; }

        [JsonProperty("info")]
        public InfoTimeLineDTO Info { get; set; }
    }
}
