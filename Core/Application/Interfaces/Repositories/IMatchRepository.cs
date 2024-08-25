using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces.Repositories
{
    public interface IMatchRepository
    {
        Task SaveMatchAsync(MatchDto matchDto);

        Task<MatchDto> GetLastMatchPlayedAsync(string puuid);

        Task SaveInfoMatchAsync(InfoMatchDto infoMatchDto);
    }
}
