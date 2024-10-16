using Core.Application.DTOs.MatchDtos;
using Core.Application.Interfaces.Bff;
using Core.Application.Interfaces.Repositories;
using Core.Application.Interfaces;
using Core.Application.DTOs.MatchDtos.InfoMatch;
using Core.Common.Enum;
using Core.Application.DTOs.MatchDtos.infoMatchTimeLineDTO;

namespace Core.Application.Services
{
    public class MatchJobService(IMatchBffService matchBffService, IMatchRepository matchRepository) : IMatchJobService
    {
        private readonly IMatchBffService _matchBffService = matchBffService;
        private readonly IMatchRepository _matchRepository = matchRepository;

        public async Task ProcessMatchesAsync(string puuid)
        {
            var lastMatchPlayed = await _matchRepository.GetLastMatchPlayedAsync(puuid);
            long startTime = GetStartTime(lastMatchPlayed);
            long endTime = GetCurrentUnixTimeSeconds();

            if (IsTimeDifferenceSignificant(startTime))
            {
                await ProcessMatchesInIntervalsAsync(puuid, startTime, endTime);
            }
            else
            {
                await ProcessMatchesAsync(puuid, startTime, endTime);
            }
        }

        private static long GetStartTime(MatchDto lastMatchPlayed)
        {
            return lastMatchPlayed != null ? lastMatchPlayed.TimeLastMatchPlayed + (long)MatchTime.TimeDifferenceToNextMatch 
                                            : (long)MatchTime.DefaultStartTime;
        }

        private static long GetCurrentUnixTimeSeconds() => new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();

        private static bool IsTimeDifferenceSignificant(long startTime)
        {
            DateTime lastMatchDate = DateTimeOffset.FromUnixTimeSeconds(startTime).DateTime;
            TimeSpan timeDifference = DateTime.UtcNow - lastMatchDate;
            return timeDifference.TotalDays >= (long)MatchTime.TotalDays;
        }

        public async Task ProcessMatchesInIntervalsAsync(string puuid, long startTime, long endTime)
        {
            while (startTime < endTime)
            {
                long nextStartTime = GetNextStartTime(startTime);
                await ProcessMatchesAsync(puuid, startTime, nextStartTime);
                startTime = nextStartTime;
            }
        }

        private static long GetNextStartTime(long startTime) =>
                new DateTimeOffset(DateTimeOffset.FromUnixTimeSeconds(startTime).DateTime.AddDays(7)).ToUnixTimeSeconds();

        private async Task ProcessMatchesAsync(string puuid, long startTime, long endTime)
        {

            var matchIds = await _matchBffService.GetMatchByPuuidAsync(puuid, startTime, endTime);
            await Task.Delay(1200);
            await GetMatchAndTimeLineInfos(matchIds, puuid);
            
          

        }

        private async Task GetMatchAndTimeLineInfos(List<string> matchIds, string puuid)
        {
            foreach (var matchId in matchIds.AsEnumerable().Reverse())
            {
                var infoMatch = await _matchBffService.GetMatchInfoByMatchIdAsync(matchId);
                await Task.Delay(1200);
                var infoMatchTimeLine = await _matchBffService.SaveMatchTimeLineInfoMatchAsync(matchId);

                infoMatchTimeLine.Puuid = puuid;
                infoMatchTimeLine.MatchId = matchId;

                infoMatch.Puuid = puuid;
                infoMatch.MatchId = matchId;

                await SaveMatchDataAsync(infoMatch, infoMatchTimeLine, puuid);
            }
        }

        private async Task SaveMatchDataAsync(InfoMatchDto infoMatch, InfoMatchTimeLineDTO infoMatchTimeLine, string puuid)
        {
            long timestampInSeconds = infoMatch.Info.GameEndTimestamp / 1000;
            string formattedDate = FormatDateTimeByPlatformId(infoMatch.Info.PlatformId, timestampInSeconds);

            await _matchRepository.SaveMatchIdAsync(new MatchDto(infoMatch.Metadata.MatchId, puuid, timestampInSeconds, formattedDate));
            await _matchRepository.SaveInfoMatchAsync(infoMatch);
        }

        private static string FormatDateTimeByPlatformId(string platformId, long timestampInSeconds)
        {
            DateTimeOffset utcDateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(timestampInSeconds);
            if (platformId == "BR1")
            {
                TimeZoneInfo brazilianTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
                return TimeZoneInfo.ConvertTime(utcDateTimeOffset.UtcDateTime, brazilianTimeZone).ToString();
            }
            return utcDateTimeOffset.UtcDateTime.ToString();
        }
    }
}
