using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOs.InfoMatch;

namespace Core.Application.Interfaces.Bff
{
    public interface IMatchBffService
    {
        Task<List<string>> GetMatchByPuuidAsync(string puuid, long startTime, long endTime);
        Task<InfoMatchDTO> GetMatchInfoByMatchIdAsync(string matchId);
        Task<InfoMatchTimeLineDTO> GetMatchTimeLineByMatchIdAsync(string matchId);

    }
}
