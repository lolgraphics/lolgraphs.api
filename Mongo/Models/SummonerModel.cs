using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Mongo.Models
{
    public class SummonerModel
    {
        [BsonElement("id")]
        public required string Id { get; set; }

        [BsonElement("accountId")]
        public required string AccountId { get; set; }

        [BsonElement("puuid")]
        public required string Puuid { get; set; }

        [BsonElement("profileIconId")]
        public int ProfileIconId { get; set; }

        [BsonElement("revisionDate")]
        public long RevisionDate { get; set; }

        [BsonElement("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
