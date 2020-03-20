using System;
using System.Text.RegularExpressions;
using Assignment.Model;

namespace Assignment.View.ExternalServices
{
    class RequiredFieldValidation
    {
        public RequiredFieldValidation()
        {
        }
        public string FNameValidation(string Fname)
        {
            if (string.IsNullOrEmpty(Fname) || Fname.Trim() == "")
            {
                return "Please Enter First Name.";
            }
            else if (!Regex.IsMatch(Fname.Trim(), @"^[a-zA-Z]*$"))
            {
                return "Please Enter Valid First Name";
            }
            else return null;
        }
        public string LNameValidation(string Lname)
        {
            if (string.IsNullOrEmpty(Lname) || Lname.Trim() == "")
            {
                return "Please Enter Last Name.";
            }
            else if (!Regex.IsMatch(Lname.Trim(), @"^[a-zA-Z]*$"))
            {
                return "Please Enter Valid Last Name";
            }
            else
                return null;
        }

        public string EmailValidation(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return "Please Enter Email.";
            }

            else if (!Regex.IsMatch(email.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return "Enter a valid email.";
            }
            else return null;
        }
        public string GenderValidation(GenderModel gender)
        {
            if (gender == null)
            {
                return "Please Select Gender.";
            }
            else
                return null;
        }
        public string DOBValidation(DateTime dob)
        {
            if (dob >= DateTime.Now || dob < new DateTime(1919, 01, 01))
            {
                return "Please Select Valid DOB.";
            }
            else
                return null;
        }
        public string PasswordValidation(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Trim() == "")
            {
                return "Please Enter Password.";
            }
            else
                return null;
        }
        public string ConfirmPasswordValidation(string confirmpassword)
        {
            if (string.IsNullOrEmpty(confirmpassword))
            {
                return "Please Enter ConfirmPassword.";
            }
            return null;
        }
        public string PasswordMatch(string confirmpassword, string password)
        {
            if (confirmpassword != null && password != null)
            {
                if (confirmpassword != password)
                {
                    return "Confirm Password not match";
                }
            }
            return null;
        }
    }
}
