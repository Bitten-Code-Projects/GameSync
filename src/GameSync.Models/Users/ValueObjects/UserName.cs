namespace GameSync.Models.Users.ValueObjects;
public class UserName
{
    public string Value { get; private set; }

    private UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(UserName));
        }

        Value = value;
    }

    public static UserName CreateFrom(string value)
        => new UserName(value);
}
