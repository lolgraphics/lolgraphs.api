using Moq;
using Redis.Services;
using StackExchange.Redis;
using System.Threading.Tasks;
using Xunit;

namespace Redis.Tests.Services
{
    public class RedisServiceTests
    {
        private MockRepository mockRepository;
        private Mock<IConnectionMultiplexer> mockConnectionMultiplexer;
        private Mock<IDatabase> mockDatabase;

        public RedisServiceTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
            this.mockConnectionMultiplexer = this.mockRepository.Create<IConnectionMultiplexer>();
            this.mockDatabase = this.mockRepository.Create<IDatabase>();

            this.mockConnectionMultiplexer
                .Setup(conn => conn.GetDatabase(It.IsAny<int>(), It.IsAny<object>()))
                .Returns(this.mockDatabase.Object);
        }

        private RedisService CreateService()
        {
            return new RedisService(this.mockConnectionMultiplexer.Object);
        }


        [Fact]
        public async Task GetCacheValueAsync_ShouldCallStringGetAsync()
        {
            // Arrange
            var key = "testKey";
            var expectedValue = "testValue";

            this.mockDatabase
                .Setup(db => db.StringGetAsync(key, CommandFlags.None))
                .Returns(Task.FromResult((RedisValue)expectedValue));

            var service = CreateService();

            // Act
            var result = await service.GetCacheValueAsync(key);

            // Assert
            Assert.Equal(expectedValue, result);
            this.mockDatabase.Verify(db => db.StringGetAsync(key, CommandFlags.None), Times.Once);
        }
    }
}
