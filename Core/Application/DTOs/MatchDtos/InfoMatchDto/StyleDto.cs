using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class StyleDto
    {
        [JsonProperty("description")]
        public required string Description { get; set; }

        [JsonProperty("selections")]
        public required List<SelectionDto> Selections { get; set; }

        [JsonProperty("style")]
        public required long StyleStyle { get; set; }
    }
}
