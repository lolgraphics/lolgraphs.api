using Postgres.Models.Match.InfoMatch;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postgres.Models.InfoMatch
{

    [Table("Info")]
    public class InfoModel
    {
        public long Id { get; set; } // Primary Key
        public string? EndOfGameResult { get; set; }
        public long GameCreation { get; set; }
        public long GameDuration { get; set; }
        public long GameEndTimestamp { get; set; }
        public long GameId { get; set; }
        public required string GameMode { get; set; }
        public required string GameName { get; set; }
        public long GameStartTimestamp { get; set; }
        public required string GameType { get; set; }
        public required string GameVersion { get; set; }
        public long MapId { get; set; }
        public required List<ParticipantModel> Participants { get; set; }
        public required string PlatformId { get; set; }
        public long QueueId { get; set; }
        public required List<TeamModel> Teams { get; set; }
        public required string TournamentCode { get; set; }
    }
}
