using Assignment.BLL;
using Assignment.Model;
using Assignment.View.ExternalServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Assignment.ViewModel
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        #region Variabes Declaration
        RequiredFieldValidation requiredFieldValidation = new RequiredFieldValidation();
        DataService dataService = new DataService();
        private List<GenderModel> _GenderCategory;
        public List<GenderModel> GenderCategory
        {
            get
            {
                return _GenderCategory;
            }
            set
            {
                _GenderCategory = value;
                NotifyPropertyChanged("GenderCategory");
            }
        }
        public RegistrationViewModel()
        {
            _GenderCategory = dataService.GetGender();
            if (_GenderCategory.Count == 0)
            {
                ErrorMessage = "Unable to get Gender from server";
            }
        }
        private string fname;
        public string FirstName
        {
            get { return fname; }
            set
            {
                fname = value;
                NotifyPropertyChanged("FirstName");
            }
        }
        private string fnameerror;
        public string FNameError
        {
            get { return fnameerror; }
            set
            {
                fnameerror = value;
                NotifyPropertyChanged("FNameError");
            }
        }
        private string lname;
        public string LastName
        {
            get { return lname; }
            set
            {
                lname = value;
                NotifyPropertyChanged("LastName");
            }
        }
        private string lnameerror;
        public string LNameError
        {
            get { return lnameerror; }
            set
            {
                lnameerror = value;
                NotifyPropertyChanged("LNameError");
            }
        }
        private GenderModel gender;
        public GenderModel GenderValue
        {
            get { return gender; }
            set
            {
                gender = value;
                NotifyPropertyChanged("GenderValue");
            }
        }
        private string gendererror;
        public string GenderError
        {
            get { return gendererror; }
            set
            {
                gendererror = value;
                NotifyPropertyChanged("GenderError");
            }
        }
        private DateTime dob = DateTime.Now;
        public DateTime DOB
        {
            get { return dob; }
            set
            {
                dob = value;
                NotifyPropertyChanged("DOB");
            }
        }
        private string doberror;
        public string DOBError
        {
            get { return doberror; }
            set
            {
                doberror = value;
                NotifyPropertyChanged("DOBError");
            }
        }
        private string email;
        public string EmailId
        {
            get { return email; }
            set
            {
                email = value;
                NotifyPropertyChanged("EmailId");
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
        private string confirmpassword;
        public string ConfirmPassword
        {
            get { return confirmpassword; }
            set
            {
                confirmpassword = value;
                NotifyPropertyChanged("ConfirmPassword");
            }
        }
        private string confirmpassworderror;
        public string ConfirmPasswordError
        {
            get { return confirmpassworderror; }
            set
            {
                confirmpassworderror = value;
                NotifyPropertyChanged("ConfirmPasswordError");
            }
        }
        #endregion

        #region Command Implementation of View
        private ICommand _ResetCommand;
        public ICommand ResetCommand
        {
            get
            {
                if (_ResetCommand == null)
                {
                    _ResetCommand = new RelayCommand(ResetExecute, null);
                }
                return _ResetCommand;
            }
        }
        public void ResetExecute(object parameter)
        {
            Clear();
        }
        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(SubmitExecute, null);
                }
                return _SubmitCommand;
            }
        }

        private void SubmitExecute(object parameter)
        {
            FNameError = requiredFieldValidation.FNameValidation(FirstName);
            LNameError = requiredFieldValidation.LNameValidation(LastName);
            EmailError = requiredFieldValidation.EmailValidation(EmailId);
            GenderError = requiredFieldValidation.GenderValidation(GenderValue);
            DOBError = requiredFieldValidation.DOBValidation(DOB);
            PasswordError = requiredFieldValidation.PasswordValidation(Password);
            ConfirmPasswordError = requiredFieldValidation.ConfirmPasswordValidation(ConfirmPassword);
            ErrorMessage = requiredFieldValidation.PasswordMatch(confirmpassword, password);
            if (FNameError == null && LNameError == null && EmailError == null && GenderError == null && DOBError == null && PasswordError == null && ConfirmPasswordError == null && ErrorMessage == null)
            {
                DataService dataService = new DataService();
                Register registrationModel = new Register
                {
                    FirstName = FirstName,
                    LastName = LastName,

                    EmailId = EmailId,
                    GenderId = GenderValue.Id,
                    Dob = DOB.Date,
                    Password = Password
                };
                var result = dataService.SaveNewUser(registrationModel);
                if (result == "Success")
                {
                    Clear();
                    ErrorMessage = "You have Registered successfully.";
                }
                else
                {
                    ErrorMessage = result;
                }
            }
        }

        private void Clear()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            EmailId = string.Empty;
            Password = string.Empty;
            GenderValue = null;
            DOB = DateTime.Now;
            ConfirmPassword = string.Empty;
            FNameError = string.Empty;
            LNameError = string.Empty;
            EmailError = string.Empty;
            GenderError = string.Empty;
            DOBError = string.Empty;
            PasswordError = string.Empty;
            ConfirmPasswordError = string.Empty;
            ErrorMessage = string.Empty;
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
