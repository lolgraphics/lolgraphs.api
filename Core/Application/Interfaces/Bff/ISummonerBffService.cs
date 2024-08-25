using Core.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces.Bff
{
    public interface ISummonerBffService
    {
        Task<AccountDto> GetAccountDataAsync(string name);

        Task<SummonerDto> GetSummonerByPuuid(string puuid);
    }
}
