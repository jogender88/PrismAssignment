using Assignment.Model;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Windows;

public class DataAccessLayer
{

    public static string Save(Register data)
    {
        try
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync("http://localhost:65109/users/register", data);
                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    return "Success";

                }
                else if (response.Result.StatusCode == HttpStatusCode.NotFound)
                {
                    return "Not able to create user";

                }
                else if (response.Result.StatusCode == HttpStatusCode.BadRequest)
                {
                    return "Bad Request";

                }
                else
                    return "Unable to connect to Server";
            }
        }
        catch (Exception ex)
        {
            return "Server Error";
        }

    }
    //public static bool Save(RegistrationModel data)
    //{
    //    try
    //    {
    //        using (var context = new AssignmentEntities())
    //        {
    //            User user = new User
    //            {
    //                FirstName = data.FName,
    //                LastName = data.LName,
    //                EmailId = data.Email,

    //                GenderId = data.Gender,
    //                DOB = data.DOB,
    //                Password = data.Password,
    //            };
    //            context.Users.Add(user);
    //            context.SaveChanges();
    //        }
    //        return true;
    //    }
    //    catch (Exception e)
    //    {
    //        MessageBox.Show(e.ToString());
    //        return false;
    //    }
    //}
    public static List<RegistrationModel> GetAllUsers(string token)
    {
        List<RegistrationModel> AllUsers = new List<RegistrationModel>();
        try
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = client.GetAsync("http://localhost:65109/users/getusers");
                if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = response.Result.Content.ReadAsStringAsync().Result;
                    var data = JsonConvert.DeserializeObject<GetUsersAPIResponse>(result);
                    AllUsers = data.Data;

                }
                return AllUsers;
            }
        }
        catch (Exception e)
        {
            return AllUsers;
        }
    }
    public static LoginResponse GetUser(LoginModel login)
    {
        //LoginResponse userObj = new LoginResponse();
        try
        {
            //using (var context = new AssignmentEntities())
            //{
            //    userObj = context.Users.FirstOrDefault(a => a.EmailId == email && a.Password == password);
            //    if (userObj != null)
            //    {
            //        return userObj;

            //    }
            //    else
            //        return null;
            //}
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync("http://localhost:65109/users/login", login);
                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Result.Content.ReadAsStringAsync().Result;

                    var userObj = JsonConvert.DeserializeObject<LoginResponse>(result);
                    return userObj;
                }
                else
                    return new LoginResponse { };
            }
        }
        catch (Exception e)
        {
            return new LoginResponse { }; ;

        }
    }
    public static List<GenderModel> GetGender()
    {
        List<GenderModel> genderData = new List<GenderModel>();
        try
        {
            //using (var context = new AssignmentEntities())
            //{
            //    var genderData = (context.GenderTables.Select(a => new GenderModel() { GenderType = a.GenderType, Id = a.Id }).ToList());
            //    if (genderData != null)
            //    {
            //        return genderData;

            //    }
            //    else
            //        return null;
            //}
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync("http://localhost:65109/users/getgender");
                if (response.Result.StatusCode == HttpStatusCode.OK)
                {
                    var result = response.Result.Content.ReadAsStringAsync().Result;

                    var data = JsonConvert.DeserializeObject<GetGenderAPIResponse>(result);
                    genderData = data.Data;
                    return genderData;

                }
                else
                    return genderData;
            }
        }
        catch (Exception e)
        {
            return genderData;

        }
    }
    //public static List<RegistrationModel> GetAllUsers()
    //{
    //    try
    //    {
    //        using (var context = new AssignmentEntities())
    //        {
    //            var AllUsers = (context.Users.Select(a => new RegistrationModel() { UId = a.Id, FName = a.FirstName, LName = a.LastName, Email = a.EmailId, _Gender = a.GenderTable.GenderType, DOB = a.DOB }).ToList());
    //            return AllUsers;
    //        }
    //    }
    //    catch (Exception e)
    //    {
    //        return null;
    //    }
    //}
    public static string ForgotPassword(string email)
    {
        try
        {
            using (var context = new AssignmentEntities())
            {
                var password = context.Users.Where(a => a.EmailId == email).Select(u => u.Password).FirstOrDefault();
                if (password != null)
                    return password.ToString();
                else return null;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }
}
