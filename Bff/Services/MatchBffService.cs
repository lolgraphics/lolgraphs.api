using Bff.Helpers;
using Newtonsoft.Json;
using Core.Common.Exceptions;
using Core.Application.Interfaces.Bff;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;


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

        public async Task<InfoMatchTimeLineDTO> GetMatchTimeLineByMatchIdAsync(string matchId)
        {
            var response = await _americasApi.GetAsync($"lol/match/v5/matches/{matchId}/timeline");

            return await HttpHelper.HandleHttpResponseAsync(
                response,
                async () =>
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<InfoMatchTimeLineDTO>(content)
                                ?? throw new MatchDataException("Failed to deserialize match info.", content);
                    return result;
                }
            );
        }
        public async Task<InfoMatchDTO> GetMatchInfoByMatchIdAsync(string matchId)
        {
            var response = await _americasApi.GetAsync($"lol/match/v5/matches/{matchId}");

            return await HttpHelper.HandleHttpResponseAsync(
                response,
                async () =>
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<InfoMatchDTO>(content) 
                                ?? throw new MatchDataException("Failed to deserialize match info.", content);
                    return result;
                }
            );
        }
    }
}
