using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Models.InfoMatch
{
    public class InfoModel
    {
        [BsonElement("endOfGameResult")]
        public required string EndOfGameResult { get; set; }

        [BsonElement("gameCreation")]
        public long GameCreation { get; set; }

        [BsonElement("gameDuration")]
        public long GameDuration { get; set; }

        [BsonElement("gameEndTimestamp")]
        public long GameEndTimestamp { get; set; }

        [BsonElement("gameId")]
        public long GameId { get; set; }

        [BsonElement("gameMode")]
        public required string GameMode { get; set; }

        [BsonElement("gameName")]
        public required string GameName { get; set; }

        [BsonElement("gameStartTimestamp")]
        public long GameStartTimestamp { get; set; }

        [BsonElement("gameType")]
        public required string GameType { get; set; }

        [BsonElement("gameVersion")]
        public required string GameVersion { get; set; }

        [BsonElement("mapId")]
        public long MapId { get; set; }

        [BsonElement("participants")]
        public required List<ParticipantModel> Participants { get; set; }

        [BsonElement("platformId")]
        public required string PlatformId { get; set; }

        [BsonElement("queueId")]
        public long QueueId { get; set; }

        [BsonElement("teams")]
        public required List<TeamModel> Teams { get; set; }

        [BsonElement("tournamentCode")]
        public required string TournamentCode { get; set; }
    }
}
