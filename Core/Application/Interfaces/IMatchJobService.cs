namespace Core.Application.Interfaces
{
    public interface IMatchJobService
    {
        Task ProcessMatchesAsync(string puuid);
    }
}
