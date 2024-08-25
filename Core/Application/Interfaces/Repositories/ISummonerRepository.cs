using Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces.Repositories
{
    public interface ISummonerRepository
    {
        Task<SummonerDto> GetSummonerAsync(string puuid);
        Task SaveSummonerAsync(SummonerDto summoner);
    }
}
