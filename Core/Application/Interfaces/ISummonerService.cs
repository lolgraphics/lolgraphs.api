using Core.Application.DTOs;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
    public interface ISummonerService
    {
       
        Task<SummonerDTO> UpdateSummonerAsync(string puuid);

       
        Task<SummonerDTO> GetSummonerCachedAsync(string puuid);
    }
}
