using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public  class TeamModel
    {
        [BsonElement("bans")]
        public required List<ChampionBanedModel> Bans { get; set; }

        [BsonElement("objectives")]
        public required ObjectivesModel Objectives { get; set; }

        [BsonElement("teamId")]
        public long TeamId { get; set; }

        [BsonElement("win")]
        public bool Win { get; set; }
    }

}
