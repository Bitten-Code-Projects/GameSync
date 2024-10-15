namespace GameSync.Models.Users.ValueObjects;
public class UserId
{
    public Guid Value { private set; get; }

    private UserId(Guid value)
    {
        Value = value;
    }

    public static UserId CreateUnique() => new UserId(Guid.NewGuid());
    public static UserId CreateFrom(Guid value) => new UserId(value);
}
