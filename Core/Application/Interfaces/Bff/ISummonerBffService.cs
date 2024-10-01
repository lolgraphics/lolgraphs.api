using Core.Application.DTOs;

namespace Core.Application.Interfaces.Bff
{
    public interface ISummonerBffService
    {
        Task<AccountDTO> GetAccountDataAsync(string name);

        Task<SummonerDTO> GetSummonerByPuuid(string puuid);
    }
}
