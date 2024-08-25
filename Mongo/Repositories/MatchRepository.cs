using AutoMapper;
using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using Core.Application.Interfaces.Repositories;
using Core.Common.Exceptions;
using Infrastructure.Configuration;
using Mongo.Configuration;
using Mongo.Models;
using Mongo.Models.InfoMatch;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Mongo.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly IMongoCollection<MatchModel> _matches;
        private readonly IMongoCollection<InfoMatchModel> _infoMatches;
        private readonly IMapper _mapper;

        public MatchRepository(MongoDbContext context, IMapper mapper)
        {
            _matches = context.Matches;
            _infoMatches = context.InfoMatches;
            _mapper = mapper;
        }

        public async Task SaveMatchAsync(MatchDto matchDto)
        {
            try
            {
                var matchModel = _mapper.Map<MatchModel>(matchDto);
                await _matches.InsertOneAsync(matchModel);
            }
            catch (BsonSerializationException ex)
            {
                throw new MatchDataException("Error serializing match data.", ex.Message);
            }
        }

        public async Task<MatchDto> GetLastMatchPlayedAsync(string puuid)
        {

            var filter = Builders<MatchModel>.Filter.Eq(m => m.Puuid, puuid);
            var sort = Builders<MatchModel>.Sort.Descending(m => m.TimeLastMatchPlayed);

            var lastMatch = await _matches
                .Find(filter)
                .Sort(sort)
                .FirstOrDefaultAsync();

            Console.WriteLine($"Retrieved Match ID: {lastMatch?.Id}, Time: {lastMatch?.TimeLastMatchPlayed}");

            return _mapper.Map<MatchDto>(lastMatch);
        }

        public async Task SaveInfoMatchAsync(InfoMatchDto infoMatchDto)
        {
            try
            {
                var infoMatchModel = _mapper.Map<InfoMatchModel>(infoMatchDto);
                await _infoMatches.InsertOneAsync(infoMatchModel);
            }
            catch (BsonSerializationException ex)
            {
                throw new MatchDataException("Error serializing match info data.", ex.Message);
            }
        }
    }
}
