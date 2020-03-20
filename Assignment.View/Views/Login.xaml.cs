using System.Windows;
using Assignment.ViewModel;
namespace Assignment.View.Views
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.Loaded += Login_Loaded;
        }
        LoginViewModel loginViewModel = new LoginViewModel();
        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            Register registration = new Register();
            registration.Show();
            Close();

        }

        private void Login_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= Login_Loaded;
            Activate();
        }

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (loginViewModel != null)
                loginViewModel.LoggedIn -= LoginVMLogin;
            loginViewModel = DataContext as LoginViewModel;

            if (loginViewModel == null)
                return;
            loginViewModel.LoggedIn += LoginVMLogin;
        }

        private void LoginVMLogin(string e)
        {
            if (loginViewModel.Loginauthenticated)
            {
                Home home = new Home();
                home.textBlockName.Text = e;
                home.Show();
                Close();
            }
        }

        private void ForgotPassword(object sender, RoutedEventArgs e)
        {

        }
    }
}
