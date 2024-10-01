using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models.InfoMatch
{
    public class StyleModel
    {
        [BsonElement("description")]
        public required string Description { get; set; }

        [BsonElement("selections")]
        public required List<SelectionModel> Selections { get; set; }

        [BsonElement("style")]
        public long StyleStyle { get; set; }
    }
}
