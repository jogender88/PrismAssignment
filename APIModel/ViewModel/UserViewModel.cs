using System;
using System.Collections.Generic;
using System.Text;

namespace APIModel.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string _Gender { get; set; }
        public string Dob { get; set; }
    }
}
