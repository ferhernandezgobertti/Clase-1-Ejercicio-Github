using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Client : User
    {
        public String NumberID { get; set; }
        public String Telephone { get; set; }
        public String Address { get; set; }
    }
}
