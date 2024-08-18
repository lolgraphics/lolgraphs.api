using AutoMapper;
using Core.Application.DTOs;
using Core.Application.Interfaces.Repositories;
using Infrastructure.Configuration;
using Mongo.Configuration;
using Mongo.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mongo.Repositories
{
    public class SummonerRepository(MongoDbContext context, IMapper mapper) : ISummonerRepository
    {
        private readonly IMongoCollection<SummonerModel> _summoner = context.Summoners;

        public async Task<SummonerDto> GetSummonerAsync(string puuid)
        {
            var summonerModel = await _summoner.Find(s => s.Puuid == puuid).FirstOrDefaultAsync();
            return mapper.Map<SummonerDto>(summonerModel);
        }

        public async Task SaveSummonerAsync(SummonerDto summoner)
        {

            var summonerModel = mapper.Map<SummonerModel>(summoner);

            var filter = Builders<SummonerModel>.Filter.Eq(s => s.Id, summonerModel.Id);
            var updateOptions = new ReplaceOptions { IsUpsert = true };

            await _summoner.ReplaceOneAsync(filter, summonerModel, updateOptions);
        }
    }
}
