using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
