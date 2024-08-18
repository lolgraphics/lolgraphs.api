using Core.Application.Interfaces;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.Services

{
    public class RedisService(IConnectionMultiplexer redis) : IRedisService
    {
        private readonly IConnectionMultiplexer _redis = redis;

        public async Task SetCacheValueAsync(string key, string value)
        {
            var db = _redis.GetDatabase();
            await db.StringSetAsync(key, value);
        }

        public async Task<string?> GetCacheValueAsync(string key)
        {
            var db = _redis.GetDatabase();
            var value = await db.StringGetAsync(key);
            return value;
        }
    }
}

