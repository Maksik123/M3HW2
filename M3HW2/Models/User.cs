using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3HW2.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Number { get; set; }

        public string Locale { get; set; }

        public string Name { get; set; }
        public User(string name, string lastName, string number, string userLocale)
        {
            Name = name + " " + lastName;
            Number = number;
            Locale = userLocale;
            if(Name == " ")
            {
                Name = Number.ToString();
            }
        }
    }
}
