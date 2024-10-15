using GameSync.Api.Integration;
using GameSync.Models.Users.ValueObjects;
using GameSync.ViewModels.Common;
using System.ComponentModel;
using System.Windows.Input;

namespace GameSync.ViewModels.Login;
public class LoginViewModel : INotifyPropertyChanged
{
    private IGameSyncService _gameSyncService = new GameSyncService();

    private string _login = string.Empty;
    private string _password = string.Empty;

    public ICommand ClearCommand { get; set; }
    public ICommand LoginCommand { get; set; }

    public LoginViewModel()
    {
        ClearCommand = new RelayCommand(OnClear);
        LoginCommand = new RelayCommand(OnLogin);
    }

    public string Login
    {
        get { return _login; }
        set
        {
            if (value != _login)
            {
                _login = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Login"));
            }
        }
    }

    public string Password
    {
        get { return _password; }
        set
        {
            if (value != _password)
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }
    }

    private void OnClear()
    {
        Login = string.Empty;
        Password = string.Empty;
    }

    private void OnLogin()
    {
        var user = _gameSyncService.Login(
            UserName.CreateFrom(Login),
            Models.Users.ValueObjects.Password.CreateFrom(Password)
        );

        OnClear();
    }

    public event PropertyChangedEventHandler? PropertyChanged = delegate { };
}
