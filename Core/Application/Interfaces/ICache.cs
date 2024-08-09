using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Interfaces
{
    public interface ICache
    {
        Task SetCacheValueAsync(string key, string value);
        Task<string> GetCacheValueAsync(string key);
    }
}
