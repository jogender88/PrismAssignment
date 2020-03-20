using System;
using APIModel.Models;
using APIModel.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APIs.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IHelperClass helperClass;
        public UsersController(IHelperClass _helperClass)
        {
            helperClass = _helperClass;
        }
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            try
            {
                var users = helperClass.GetAllUsers();
                if (users == null)
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("GetGender")]
        public IActionResult GetGender()
        {
            try
            {
                var gender = helperClass.GetAllGender();
                if (gender == null)
                {
                    return NotFound();
                }
                return Ok(gender);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register([FromBody]Users model)
        {
            try
            {

                var users = helperClass.RegisterUser(model);
                if (User == null)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("Login")]
        public IActionResult GetUser([FromBody]Login model)
        {
            try
            {
                var users = helperClass.GetUser(model);
                if (users == null)
                {
                    return NotFound();
                }
                return Ok(users);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}