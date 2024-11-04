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
            userId: null!,
            userName: UserName.CreateFrom("abc"),
            password: Password.CreateFrom("12312323"));

        // Act & Assert
        createUser
            .Should()
            .Throw<Exception>();
    }
}
