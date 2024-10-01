using Core.Application.DTOs.MatchDTOs.InfoMatch;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Models.InfoMatch
{
    public class ObjectivesModel
    {
        [BsonElement("baron")]
        public required BaronModel Baron { get; set; }

        [BsonElement("champion")]
        public required ChampionModel Champion { get; set; }

        [BsonElement("dragon")]
        public required DragonModel Dragon { get; set; }

        [BsonElement("horde")]
        public required HordeModel Horde { get; set; }

        [BsonElement("inhibitor")]
        public required InhibitorModel Inhibitor { get; set; }

        [BsonElement("riftHerald")]
        public required RiftHeraldDTO RiftHerald { get; set; }

        [BsonElement("tower")]
        public required TowerModel Tower { get; set; }
    }
}
