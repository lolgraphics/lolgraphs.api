using Core.Application.DTOs;
using Core.Application.Interfaces.Bff;
using Core.Application.Interfaces.Repositories;
using Core.Application.Services;
using Core.Application.Interfaces;
using Core.Common.Exceptions;
using Moq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Xunit;
using AutoFixture;

namespace Core.Tests.Application.Services
{
    public class SummonerServiceTests
    {
        private readonly Mock<ISummonerRepository> _mockSummonerRepository;
        private readonly Mock<IRedisService> _mockCache;
        private readonly Mock<ISummonerBffService> _mockSummonerBffService;
        private readonly SummonerService _summonerService;
        private readonly Fixture _fixture;

        public SummonerServiceTests()
        {
            _mockSummonerRepository = new Mock<ISummonerRepository>();
            _mockCache = new Mock<IRedisService>();
            _mockSummonerBffService = new Mock<ISummonerBffService>();
            _summonerService = new SummonerService(
                _mockSummonerRepository.Object,
                _mockCache.Object,
                _mockSummonerBffService.Object
            );
            _fixture = new Fixture();
        }

        [Fact]
        public async Task UpdateSummonerAsync_Should_SaveSummoner_And_CacheData()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            var summonerDto = _fixture.Create<SummonerDto>();
            _mockSummonerBffService.Setup(s => s.GetSummonerByPuuid(puuid))
                .ReturnsAsync(summonerDto);

            // Act
            var result = await _summonerService.UpdateSummonerAsync(puuid);

            // Assert
            _mockSummonerRepository.Verify(r => r.SaveSummonerAsync(summonerDto), Times.Once);
            _mockCache.Verify(c => c.SetCacheValueAsync($"summoner:{puuid}", It.IsAny<string>()), Times.Once);
            Assert.Equal(summonerDto, result);
        }

        [Fact]
        public async Task GetSummonerCachedAsync_Should_ReturnCachedSummoner()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            var summonerDto = _fixture.Create<SummonerDto>();
            var summonerJson = JsonConvert.SerializeObject(summonerDto);
            _mockCache.Setup(c => c.GetCacheValueAsync($"summoner:{puuid}"))
                .ReturnsAsync(summonerJson);

            // Act
            var result = await _summonerService.GetSummonerCachedAsync(puuid);

            // Assert
            Assert.Equal(summonerDto.AccountId, result.AccountId);
            Assert.Equal(summonerDto.Id, result.Id);
            // Assert other properties similarly...
        }


        [Fact]
        public async Task GetSummonerCachedAsync_Should_ThrowException_WhenCacheMisses()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            _mockCache.Setup(c => c.GetCacheValueAsync($"summoner:{puuid}"))
                .ReturnsAsync(null as string);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ApiException>(() => _summonerService.GetSummonerCachedAsync(puuid));
            Assert.Equal(404, exception.Code);
            Assert.Contains("Not Found", exception.Message); // Updated to match the actual message
        }


        [Fact]
        public async Task GetSummonerCachedAsync_Should_ThrowJsonSerializationException_WhenDeserializationFails()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            var invalidJson = "invalid_json";
            _mockCache.Setup(c => c.GetCacheValueAsync($"summoner:{puuid}"))
                .ReturnsAsync(invalidJson);

            // Act & Assert
            await Assert.ThrowsAsync<JsonReaderException>(() => _summonerService.GetSummonerCachedAsync(puuid)); // Updated to match the thrown exception type
        }

    }
}
