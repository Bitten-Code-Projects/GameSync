using GameSync.Models.Users;
using GameSync.Models.Users.ValueObjects;

namespace GameSync.Api.Integration;
public interface IGameSyncService
{
    public User Login(UserName userName, Password password);
}
