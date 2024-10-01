using System.Linq;
using System.Threading;
using AutoFixture;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
using Core.Application.DTOs.MatchDTOs;
using Core.Application.Interfaces.Bff;
using Core.Application.Interfaces.Repositories;
using Core.Application.Services;
using Core.Common.Enum;
using Moq;

namespace Core.Tests.Application.Services
{
    public class MatchJobServiceTests
    {
        private readonly Mock<IMatchBffService> _mockMatchBffService;
        private readonly Mock<IMatchRepository> _mockMatchRepository;
        private readonly MatchJobService _matchJobService;
        private readonly Fixture _fixture;

        public MatchJobServiceTests()
        {
            _mockMatchBffService = new Mock<IMatchBffService>();
            _mockMatchRepository = new Mock<IMatchRepository>();
            _matchJobService = new MatchJobService(_mockMatchBffService.Object, _mockMatchRepository.Object);
            _fixture = new Fixture();
        }

        [Fact]
        public async Task ProcessMatchesAsync_ShouldProcessMatches_WhenTimeDifferenceIsSignificant()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            var lastMatch = _fixture.Build<MatchDTO>()
                .With(m => m.TimeLastMatchPlayed, DateTimeOffset.UtcNow.AddDays(-10).ToUnixTimeSeconds())
                .Create();

            _mockMatchRepository.Setup(repo => repo.GetLastMatchPlayedAsync(puuid))
                .ReturnsAsync(lastMatch);

            _mockMatchBffService.Setup(bff => bff.GetMatchByPuuidAsync(puuid, It.IsAny<long>(), It.IsAny<long>()))
                .ReturnsAsync(new List<string> { "match1", "match2" });

            _mockMatchBffService.Setup(bff => bff.GetMatchInfoByMatchIdAsync(It.IsAny<string>()))
                .ReturnsAsync(_fixture.Create<InfoMatchDTO>());

            // Act
            await _matchJobService.ProcessMatchesAsync(puuid);

            // Assert
            _mockMatchRepository.Verify(repo => repo.GetLastMatchPlayedAsync(puuid), Times.Once);
            _mockMatchBffService.Verify(bff => bff.GetMatchByPuuidAsync(puuid, It.IsAny<long>(), It.IsAny<long>()), Times.AtLeastOnce);
            _mockMatchBffService.Verify(bff => bff.GetMatchInfoByMatchIdAsync(It.IsAny<string>()), Times.AtLeastOnce);
            _mockMatchRepository.Verify(repo => repo.SaveMatchIdAsync(It.IsAny<MatchDTO>()), Times.AtLeastOnce);
            _mockMatchRepository.Verify(repo => repo.SaveInfoMatchAsync(It.IsAny<InfoMatchDTO>()), Times.AtLeastOnce);
        }

        [Fact]
        public async Task ProcessMatchesAsync_ShouldNotProcessInIntervals_WhenTimeDifferenceIsNotSignificant()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            var lastMatch = _fixture.Build<MatchDTO>()
                .With(m => m.TimeLastMatchPlayed, DateTimeOffset.UtcNow.AddDays(-1).ToUnixTimeSeconds())
                .Create();

            _mockMatchRepository.Setup(repo => repo.GetLastMatchPlayedAsync(puuid))
                .ReturnsAsync(lastMatch);

            _mockMatchBffService.Setup(bff => bff.GetMatchByPuuidAsync(puuid, It.IsAny<long>(), It.IsAny<long>()))
                .ReturnsAsync(new List<string> { "match1", "match2" });

            _mockMatchBffService.Setup(bff => bff.GetMatchInfoByMatchIdAsync(It.IsAny<string>()))
                .ReturnsAsync(_fixture.Create<InfoMatchDTO>());

            // Act
            await _matchJobService.ProcessMatchesAsync(puuid);

            // Assert
            _mockMatchRepository.Verify(repo => repo.GetLastMatchPlayedAsync(puuid), Times.Once);
            _mockMatchBffService.Verify(bff => bff.GetMatchByPuuidAsync(puuid, It.IsAny<long>(), It.IsAny<long>()), Times.Once);
            _mockMatchBffService.Verify(bff => bff.GetMatchInfoByMatchIdAsync(It.IsAny<string>()), Times.AtLeastOnce);
            _mockMatchRepository.Verify(repo => repo.SaveMatchIdAsync(It.IsAny<MatchDTO>()), Times.AtLeastOnce);
            _mockMatchRepository.Verify(repo => repo.SaveInfoMatchAsync(It.IsAny<InfoMatchDTO>()), Times.AtLeastOnce);
        }

 

        [Fact]
        public async Task ProcessMatchesInIntervalsAsync_ShouldProcessAllIntervals()
        {
            // Arrange
            var puuid = _fixture.Create<string>();
            long startTime = new DateTimeOffset(DateTime.UtcNow.AddDays(-30)).ToUnixTimeSeconds();
            long endTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

            _mockMatchBffService.Setup(bff => bff.GetMatchByPuuidAsync(puuid, It.IsAny<long>(), It.IsAny<long>()))
                .ReturnsAsync(new List<string> { "match1", "match2" });

            _mockMatchBffService.Setup(bff => bff.GetMatchInfoByMatchIdAsync(It.IsAny<string>()))
                .ReturnsAsync(_fixture.Create<InfoMatchDTO>());

            // Act
            await _matchJobService.ProcessMatchesInIntervalsAsync(puuid, startTime, endTime);

            // Assert
            _mockMatchBffService.Verify(bff => bff.GetMatchByPuuidAsync(puuid, It.IsAny<long>(), It.IsAny<long>()), Times.AtLeast(4));
            _mockMatchRepository.Verify(repo => repo.SaveMatchIdAsync(It.IsAny<MatchDTO>()), Times.AtLeastOnce);
            _mockMatchRepository.Verify(repo => repo.SaveInfoMatchAsync(It.IsAny<InfoMatchDTO>()), Times.AtLeastOnce);
        }
    }
}
