using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models.InfoMatchTimeLine
{
    public class InfoMatchTimeLineModel
    {
        [BsonElement("metadata")]
        public required MetadataModel Metadata { get; set; }

        [BsonElement("info")]
        public required InfoTimeLineModel Info { get; set; }
    }
}
