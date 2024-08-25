using Confluent.Kafka;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class InfoMatchModel
    {
        [BsonElement("metadata")]
        public required MetadataModel Metadata { get; set; }

        [BsonElement("info")]
        public required InfoModel Info { get; set; }
    }
}
