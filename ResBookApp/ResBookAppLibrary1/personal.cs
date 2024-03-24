using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResBookAppLibrary1
{
    public class personal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public personal() { }
        public personal(string name, int age, string birthday, string email, string password)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
            Email = email;
            Password = password;
        }
    }
}
