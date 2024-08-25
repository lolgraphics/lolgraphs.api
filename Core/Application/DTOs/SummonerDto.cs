using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs
{
    public class SummonerDto
    {
        public required string Id { get; set; }
        public required string AccountId { get; set; }
        public required string Puuid { get; set; }
        public required int ProfileIconId { get; set; }
        public required long RevisionDate { get; set; }
        public required int SummonerLevel { get; set; }
    }
}
