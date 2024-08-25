using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common.Exceptions
{
    public class MatchDataException(string message, string content) : Exception($"{message} Response content: {content}")
    {

    }
}
