using Assignment.View.Views;
using System.Windows;
using System.Windows.Input;

namespace Assignment.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }


        private void passwordConfirm_KeyUp(object sender, KeyEventArgs e)
        {

            if (password.Text != passwordConfirm.Text)
            {
                errormessage.Text = "Password not match";
            }
            else
            {
                errormessage.Text = string.Empty;
            }

        }
    }
}
