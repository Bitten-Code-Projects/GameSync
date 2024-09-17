using GameSync.Api.Integration;
using GameSync.Models.Users.ValueObjects;
using GameSync.UI.Common;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace GameSync.UI.Login;
public class LoginViewModel : INotifyPropertyChanged
{
    private IGameSyncService _gameSyncService = new GameSyncService();

    private string _login = "";
    private string _password = "";

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
        Login = "";
        Password = "";
    }

    private void OnLogin()
    {
        try
        {
            var _user = _gameSyncService.Login(
                UserName.CreateFrom(Login),
                Models.Users.ValueObjects.Password.CreateFrom(Password)
            );

            MessageBox.Show($"Successfully logged in! \r\nUserId: { _user.UserId.Value} \r\nUserName: { _user.UserName.Value }", "OK");
            OnClear();
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error");
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged = delegate { };
}
