namespace Core.Application.DTOs
{
    public class SummonerDTO
    {
        public required string Id { get; set; }
        public required string AccountId { get; set; }
        public required string Puuid { get; set; }
        public required int ProfileIconId { get; set; }
        public required long RevisionDate { get; set; }
        public required int SummonerLevel { get; set; }
    }
}
