using System.Collections.Generic;
using Assignment.Model;

namespace Assignment.BLL
{
    public class DataService
    {
        public LoginResponse GetLoginDetails(LoginModel login)
        {
            LoginResponse user = DataAccessLayer.GetUser(login);
            return user;

        }
        public string SaveNewUser(Register registrationDetails)
        {
            return DataAccessLayer.Save(registrationDetails);

        }
        public List<GenderModel> GetGender()
        {
            return DataAccessLayer.GetGender();
        }
        public List<RegistrationModel> GetAllUser(string token)
        {
            return DataAccessLayer.GetAllUsers(token);
        }
        public string ForgotPassword(string email)
        {
            return DataAccessLayer.ForgotPassword(email);
        }
    }
}