using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime Registration { get; set; }
        public DateTime LastEntry { get; set; }
        public bool FirstEntry { get; set; }
        public User()
        {
            this.Registration = DateTime.Now;
            this.LastEntry = DateTime.Now;
            this.FirstEntry = true;
        }



    }
}
