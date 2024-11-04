using System.Windows;
using System.Windows.Controls;

namespace GameSync.UI.Login;

/// <summary>
/// Interaction logic for LoginView.xaml.
/// </summary>
public partial class LoginView : UserControl
{
    public LoginView()
    {
        InitializeComponent();
    }

    private void TextBox_GotFocus(object sender, RoutedEventArgs e)
    {
        if (sender is TextBox textBox)
        {
            var label = (Label)((Grid)textBox.Parent).Children[0];
            label.Content = label.Content.ToString();
        }
    }

    private void TextBox_LostFocus(object sender, RoutedEventArgs e)
    {
        if (sender is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
        {
            var label = (Label)((Grid)textBox.Parent).Children[0];
            label.Content = label.Content.ToString();
        }
    }
}
