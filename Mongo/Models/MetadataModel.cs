using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models
{
    public class MetadataModel
    {
        [BsonElement("dataVersion")]
        public long DataVersion { get; set; }

        [BsonElement("matchId")]
        public required string MatchId { get; set; }

        [BsonElement("participants")]
        public required List<string> Participants { get; set; }
    }
}
