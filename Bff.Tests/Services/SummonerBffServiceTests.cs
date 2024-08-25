using AutoFixture;
using Bff.Services;
using Core.Application.DTOs;
using Core.Common.Exceptions;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Bff.Tests.Services
{
    public class SummonerBffServiceTests
    {
        private readonly MockRepository _mockRepository;
        private readonly Mock<IHttpClientFactory> _mockHttpClientFactory;
        private readonly Fixture _fixture;

        public SummonerBffServiceTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockHttpClientFactory = _mockRepository.Create<IHttpClientFactory>();
            _fixture = new Fixture();
        }

        private SummonerBffService CreateService()
        {
            return new SummonerBffService(_mockHttpClientFactory.Object);
        }

        private static Mock<HttpMessageHandler> SetupMockHttpClient(string jsonResponse, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            var mockHttpMessageHandler = new Mock<HttpMessageHandler>(MockBehavior.Strict);

            mockHttpMessageHandler
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = statusCode,
                    Content = new StringContent(jsonResponse)
                });

            return mockHttpMessageHandler;
        }

        [Fact]
        public async Task GetAccountDataAsync_ReturnsAccountDto_WhenResponseIsValid()
        {
            // Arrange
            var accountDto = _fixture.Create<AccountDto>();
            var jsonResponse = JsonConvert.SerializeObject(accountDto);
            var mockHandler = SetupMockHttpClient(jsonResponse);
            var httpClient = new HttpClient(mockHandler.Object) { BaseAddress = new System.Uri("http://localhost") };

            _mockHttpClientFactory.Setup(f => f.CreateClient("AmericasApi")).Returns(httpClient);
            _mockHttpClientFactory.Setup(f => f.CreateClient("RiotApiBr1")).Returns(httpClient); // Add setup for "RiotApiBr1"

            var service = CreateService();

            // Act
            var result = await service.GetAccountDataAsync("someName");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(accountDto.Puuid, result.Puuid);
        }

        [Fact]
        public async Task GetAccountDataAsync_ThrowsApiException_WhenResponseIsInvalid()
        {
            // Arrange
            var invalidJsonResponse = "Invalid JSON";
            var mockHandler = SetupMockHttpClient(invalidJsonResponse);
            var httpClient = new HttpClient(mockHandler.Object) { BaseAddress = new System.Uri("http://localhost") };

            _mockHttpClientFactory.Setup(f => f.CreateClient("AmericasApi")).Returns(httpClient);
            _mockHttpClientFactory.Setup(f => f.CreateClient("RiotApiBr1")).Returns(httpClient);

            var service = CreateService();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<JsonReaderException>(() => service.GetAccountDataAsync("someName"));

            // Optionally, you can check if the exception message contains details about the invalid JSON
            Assert.Contains("Error parsing", exception.Message);
        }

        [Fact]
        public async Task GetSummonerByPuuid_ReturnsSummonerDto_WhenResponseIsValid()
        {
            // Arrange
            var summonerDto = _fixture.Create<SummonerDto>();
            var jsonResponse = JsonConvert.SerializeObject(summonerDto);
            var mockHandler = SetupMockHttpClient(jsonResponse);
            var httpClient = new HttpClient(mockHandler.Object) { BaseAddress = new System.Uri("http://localhost") };

            _mockHttpClientFactory.Setup(f => f.CreateClient("AmericasApi")).Returns(httpClient);
            _mockHttpClientFactory.Setup(f => f.CreateClient("RiotApiBr1")).Returns(httpClient);

            var service = CreateService();

            // Act
            var result = await service.GetSummonerByPuuid("somePuuid");

            // Assert
            Assert.NotNull(result);
            Assert.Equal(summonerDto.Puuid, result.Puuid);
        }

        [Fact]
        public async Task GetSummonerByPuuid_ThrowsApiException_WhenResponseIsInvalid()
        {
            // Arrange
            var invalidJsonResponse = "Invalid JSON";
            var mockHandler = SetupMockHttpClient(invalidJsonResponse);
            var httpClient = new HttpClient(mockHandler.Object) { BaseAddress = new System.Uri("http://localhost") };

            _mockHttpClientFactory.Setup(f => f.CreateClient("AmericasApi")).Returns(httpClient);
            _mockHttpClientFactory.Setup(f => f.CreateClient("RiotApiBr1")).Returns(httpClient); // Add setup for "RiotApiBr1"

            var service = CreateService();

            // Act & Assert
            var exception = await Assert.ThrowsAsync<JsonReaderException>(() => service.GetSummonerByPuuid("somePuuid"));
            // Optionally, you can check if the exception message contains details about the invalid JSON
            Assert.Contains("Error parsing", exception.Message);
        }
    }
}
