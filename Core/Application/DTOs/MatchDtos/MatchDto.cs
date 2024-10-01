namespace Core.Application.DTOs.MatchDTOs
{
    public class MatchDTO(string Id, string puuid, long TimeLastMatchPlayed, string FormatedDate)
    {
        public  string Id { get; set; } = Id;
        public  string Puuid { get; set; } = puuid;
        public  long TimeLastMatchPlayed { get; set; } = TimeLastMatchPlayed;
        public  string FormatedDate { get; set; } = FormatedDate;

    }
}
