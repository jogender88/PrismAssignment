using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class GetUsersAPIResponse
    {
        public int StatusCode { get; set; }
        public List<RegistrationModel> Data { get; set; }
    }
}
