
namespace Postgres.Models.Match
{
    public class MatchModel
    {
        public required string Id { get; set; }

        public required string Puuid { get; set; }

        public required long TimeLastMatchPlayed { get; set; }

        public required string FormatedDate { get; set; }


    }
}
