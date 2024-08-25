using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs.MatchDtos
{
    public class MatchDto(string Id, string puuid, long TimeLastMatchPlayed, string FormatedDate)
    {
        public  string Id { get; set; } = Id;
        public  string Puuid { get; set; } = puuid;
        public  long TimeLastMatchPlayed { get; set; } = TimeLastMatchPlayed;
        public  string FormatedDate { get; set; } = FormatedDate;

    }
}
