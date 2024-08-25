using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
