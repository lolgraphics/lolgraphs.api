using AutoMapper;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOs;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.Interfaces.Repositories;
using Core.Common.Exceptions;
using Microsoft.EntityFrameworkCore;
using Postgres.Configuration;
using Postgres.Models.InfoMatch;
using Postgres.Models.InfoMatchTimeLine;
using Postgres.Models.Match;

namespace Postgres.Repositories
{
    public class MatchRepository(PostgresDbContext context, IMapper mapper) : IMatchRepository
    {
        private readonly PostgresDbContext _dbContext = context;
        private readonly IMapper _mapper = mapper;

        // Save Match
        public async Task SaveMatchIdAsync(MatchDto matchDTO)
        {
            try
            {
                var matchModel = _mapper.Map<MatchModel>(matchDTO);
                _dbContext.Matches.Add(matchModel);
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new MatchDataException("Error saving match data.", ex.Message);
            }
        }

        // Get All Matches by PUUID
        public async Task<List<MatchDto>> GetAll(string puuid)
        {
            var matches = await _dbContext.Matches
                .Where(m => m.Puuid == puuid)
                .ToListAsync();

            return _mapper.Map<List<MatchDto>>(matches);
        }

        // Get Last Match Played by PUUID
        public async Task<MatchDto> GetLastMatchPlayedAsync(string puuid)
        {
            var lastMatch = await _dbContext.Matches
                .Where(m => m.Puuid == puuid)
                .OrderByDescending(m => m.TimeLastMatchPlayed)
                .FirstOrDefaultAsync();

            return _mapper.Map<MatchDto>(lastMatch);
        }

        // Save Info Match
        public async Task SaveInfoMatchAsync(InfoMatchDto infoMatchDTO)
        {
            try
            {
                var infoMatchModel = _mapper.Map<InfoMatchModel>(infoMatchDTO);
                _dbContext.InfoMatches.Add(infoMatchModel);
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new MatchDataException("Error saving match info data.", ex.Message);
            }
        }

        // Save Match Timeline Info
        public async Task SaveMatchTimeLineInfoMatchAsync(InfoMatchTimeLineDTO infoMatchDTO)
        {
            try
            {
                var infoMatchTimelineModel = _mapper.Map<InfoMatchTimeLineModel>(infoMatchDTO);
                _dbContext.InfoMatchTimeLines.Add(infoMatchTimelineModel);
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new MatchDataException("Error saving match timeline data.", ex.Message);
            }
        }
    }
}
