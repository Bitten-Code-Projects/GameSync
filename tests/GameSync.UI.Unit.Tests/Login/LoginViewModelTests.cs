using GameSync.ViewModels.Login;

namespace GameSync.ViewModels.Unit.Tests.Login;
public class LoginViewModelTests
{
    [Fact]
    public void ClearCommand_WhenExecuted_ShouldClearLoginAndPassword()
    {
        // Arrange
        var cut = new LoginViewModel()
        {
            Login = "examplelogin",
            Password = "examplepassword"
        };

        // Act
        cut.ClearCommand.Execute(null);

        // Assert
        cut.Login
            .Should()
            .Be(string.Empty);

        cut.Password
            .Should()
            .Be(string.Empty);
    }
}
