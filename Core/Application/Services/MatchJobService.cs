using Core.Application.DTOs.MatchDTOs;
using Core.Application.Interfaces.Bff;
using Core.Application.Interfaces.Repositories;
using Core.Application.Interfaces;
using Core.Application.DTOs.MatchDTOs.InfoMatch;
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

        private static long GetStartTime(MatchDTO lastMatchPlayed)
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

            var matches = await _matchRepository.GetAll(puuid);
            var matchIds = matches.Select(m => m.Id).ToList();

                //_matchBffService.GetMatchByPuuidAsync(puuid, startTime, endTime);

            await GetMatchAndTimeLineInfos(matchIds, puuid);

        }

        private async Task GetMatchAndTimeLineInfos(List<string> matchIds, string puuid)
        {
            var reversedIds = matchIds.AsEnumerable().Reverse();

            foreach (var matchId in reversedIds)
            {
                var infoMatch = await _matchBffService.GetMatchInfoByMatchIdAsync(matchId);
                await Task.Delay(1200); // Consider removing or adjusting delay as needed
                var infoMatchTimeLine = await _matchBffService.GetMatchTimeLineByMatchIdAsync(matchId);

                await SaveMatchDataAsync(infoMatch, infoMatchTimeLine, puuid);
            }

            //var semaphore = new SemaphoreSlim(25);
            //var tasks = new List<Task>();

            //foreach (var matchId in matchIds.AsEnumerable().Reverse())
            //{
            //    await semaphore.WaitAsync();

            //    tasks.Add(Task.Run(async () =>
            //    {
            //        try
            //        {
            //            var infoMatch = await _matchBffService.GetMatchInfoByMatchIdAsync(matchId);
            //            await SaveMatchInfoAsync(infoMatch, puuid);
            //            await Task.Delay(1200);
            //        }
            //        finally
            //        {
            //            semaphore.Release();
            //        }
            //    }));
            //}

            //await Task.WhenAll(tasks);
        }
        private async Task SaveMatchDataAsync(InfoMatchDTO infoMatch, InfoMatchTimeLineDTO infoMatchTimeLine, string puuid)
        {
            long timestampInSeconds = infoMatch.Info.GameEndTimestamp / 1000;
            string formattedDate = FormatDateTimeByPlatformId(infoMatch.Info.PlatformId, timestampInSeconds);

            // await _matchRepository.SaveMatchIdAsync(new MatchDTO(infoMatch.Metadata.MatchId, puuid, timestampInSeconds, formattedDate));
            await _matchRepository.SaveInfoMatchAsync(infoMatch);
            await _matchRepository.SaveMatchTimeLineInfoMatchAsync(infoMatchTimeLine);
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
