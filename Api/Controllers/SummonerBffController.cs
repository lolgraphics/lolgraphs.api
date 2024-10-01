using Bff.Services;
using Core.Application.DTOs.ApiDTOs;
using Core.Application.Interfaces.Bff;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/account/[controller]")]
    public class SummonerBffController(ISummonerBffService summonerBffService) : ControllerBase
    {
        private readonly ISummonerBffService _summonerBffService = summonerBffService;

        [HttpGet("byName")]
        public async Task<IActionResult> GetAccount(string name)
        {
            var account = await _summonerBffService.GetAccountDataAsync(name);
            return Ok(new ApiResponse(200, "Success", account));
        }
    }
}
