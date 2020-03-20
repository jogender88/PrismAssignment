
using System;
using System.ComponentModel;

namespace Assignment.Model
{
    public class RegistrationModel : INotifyPropertyChanged
    {
        #region Variables of Registration Model
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                NotifyPropertyChanged("Id");
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
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                NotifyPropertyChanged("Gender");
            }
        }

        private string _dob;
        public string Dob
        {
            get { return _dob; }
            set
            {
                _dob = value;
                NotifyPropertyChanged("Dob");
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

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}