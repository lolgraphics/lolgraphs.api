using Infrastructure.Configuration;
using Microsoft.Extensions.Options;
using Mongo.Models;
using Mongo.Models.InfoMatch;
using Mongo.Models.InfoMatchTimeLine;
using MongoDB.Driver;


namespace Mongo.Configuration
{
    public class MongoDbContext(IMongoClient mongoClient, IOptions<MongoDbSettings> settings)
    {
        private readonly IMongoDatabase _database = mongoClient.GetDatabase(settings.Value.DatabaseName);
        
        public IMongoCollection<SummonerModel> Summoners =>
            _database.GetCollection<SummonerModel>("Summoners");

        public IMongoCollection<MatchModel> Matches => 
           _database.GetCollection<MatchModel>("Matches"); 
        
        public IMongoCollection<InfoMatchModel> InfoMatches => 
           _database.GetCollection<InfoMatchModel>("InfoMatches");

        public IMongoCollection<InfoMatchTimeLineModel> InfoMatchesTimeLines =>
            _database.GetCollection<InfoMatchTimeLineModel>("InfoMatchesTimeLines");
    }
}
