using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectWebAPIDemoApp.Models
{
    public class Employee : IEmployee
    {
        public int GetNoOfEmployee()
        {
            return 10;
        }
    }
}