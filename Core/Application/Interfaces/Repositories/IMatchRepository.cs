using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces.Repositories
{
    public interface IMatchRepository
    {
        Task SaveMatchIdAsync(MatchDto matchDto);

        Task<MatchDto> GetLastMatchPlayedAsync(string puuid);

        Task SaveInfoMatchAsync(InfoMatchDto infoMatchDto);

        Task SaveMatchTimeLineInfoMatchAsync(InfoMatchTimeLineDTO infoMatchDTO);
    }
}
