using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models.InfoMatch
{
    public class ChampionModel
    {
        [BsonElement("first")]
        public bool First { get; set; }

        [BsonElement("kills")]
        public long Kills { get; set; }
    }
}
