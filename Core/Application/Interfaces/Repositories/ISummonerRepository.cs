using Core.Application.DTOs;

namespace Core.Application.Interfaces.Repositories
{
    public interface ISummonerRepository
    {
        Task<SummonerDTO> GetSummonerAsync(string puuid);
        Task SaveSummonerAsync(SummonerDTO summoner);
    }
}
