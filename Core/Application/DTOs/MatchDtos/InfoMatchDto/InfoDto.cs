﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos.InfoMatch
{
    public class InfoDto
    {
        [JsonProperty("endOfGameResult")]
        public required string EndOfGameResult { get; set; }

        [JsonProperty("gameCreation")]
        public required long GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public required long GameDuration { get; set; }

        [JsonProperty("gameEndTimestamp")]
        public required long GameEndTimestamp { get; set; }

        [JsonProperty("gameId")]
        public required long GameId { get; set; }

        [JsonProperty("gameMode")]
        public required string GameMode { get; set; }

        [JsonProperty("gameName")]
        public required string GameName { get; set; }

        [JsonProperty("gameStartTimestamp")]
        public required long GameStartTimestamp { get; set; }

        [JsonProperty("gameType")]
        public required string GameType { get; set; }

        [JsonProperty("gameVersion")]
        public required string GameVersion { get; set; }

        [JsonProperty("mapId")]
        public required long MapId { get; set; }

        [JsonProperty("participants")]
        public required List<ParticipantDto> Participants { get; set; }

        [JsonProperty("platformId")]
        public required string PlatformId { get; set; }

        [JsonProperty("queueId")]
        public required long QueueId { get; set; }

        [JsonProperty("teams")]
        public required List<TeamDto> Teams { get; set; }

        [JsonProperty("tournamentCode")]
        public required string TournamentCode { get; set; }
    }
}
