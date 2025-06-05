# Hello_World
hello-world
===========

Hi Human!

Hubbot here, I like Node.js and coffeescript (that's what I'm made of!).
I've had tacos on the moon and find them far superior to Earth tacos.

## Project Structure

This repository contains a simple C# .NET Core 2.0 console application that demonstrates:
- Basic console output functionality
- Testable code architecture
- Comprehensive test coverage

### Main Application
- **Hello_World/**: Contains the main console application
  - `Program.cs`: Entry point that orchestrates the greeting functionality
  - `GreetingService.cs`: Core business logic for generating greetings
  - `Hello_World.csproj`: Project configuration

### Test Suite
- **Hello_World.Tests/**: Comprehensive test suite
  - `GreetingServiceTests.cs`: Unit tests for greeting functionality
  - `ProgramIntegrationTests.cs`: Integration tests for complete application flow
  - `Hello_World.Tests.csproj`: Test project configuration
  - `README.md`: Detailed testing documentation

## Getting Started

### Prerequisites
- .NET Core 2.0 SDK or later

### Running the Application
```bash
# From the repository root
dotnet run --project Hello_World/

# Or using the solution
dotnet build
dotnet run --project Hello_World/
```

### Running Tests
```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --verbosity normal

# Run specific test project
dotnet test Hello_World.Tests/
```

### Building the Solution
```bash
# Build everything
dotnet build Hello_World.sln

# Build specific project
dotnet build Hello_World/
dotnet build Hello_World.Tests/
```

## Features

- **Simple Greeting**: Displays "Hello Jenkins!" message
- **Extensible Architecture**: Separated concerns for easy testing and future enhancements
- **Comprehensive Testing**: Unit and integration tests with high coverage
- **CI/CD Ready**: Test suite designed for automated build pipelines

## Testing Strategy

The project implements a comprehensive testing approach:
- **Unit Tests**: Test individual components in isolation
- **Integration Tests**: Verify complete application behavior
- **Edge Case Coverage**: Handle null, empty, and malformed inputs
- **Cross-platform Compatibility**: Tests run on any .NET Core 2.0+ environment

For detailed testing information, see [Hello_World.Tests/README.md](Hello_World.Tests/README.md).

