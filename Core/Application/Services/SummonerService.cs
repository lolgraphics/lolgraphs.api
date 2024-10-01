using Core.Application.DTOs;
using Core.Application.Interfaces;
using Core.Application.Interfaces.Bff;
using Core.Application.Interfaces.Repositories;
using Core.Common.Exceptions;
using Newtonsoft.Json;

namespace Core.Application.Services
{
    public class SummonerService(ISummonerRepository summonerRepository, IRedisService cache, ISummonerBffService summonerBffService) : ISummonerService
    {
        private readonly ISummonerRepository _summonerRepository = summonerRepository;
        private readonly IRedisService _cache = cache;
        private readonly ISummonerBffService _summonerBffService = summonerBffService;
    
        public async Task<SummonerDTO> UpdateSummonerAsync(string puuid)
        {
            var summoner = await _summonerBffService.GetSummonerByPuuid(puuid);

            await _summonerRepository.SaveSummonerAsync(summoner);

            var summonerJson = JsonConvert.SerializeObject(summoner);

            var cacheKey = $"summoner:{puuid}";
            await _cache.SetCacheValueAsync(cacheKey, summonerJson);

            return summoner;
        }

        public async Task<SummonerDTO> GetSummonerCachedAsync(string puuid)
        {
            var cacheKey = $"summoner:{puuid}";
            var cachedSummoner = await  _cache.GetCacheValueAsync(cacheKey);

            return cachedSummoner == null
                ? throw new ApiException(404, "Not Found", $"Key not found: {cacheKey}")
                : JsonConvert.DeserializeObject<SummonerDTO>(cachedSummoner)
                ?? throw new JsonSerializationException("Failed to deserialize cached summoner.");
        }

    }
}
