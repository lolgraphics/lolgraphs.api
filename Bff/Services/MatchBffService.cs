using Bff.Helpers;
using Newtonsoft.Json;
using Core.Common.Exceptions;
using Core.Application.Interfaces.Bff;
using Core.Application.DTOs.MatchDtos;
using Core.Application.DTOs;
using Core.Application.DTOs.MatchDtos.InfoMatch;

namespace Bff.Services
{
    public class MatchBffService(IHttpClientFactory httpClientFactory) : IMatchBffService
    {
        private readonly HttpClient _americasApi = httpClientFactory.CreateClient("AmericasApi");

        public async Task<List<string>> GetMatchByPuuidAsync(string puuid, long startTime, long endTime)
        {
            var response = await _americasApi.GetAsync($"lol/match/v5/matches/by-puuid/{puuid}/ids?startTime={startTime}&endTime={endTime}&count=100");

            return await HttpHelper.HandleHttpResponseAsync(
                response,
                async () =>
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<string>>(content) 
                                ?? throw new MatchDataException("Failed to deserialize list of match IDs.", content);
                    return result;
                }
            );
        }

        public async Task<InfoMatchDto> GetMatchInfoByMatchIdAsync(string matchId)
        {
            var response = await _americasApi.GetAsync($"lol/match/v5/matches/{matchId}");

            return await HttpHelper.HandleHttpResponseAsync(
                response,
                async () =>
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<InfoMatchDto>(content) 
                                ?? throw new MatchDataException("Failed to deserialize match info.", content);
                    return result;
                }
            );
        }
    }
}
