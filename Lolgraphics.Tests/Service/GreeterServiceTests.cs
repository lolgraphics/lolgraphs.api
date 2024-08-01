using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class GreeterServiceTests
    {

        [Fact]
        public void Greet_ReturnsCorrectGreeting()
        {
            // Arrange
            var service = new GreeterService();
            var name = "World";

            // Act
            var result = service.Greet(name);

            // Assert
            Assert.Equal("Hello, World!", result);
        }
    }
}
