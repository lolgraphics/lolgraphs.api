using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models.InfoMatch
{
    public class InfoMatchModel
    {
        [BsonElement("metadata")]
        public required MetadataModel Metadata { get; set; }

        [BsonElement("info")]
        public required InfoModel Info { get; set; }
    }
}
