using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class HordeModel
    {
        [BsonElement("first")]
        public bool First { get; set; }

        [BsonElement("kills")]
        public long Kills { get; set; }
    }
}
