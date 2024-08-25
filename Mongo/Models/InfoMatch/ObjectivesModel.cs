using Core.Application.DTOs.MatchDtos.InfoMatch;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public required RiftHeraldDto RiftHerald { get; set; }

        [BsonElement("tower")]
        public required TowerModel Tower { get; set; }
    }
}
