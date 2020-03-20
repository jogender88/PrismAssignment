using Assignment.BLL;
using Assignment.Model;
using Assignment.View.ExternalServices;
using Assignment.ViewModel.ExternalServices;
using System.ComponentModel;
using System.Windows.Input;

namespace Assignment.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Variable Declaration for Login View
        public delegate void LoginEventHandler(string e);
        public event LoginEventHandler LoggedIn;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                NotifyPropertyChanged("Email");
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyPropertyChanged("Password");
            }
        }
        private string passworderror;
        public string PasswordError
        {
            get { return passworderror; }
            set
            {
                passworderror = value;
                NotifyPropertyChanged("PasswordError");
            }
        }
        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }
        private string emailerror;
        public string EmailError
        {
            get { return emailerror; }
            set
            {
                emailerror = value;
                NotifyPropertyChanged("EmailError");
            }
        }
        private bool loginauthenticated = false;
        public bool Loginauthenticated
        {
            get { return loginauthenticated; }
            set
            {
                loginauthenticated = value;
                NotifyPropertyChanged("Loginauthenticated");
            }
        }
        #endregion

        #region Commands Implementation of View
        private ICommand _LoginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_LoginCommand == null)
                {
                    _LoginCommand = new RelayCommand(LoginExecute, null);
                }
                return _LoginCommand;
            }
        }


        private void LoginExecute(object parameter)
        {
            RequiredFieldValidation requiredFieldValidation = new RequiredFieldValidation();
            EmailError = requiredFieldValidation.EmailValidation(Email);
            PasswordError = requiredFieldValidation.PasswordValidation(Password);
            if (EmailError == null && PasswordError == null)
            {
                ErrorMessage = string.Empty;
                DataService dataService = new DataService();
                LoginModel login = new LoginModel
                {
                    EmailId = Email,
                    Password = Password
                };
                LoginResponse user = dataService.GetLoginDetails(login);
                if (user.StatusCode == 200)
                {
                    Loginauthenticated = true;
                    TokenHandler.Token = user.token;
                    OnLoggedIn(user.user.FirstName);

                    ErrorMessage = "Login SuccussFull";
                }
                else if (user.StatusCode == 404)
                {
                    Loginauthenticated = false;
                    ErrorMessage = "Username or Password is incorrect";
                }
                else
                {
                    Loginauthenticated = false;
                    ErrorMessage = "Unable to connect to Server";
                }
            }

        }

        public void OnLoggedIn(string e)
        {
            if (LoggedIn != null) LoggedIn(e);
        }

        private ICommand _ForgotPasswordCommand;
        public ICommand ForgotPasswordCommand
        {
            get
            {
                if (_ForgotPasswordCommand == null)
                {
                    _ForgotPasswordCommand = new RelayCommand(ForgotPasswordExecute, null);
                }
                return _ForgotPasswordCommand;
            }
        }
        private void ForgotPasswordExecute(object p)
        {
            RequiredFieldValidation requiredFieldValidation = new RequiredFieldValidation();

            EmailError = requiredFieldValidation.EmailValidation(Email);
            if (EmailError == null)
            {
                DataService dataService = new DataService();
                string userpassword = dataService.ForgotPassword(Email);
                if (userpassword != null)
                {

                    ErrorMessage = "Your Password is: " + userpassword;
                }
                else
                {
                    ErrorMessage = "Username no found";
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Interface Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
