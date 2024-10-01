using Bff.Services;
using Core.Application.DTOs;
using Core.Application.DTOs.ApiDTOs;
using Core.Application.Interfaces;
using Core.Application.Interfaces.Bff;
using Core.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/summoner/[controller]")]
    public class SummonerController(ISummonerService summonerService) : ControllerBase
    {
        private readonly ISummonerService _summonerService = summonerService;

        [HttpGet("ByPuuid")]
        public async Task<IActionResult> GetSummonerByPuuid(string puuid)
        {
            var summonerInfos = await _summonerService.GetSummonerCachedAsync(puuid);
            return Ok(new ApiResponse(200, "Success", summonerInfos));
        }
        [HttpGet("UpadateByPuuid")]
        public async Task<IActionResult> UpdateSummonerByPuuid(string puuid)
        {
            var summonerInfos = await _summonerService.UpdateSummonerAsync(puuid);
            return Ok(new ApiResponse(200, "Success", summonerInfos));
        }
    }
}
