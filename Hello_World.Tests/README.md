# Hello_World Tests

This directory contains comprehensive tests for the Hello_World console application.

## Test Structure

### Unit Tests (`GreetingServiceTests.cs`)
- **GetGreeting_ShouldReturnCorrectMessage**: Verifies the basic greeting message
- **GetGreeting_ShouldNotReturnNull**: Ensures the method never returns null
- **GetGreeting_ShouldNotReturnEmptyString**: Ensures the method returns a meaningful value
- **GetPersonalizedGreeting_WithValidName_ShouldReturnPersonalizedMessage**: Tests personalized greetings with various names
- **GetPersonalizedGreeting_WithInvalidName_ShouldReturnDefaultGreeting**: Tests edge cases with null/empty names
- **GetPersonalizedGreeting_WithNameContainingSpaces_ShouldTrimSpaces**: Tests input sanitization
- **GetPersonalizedGreeting_WithSpecialCharacters_ShouldHandleCorrectly**: Tests international character support

### Integration Tests (`ProgramIntegrationTests.cs`)
- **Program_WhenExecuted_ShouldOutputCorrectMessage**: Tests the complete application execution
- **GreetingService_Integration_ShouldWorkWithProgramFlow**: Verifies service integration
- **GreetingService_PersonalizedGreeting_ShouldWorkEndToEnd**: Tests end-to-end personalized greeting flow

## Running Tests

### Prerequisites
- .NET Core 2.0 SDK or later
- xUnit test framework (automatically restored via NuGet)

### Commands

#### Run all tests:
```bash
dotnet test
```

#### Run tests with detailed output:
```bash
dotnet test --verbosity normal
```

#### Run tests from the solution root:
```bash
dotnet test Hello_World.Tests/
```

#### Run specific test class:
```bash
dotnet test --filter "FullyQualifiedName~GreetingServiceTests"
```

#### Run tests with coverage (requires additional tools):
```bash
dotnet test --collect:"XPlat Code Coverage"
```

## Test Coverage

The test suite provides comprehensive coverage of:
- ✅ Core greeting functionality
- ✅ Personalized greeting features
- ✅ Edge case handling (null, empty, whitespace inputs)
- ✅ Input sanitization (trimming spaces)
- ✅ International character support
- ✅ Integration with the main program
- ✅ End-to-end application behavior

## Continuous Integration

These tests are designed to run in CI/CD pipelines and will:
- Validate code changes don't break existing functionality
- Ensure new features work as expected
- Provide fast feedback on code quality

## Adding New Tests

When adding new functionality to the Hello_World application:
1. Add corresponding unit tests in `GreetingServiceTests.cs`
2. Add integration tests in `ProgramIntegrationTests.cs` if needed
3. Update this README with new test descriptions
4. Ensure all tests pass before committing changes

