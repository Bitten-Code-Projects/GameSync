namespace GameSync.Models.Users.ValueObjects;
public class Password
{
    public string Value { get; private set; }

    private Password(string value)
    {
        if (string.IsNullOrEmpty(value))
            throw new ArgumentNullException(nameof(Password));

        if (value.Length < 8)
            throw new ArgumentException("Password is too short.", nameof(Password));

        Value = value;
    }

    public static Password CreateFrom(string value) => new Password(value);
}
