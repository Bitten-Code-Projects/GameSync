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
        Password password)
    {
        UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        Password = password;
    }
}
