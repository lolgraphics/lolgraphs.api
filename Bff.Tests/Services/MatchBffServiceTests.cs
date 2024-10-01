using AutoFixture;
using Moq;
using FluentAssertions;
using System.Net;
using Bff.Services;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Newtonsoft.Json;
using Moq.Protected;

namespace Bff.Tests.Services
{
    public class MatchBffServiceTests
    {
        private readonly Fixture _fixture;
        private readonly Mock<IHttpClientFactory> _httpClientFactoryMock;
        private readonly Mock<HttpMessageHandler> _httpMessageHandlerMock;

        public MatchBffServiceTests()
        {
            _fixture = new Fixture();
            _httpClientFactoryMock = new Mock<IHttpClientFactory>();
            _httpMessageHandlerMock = new Mock<HttpMessageHandler>();
        }

        [Fact]
        public async Task GetMatchByPuuidAsync_ValidResponse_ReturnsMatchIds()
        {
            // Arrange
            var matchIds = _fixture.Create<List<string>>();
            var httpClient = CreateHttpClientMock(JsonConvert.SerializeObject(matchIds));
            _httpClientFactoryMock.Setup(factory => factory.CreateClient("AmericasApi")).Returns(httpClient);
            var service = new MatchBffService(_httpClientFactoryMock.Object);
            string puuid = _fixture.Create<string>();
            long startTime = _fixture.Create<long>();
            long endTime = _fixture.Create<long>();

            // Act
            var result = await service.GetMatchByPuuidAsync(puuid, startTime, endTime);

            // Assert
            result.Should().BeEquivalentTo(matchIds);  // Using FluentAssertions
        }

        [Fact]
        public async Task GetMatchInfoByMatchIdAsync_ValidResponse_ReturnsMatchInfo()
        {
            // Arrange
            var matchInfo = _fixture.Create<InfoMatchDTO>();
            var httpClient = CreateHttpClientMock(JsonConvert.SerializeObject(matchInfo));
            _httpClientFactoryMock.Setup(factory => factory.CreateClient("AmericasApi")).Returns(httpClient);
            var service = new MatchBffService(_httpClientFactoryMock.Object);
            string matchId = _fixture.Create<string>();

            // Act
            var result = await service.GetMatchInfoByMatchIdAsync(matchId);

            // Assert
            result.Should().BeEquivalentTo(matchInfo);  // Using FluentAssertions
        }

        private HttpClient CreateHttpClientMock(string responseContent)
        {
            _httpMessageHandlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(responseContent)
                });

            return new HttpClient(_httpMessageHandlerMock.Object)
            {
                BaseAddress = new Uri("https://mockapi.test/")
            };
        }
    }
}
