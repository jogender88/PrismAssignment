using APIModel.Models;
using APIModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs
{
    public interface IHelperClass
    {

        List<UserViewModel> GetAllUsers();
        bool RegisterUser(Users users);
        List<GenderViewModel> GetAllGender();
        Users GetUser(Login login);
    }
}
