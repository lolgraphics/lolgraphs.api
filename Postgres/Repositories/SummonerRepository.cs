using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Interfaces.Repositories;
using Postgres.Configuration;
using Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace Postgres.Repositories
{
    public class SummonerRepository(PostgresDbContext context, IMapper mapper) : ISummonerRepository
    {
        private readonly PostgresDbContext _dbContext = context;
        private readonly IMapper _mapper = mapper;

        public async Task<SummonerDto> GetSummonerAsync(string puuid)
        {
            var summonerModel = await _dbContext.Summoners
                .FirstOrDefaultAsync(s => s.Puuid == puuid); 
            return _mapper.Map<SummonerDto>(summonerModel);
        }

        public async Task SaveSummonerAsync(SummonerDto summoner)
        {
            var summonerModel = _mapper.Map<SummonerModel>(summoner);

            var existingSummoner = await _dbContext.Summoners
                .FirstOrDefaultAsync(s => s.Puuid == summonerModel.Puuid);

            if (existingSummoner == null)
            {
                await _dbContext.Summoners.AddAsync(summonerModel);
            }
            else
            {
                _dbContext.Entry(existingSummoner).CurrentValues.SetValues(summonerModel); 
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
