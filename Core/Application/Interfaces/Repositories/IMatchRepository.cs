using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOs;
using Core.Application.DTOs.MatchDTOs.InfoMatch;

namespace Core.Application.Interfaces.Repositories
{
    public interface IMatchRepository
    {
        Task SaveMatchIdAsync(MatchDTO matchDTO);
        Task<MatchDTO> GetLastMatchPlayedAsync(string puuid);
        Task SaveInfoMatchAsync(InfoMatchDTO infoMatchDTO);
        Task SaveMatchTimeLineInfoMatchAsync(InfoMatchTimeLineDTO infoMatchDTO);
        Task<List<MatchDTO>> GetAll(string puuid);
    }
}
