using GameSync.Models.Users.ValueObjects;

namespace GameSync.Models.Unit.Tests.Users.ValueObjects;
public class PasswordTests
{
    [Fact]
    public void CreateFrom_WhenPassedTooShortValue_ShouldThrowException()
    {
        // Arrange
        var createPassword = () => Password.CreateFrom("abc123");

        // Act & Assert
        createPassword
            .Should()
            .Throw<Exception>();
    }
}
