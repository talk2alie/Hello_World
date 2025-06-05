using System;
using Xunit;
using Hello_World;

namespace Hello_World.Tests
{
    public class GreetingServiceTests
    {
        private readonly GreetingService _greetingService;

        public GreetingServiceTests()
        {
            _greetingService = new GreetingService();
        }

        [Fact]
        public void GetGreeting_ShouldReturnCorrectMessage()
        {
            // Act
            string result = _greetingService.GetGreeting();

            // Assert
            Assert.Equal("Hello Jenkins!", result);
        }

        [Fact]
        public void GetGreeting_ShouldNotReturnNull()
        {
            // Act
            string result = _greetingService.GetGreeting();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetGreeting_ShouldNotReturnEmptyString()
        {
            // Act
            string result = _greetingService.GetGreeting();

            // Assert
            Assert.NotEmpty(result);
        }

        [Theory]
        [InlineData("John", "Hello John!")]
        [InlineData("Alice", "Hello Alice!")]
        [InlineData("Bob", "Hello Bob!")]
        public void GetPersonalizedGreeting_WithValidName_ShouldReturnPersonalizedMessage(string name, string expected)
        {
            // Act
            string result = _greetingService.GetPersonalizedGreeting(name);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void GetPersonalizedGreeting_WithInvalidName_ShouldReturnDefaultGreeting(string name)
        {
            // Act
            string result = _greetingService.GetPersonalizedGreeting(name);

            // Assert
            Assert.Equal("Hello Jenkins!", result);
        }

        [Fact]
        public void GetPersonalizedGreeting_WithNameContainingSpaces_ShouldTrimSpaces()
        {
            // Arrange
            string nameWithSpaces = "  John  ";

            // Act
            string result = _greetingService.GetPersonalizedGreeting(nameWithSpaces);

            // Assert
            Assert.Equal("Hello John!", result);
        }

        [Fact]
        public void GetPersonalizedGreeting_WithSpecialCharacters_ShouldHandleCorrectly()
        {
            // Arrange
            string nameWithSpecialChars = "José";

            // Act
            string result = _greetingService.GetPersonalizedGreeting(nameWithSpecialChars);

            // Assert
            Assert.Equal("Hello José!", result);
        }
    }
}

