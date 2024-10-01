using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Interfaces.Repositories;
using Mongo.Configuration;
using Mongo.Models;
using MongoDB.Driver;

namespace Mongo.Repositories
{
    public class SummonerRepository(MongoDbContext context, IMapper mapper) : ISummonerRepository
    {
        private readonly IMongoCollection<SummonerModel> _summoner = context.Summoners;

        public async Task<SummonerDTO> GetSummonerAsync(string puuid)
        {
            var summonerModel = await _summoner.Find(s => s.Puuid == puuid).FirstOrDefaultAsync();
            return mapper.Map<SummonerDTO>(summonerModel);
        }

        public async Task SaveSummonerAsync(SummonerDTO summoner)
        {

            var summonerModel = mapper.Map<SummonerModel>(summoner);

            var filter = Builders<SummonerModel>.Filter.Eq(s => s.Id, summonerModel.Id);
            var updateOptions = new ReplaceOptions { IsUpsert = true };

            await _summoner.ReplaceOneAsync(filter, summonerModel, updateOptions);
        }
    }
}
