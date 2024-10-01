using AutoMapper;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;
using Core.Application.DTOs.MatchDTOs;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.Interfaces.Repositories;
using Core.Common.Exceptions;
using Mongo.Configuration;
using Mongo.Models;
using Mongo.Models.InfoMatch;
using MongoDB.Bson;
using MongoDB.Driver;
using Mongo.Models.InfoMatchTimeLine;

namespace Mongo.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        private readonly IMongoCollection<MatchModel> _matches;
        private readonly IMongoCollection<InfoMatchModel> _infoMatches;
        private readonly IMongoCollection<InfoMatchTimeLineModel> _infoMatchesTimeLines;
        private readonly IMapper _mapper;

        public MatchRepository(MongoDbContext context, IMapper mapper)
        {
            _matches = context.Matches;
            _infoMatches = context.InfoMatches;
            _infoMatchesTimeLines = context.InfoMatchesTimeLines;
            _mapper = mapper;
        }

        public async Task SaveMatchIdAsync(MatchDTO matchDTO)
        {
            try
            {
                var matchModel = _mapper.Map<MatchModel>(matchDTO);
                await _matches.InsertOneAsync(matchModel);
            }
            catch (BsonSerializationException ex)
            {
                throw new MatchDataException("Error serializing match data.", ex.Message);
            }
        }

        public async Task<List<MatchDTO>> GetAll(string puuid)
        {
            var filter = Builders<MatchModel>.Filter.Eq(m => m.Puuid, puuid);

            var matches = await _matches.Find(filter).ToListAsync();

            return _mapper.Map<List<MatchDTO>>(matches);
        }

        public async Task<MatchDTO> GetLastMatchPlayedAsync(string puuid)
        {

            var filter = Builders<MatchModel>.Filter.Eq(m => m.Puuid, puuid);
            var sort = Builders<MatchModel>.Sort.Descending(m => m.TimeLastMatchPlayed);

            var lastMatch = await _matches
                .Find(filter)
                .Sort(sort)
                .FirstOrDefaultAsync();

            Console.WriteLine($"Retrieved Match ID: {lastMatch?.Id}, Time: {lastMatch?.TimeLastMatchPlayed}");

            return _mapper.Map<MatchDTO>(lastMatch);
        }

        public async Task SaveInfoMatchAsync(InfoMatchDTO infoMatchDTO)
        {
            try
            {
                var infoMatchModel = _mapper.Map<InfoMatchModel>(infoMatchDTO);
                await _infoMatches.InsertOneAsync(infoMatchModel);
            }
            catch (BsonSerializationException ex)
            {
                throw new MatchDataException("Error serializing match info data.", ex.Message);
            }
        }

        public async Task SaveMatchTimeLineInfoMatchAsync(InfoMatchTimeLineDTO infoMatchDTO)
        {
            try
            {
                var infoMatchModel = _mapper.Map<InfoMatchTimeLineModel>(infoMatchDTO);
                await _infoMatchesTimeLines.InsertOneAsync(infoMatchModel);
            }
            catch (BsonSerializationException ex)
            {
                throw new MatchDataException("Error serializing match info data.", ex.Message);
            }
        }
    }
}
