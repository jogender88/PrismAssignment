using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    public class GetGenderAPIResponse
    {
        public int StatusCode { get; set; }
        public List<GenderModel> Data { get; set; }
    }
}
