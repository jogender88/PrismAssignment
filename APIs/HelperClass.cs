using APIModel.Models;
using APIModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs
{
    public class HelperClass : IHelperClass
    {
        static AssignmentContext assignmentContext;
        public HelperClass(AssignmentContext _assignmentContext)
        {
            assignmentContext = _assignmentContext;
        }

        public IEnumerable<UserViewModel> AllUsers { get; private set; }
        public IEnumerable<GenderViewModel> Genders { get; private set; }

        public List<UserViewModel> GetAllUsers()
        {
            try
            {
                if (assignmentContext != null)
                {
                    AllUsers = (from users in assignmentContext.Users
                                select new UserViewModel
                                {
                                    Id = users.Id,
                                    FirstName = users.FirstName,
                                    LastName = users.LastName,
                                    EmailId = users.EmailId,
                                    _Gender = users.Gender.GenderType,
                                    Dob = users.Dob.ToString("dd/MM/yyyy")
                                }).ToList();
                }
                return new List<UserViewModel>(AllUsers);

            }
            catch (Exception e)
            {
                return null;
            }
        }


        public bool RegisterUser(Users data)
        {
            try
            {
                if (assignmentContext != null)
                {
                    Users user = new Users
                    {
                        FirstName = data.FirstName,
                        LastName = data.LastName,
                        EmailId = data.EmailId,
                        GenderId = data.GenderId,
                        Dob = data.Dob,
                        Password = data.Password,
                    };
                    assignmentContext.Users.Add(user);
                    assignmentContext.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
        public List<GenderViewModel> GetAllGender()
        {

            try
            {
                if (assignmentContext != null)
                {
                    Genders = (from gendertable in assignmentContext.GenderTable select new GenderViewModel { Id = gendertable.Id, GenderType = gendertable.GenderType }).ToList();
                }
                return new List<GenderViewModel>(Genders);

            }
            catch (Exception e)
            {
                return null;
            }
        }
        public Users GetUser(Login login)
        {
            Users userObj = new Users();
            try
            {
                if (assignmentContext != null)
                {

                    userObj = assignmentContext.Users.FirstOrDefault(a => a.EmailId == login.EmailId && a.Password == login.password);
                    if (userObj != null)
                    {
                        return userObj;

                    }
                    else
                        return null;
                }
                else
                    return null;

            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
