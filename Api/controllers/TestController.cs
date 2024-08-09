using Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private readonly IProducer kafkaProducer;
    private readonly ICache redisService;

    public TestController(IProducer producerService, ICache redisService)
    {
        this.redisService = redisService;
        this.kafkaProducer = producerService;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddMatches(string message)
    {
        await kafkaProducer.ProduceAsync(message);
        return Ok();
    }

    [HttpGet("{key}")]
    public async Task<IActionResult> GetCacheValue(string key)
    {
        var value = await redisService.GetCacheValueAsync(key);
        if (value == null)
        {
            return NotFound();
        }
        return Ok(value);
    }

    [HttpPost("cache")]
    public async Task<IActionResult> SetCacheValue(string key, [FromBody] string value)
    {
        await redisService.SetCacheValueAsync(key, value);
        return Ok();
    }
}
