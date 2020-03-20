using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class LoginResponse
    {
        public int StatusCode { get; set; }
        public User user { get; set; }
        public string token { get; set; }
    }
}
