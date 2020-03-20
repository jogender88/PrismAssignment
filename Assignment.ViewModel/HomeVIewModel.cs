using Assignment.BLL;
using Assignment.Model;
using Assignment.ViewModel.ExternalServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Assignment.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public HomeViewModel()
        {
            DataService dataService = new DataService();

            AllUsersStore = (dataService.GetAllUser(TokenHandler.Token));
            if (AllUsersStore.Count == 0)
            {
                ErrorMessage = "Unable to get Users";
            }
            else
            {
                AllUsers = new ObservableCollection<RegistrationModel>(AllUsersStore);
            }
        }  //Constructor

        #region Variabes Declaration
        private ObservableCollection<RegistrationModel> _AllUsers;
        public ObservableCollection<RegistrationModel> AllUsers
        {
            get
            {
                return _AllUsers;
            }
            set
            {
                _AllUsers = value;
                NotifyPropertyChanged("AllUsers");
            }
        }
        public List<RegistrationModel> AllUsersStore { get; private set; }



        //private ObservableCollection<RegistrationModel> _AllUsersStore;
        //public ObservableCollection<RegistrationModel> AllUsersStore
        //{
        //    get
        //    {
        //        return _AllUsersStore;
        //    }
        //    set
        //    {
        //        _AllUsersStore = value;
        //        NotifyPropertyChanged("AllUsersStore");
        //    }
        //}
        private ObservableCollection<RegistrationModel> _AllSearchUsers;
        public ObservableCollection<RegistrationModel> AllSearchUsers
        {
            get
            {
                return _AllSearchUsers;
            }
            set
            {
                _AllSearchUsers = value;
                NotifyPropertyChanged("AllSearchUsers");
            }
        }

        public string Token { get; set; }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                NotifyPropertyChanged("SearchText");
            }
        }
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
        #endregion
        private ICommand _SearchCommand;
        public ICommand SearchCommand
        {
            get
            {
                if (_SearchCommand == null)
                {
                    _SearchCommand = new RelayCommand(SearchExecute, null);
                }
                return _SearchCommand;
            }
        }
        public void SearchExecute(object p)
        {
            AllSearchUsers = new ObservableCollection<RegistrationModel>();
            if (string.IsNullOrEmpty(SearchText))
            {
                ErrorMessage = "Enter value for Search";
            }
            else if (AllUsersStore != null)
            {
                SearchText = SearchText.ToLower();

                ErrorMessage = string.Empty;
                foreach (RegistrationModel user in AllUsersStore)
                {
                    if (user.FirstName.ToLower().Contains(SearchText) || user.LastName.ToLower().Contains(SearchText) || user.EmailId.ToLower().Contains(SearchText))
                    {
                        AllSearchUsers.Add(user);
                    }
                }
                AllUsers = AllSearchUsers;
                if (AllUsers.Count == 0)
                {
                    ErrorMessage = "No User Found";
                }
            }
            else
            {
                ErrorMessage = "No Users found";
            }
        }
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

        public void GetAllUsers(string token)
        {
            DataService dataService = new DataService();

            AllUsersStore = (dataService.GetAllUser(token));
            if (AllUsersStore.Count == 0)
            {
                ErrorMessage = "Unable to get Users";
            }
            else
            {
                AllUsers = new ObservableCollection<RegistrationModel>(AllUsersStore);
            }
        }

        private void ResetExecute(object p)
        {
            ErrorMessage = string.Empty;
            SearchText = string.Empty;
            AllUsers = new ObservableCollection<RegistrationModel>(AllUsersStore);
        }
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
