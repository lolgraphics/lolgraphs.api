using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class MetadataModel
    {
        [BsonElement("dataVersion")]
        public long DataVersion { get; set; }

        [BsonElement("matchId")]
        public required string MatchId { get; set; }

        [BsonElement("participants")]
        public  required List<string>  Participants { get; set; }
    }
}
