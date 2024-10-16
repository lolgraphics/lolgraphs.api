using Core.Application.DTOs.MatchDtos.InfoMatch;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.DTOs.MatchDTOs.infoMatchTimeLineDTO;
using Newtonsoft.Json;

namespace Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO
{
    public class InfoMatchTimeLineDTO
    {

        [JsonProperty("Puuid")]
        public string Puuid { get; set; }


        [JsonProperty("MatchId")]
        public string MatchId { get; set; }


        [JsonProperty("metadata")]
        public MetadataTimeLineDTO Metadata { get; set; }

        [JsonProperty("info")]
        public InfoTimeLineDTO Info { get; set; }
    }
}
