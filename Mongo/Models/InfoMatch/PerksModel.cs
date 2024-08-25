using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public  class PerksModel
    {
        [BsonElement("statPerks")]
        public required StatPerksModel StatPerks { get; set; }

        [BsonElement("styles")]
        public required List<StyleModel> Styles { get; set; }
    }
}
