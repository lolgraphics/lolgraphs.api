using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces.Bff
{
    public interface IMatchBffService
    {
        Task<List<string>> GetMatchByPuuidAsync(string puuid, long startTime, long endTime);
        Task<InfoMatchDto> GetMatchInfoByMatchIdAsync(string matchId);
    }
}
