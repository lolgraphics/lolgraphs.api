using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models.InfoMatch
{
    public class ChampionBanedModel
    {
        [BsonElement("championId")]
        public bool ChampionId { get; set; }

        [BsonElement("pickTurn")]
        public long PickTurn { get; set; }
    }
}
