using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class SelectionModel
    {
        [BsonElement("perk")]
        public long Perk { get; set; }

        [BsonElement("var1")]
        public long Var1 { get; set; }

        [BsonElement("var2")]
        public long Var2 { get; set; }

        [BsonElement("var3")]
        public long Var3 { get; set; }
    }
}
