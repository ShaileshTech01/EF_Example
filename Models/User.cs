using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Example.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
