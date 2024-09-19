using GameSync.Models.Users;
using GameSync.Models.Users.ValueObjects;

namespace GameSync.Models.Unit.Tests.Users;
public class UserTests
{
    [Fact]
    public void User_WhenPassedNullUserId_ShouldThrowException()
    {
        // Arrange
        var createUser = () => new User(
            null,
            UserName.CreateFrom("abc"),
            Password.CreateFrom("12312323")
        );

        // Act & Assert
        createUser
            .Should()
            .Throw<Exception>();
    }
}
