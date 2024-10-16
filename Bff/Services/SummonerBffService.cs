﻿using Core.Application.DTOs;
using Core.Common.Exceptions;
using Newtonsoft.Json;
using Bff.Helpers;
using Core.Application.Interfaces.Bff;

namespace Bff.Services
{
    public class SummonerBffService(IHttpClientFactory httpClientFactory) : ISummonerBffService
    {
        private readonly HttpClient _americasApi = httpClientFactory.CreateClient("AmericasApi");
        private readonly HttpClient _riotApiBr1 = httpClientFactory.CreateClient("RiotApiBr1");

        public async Task<AccountDto> GetAccountDataAsync(string name)
        {
            var response = await _americasApi.GetAsync($"riot/account/v1/accounts/by-riot-id/{name}/BR1");

            return await HttpHelper.HandleHttpResponseAsync(
                response,
                async () =>
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<AccountDto>(content);

                    return result ?? throw new ApiException(500, "Failed to deserialize SummonerDto.", content);
                }
            );
        }

        public async Task<SummonerDto> GetSummonerByPuuid(string puuid)
        {
            var response = await _riotApiBr1.GetAsync($"summoner/v4/summoners/by-puuid/{puuid}");

            return await HttpHelper.HandleHttpResponseAsync(
                response,
                async () =>
                {
                    var content = await response.Content.ReadAsStringAsync(); 
                    var result = JsonConvert.DeserializeObject<SummonerDto>(content);

                    return result ?? throw new ApiException(500, "Failed to deserialize Summoner.", content);
                }
            );
        }
    }
}
