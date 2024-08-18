using Core.Application.DTOs;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
    public interface ISummonerService
    {
       
        Task<SummonerDto> UpdateSummonerAsync(string puuid);

       
        Task<SummonerDto> GetSummonerCachedAsync(string puuid);
    }
}
