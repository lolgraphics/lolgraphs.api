using Lolgraphics.Core.addMatches;
using System.Text.RegularExpressions;

namespace Core.Services
{
    public class MatchService
    {
        private readonly IMatchesRepository matchesRepository;

        public MatchService(IMatchesRepository matchesRepository)
        {
            this.matchesRepository = matchesRepository;
        }




        public void AddMatches (List<Match> matches)
        {
            matchesRepository.AddMatchesAsync (matches);
        }

    }
}
