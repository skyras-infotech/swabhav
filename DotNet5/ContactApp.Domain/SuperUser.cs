using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Domain
{
    public class SuperUser : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
       
    }
}
