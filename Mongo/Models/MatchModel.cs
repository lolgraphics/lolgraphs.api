using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models
{
    public class MatchModel
    {
        [BsonElement("id")]
        public required string Id { get; set; }

        [BsonElement("puuid")]
        public required string Puuid { get; set; }

        [BsonElement("timeLastMatchPlayed")]
        public required long TimeLastMatchPlayed { get; set; }
        
        [BsonElement("formatedDate")]
        public required string FormatedDate { get; set; }


    }
}
