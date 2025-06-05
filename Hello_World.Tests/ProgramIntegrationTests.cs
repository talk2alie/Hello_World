using System;
using System.IO;
using System.Diagnostics;
using Xunit;

namespace Hello_World.Tests
{
    public class ProgramIntegrationTests
    {
        [Fact]
        public void Program_WhenExecuted_ShouldOutputCorrectMessage()
        {
            // Arrange
            var startInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = "run --project ../Hello_World/Hello_World.csproj",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                CreateNoWindow = true
            };

            // Act
            using (var process = Process.Start(startInfo))
            {
                // Send input to close the Console.Read()
                process.StandardInput.WriteLine();
                process.WaitForExit(5000); // Wait up to 5 seconds

                string output = process.StandardOutput.ReadToEnd();

                // Assert
                Assert.Contains("Hello Jenkins!", output);
            }
        }

        [Fact]
        public void GreetingService_Integration_ShouldWorkWithProgramFlow()
        {
            // Arrange
            var greetingService = new Hello_World.GreetingService();

            // Act
            string greeting = greetingService.GetGreeting();

            // Assert - Verify the service produces the same output the program expects
            Assert.Equal("Hello Jenkins!", greeting);
            Assert.NotNull(greeting);
            Assert.NotEmpty(greeting);
        }

        [Fact]
        public void GreetingService_PersonalizedGreeting_ShouldWorkEndToEnd()
        {
            // Arrange
            var greetingService = new Hello_World.GreetingService();
            string testName = "TestUser";

            // Act
            string personalizedGreeting = greetingService.GetPersonalizedGreeting(testName);

            // Assert
            Assert.Equal("Hello TestUser!", personalizedGreeting);
            Assert.Contains(testName, personalizedGreeting);
        }
    }
}

