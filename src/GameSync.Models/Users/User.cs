using GameSync.Models.Users.ValueObjects;

namespace GameSync.Models.Users;
public class User
{
    public UserId UserId { get; private set; }
    public UserName UserName { get; private set; }
    public Password Password { get; private set; }

    public User(
        UserId userId,
        UserName userName,
        Password password
    )
    {
        SetUserIdOrThrowException(userId);
        SetUserNameOrThrowExcetpion(userName);
        Password = password;
    }

    private void SetUserIdOrThrowException(UserId userId)
    {
        if (userId is null)
            throw new ArgumentNullException(nameof(userId));

        UserId = userId;
    }

    private void SetUserNameOrThrowExcetpion(UserName userName)
    {
        if (userName is null)
            throw new ArgumentNullException(nameof(userName));

        UserName = userName;
    }
}
