using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.DTOs
{
    public class AccountDto
    {
        public required string Puuid { get; set; }
        public required string GameName { get; set; }
        public required string TagLine { get; set; }
    }
}
