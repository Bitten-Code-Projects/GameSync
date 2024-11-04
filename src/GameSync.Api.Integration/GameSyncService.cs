using GameSync.Models.Users;
using GameSync.Models.Users.ValueObjects;

namespace GameSync.Api.Integration;
public class GameSyncService : IGameSyncService
{
    public User Login(UserName userName, Password password)
    {
        if (userName.Value == "admin" && password.Value == "adminadmin")
        {
            return new User(
                UserId.CreateUnique(),
                UserName.CreateFrom("admin"),
                Password.CreateFrom("adminadmin"));
        }

        throw new Exception("Authentication exception");
    }
}
