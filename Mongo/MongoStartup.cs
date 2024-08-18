using Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Mongo.Configuration;
using MongoDB.Driver;

namespace Mongo
{
    public static class MongoStartup
    {
        public static void ConfigureMongoDb(this IServiceCollection services, IConfiguration configuration)
        {


            services.Configure<MongoDbSettings>(options =>
            {
                options.ConnectionString = configuration["MONGODB_CONNECTIONSTRING"]
                 ?? throw new InvalidOperationException("Mongo Connection string configuration is missing.");
                options.DatabaseName = configuration["MONGODB_DATABASE"]
                        ?? throw new InvalidOperationException("Mongo database string is missing.");
            });

            services.AddSingleton<IMongoClient>(sp =>
            {
                var settings = sp.GetRequiredService<IOptions<MongoDbSettings>>().Value;
                return new MongoClient(settings.ConnectionString);
            });

            services.AddSingleton<MongoDbContext>();
        }
    }
}
