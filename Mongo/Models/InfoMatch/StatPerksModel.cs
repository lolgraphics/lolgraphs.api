using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class StatPerksModel
    {
        [BsonElement("defense")]
        public long Defense { get; set; }

        [BsonElement("flex")]
        public long Flex { get; set; }

        [BsonElement("offense")]
        public long Offense { get; set; }
    }

}
