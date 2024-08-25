
using Core.Application.DTOs.ApiDtos;
using Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers
{
    [ApiController]
    [Route("api/match/[controller]")]
    public class MatchController(IKafkaProducer messageQueueService) : ControllerBase
    {
        private readonly IKafkaProducer _messageQueueService = messageQueueService;

        [HttpGet("RefreshMatches")]
        public async Task<IActionResult> GetMatch(string puuid)
        {
            await _messageQueueService.EnqueueMessageAsync(puuid);
            return Ok(new ApiResponse(200, "Success", "Request submitted to refresh matches"));
        }
    }
}
