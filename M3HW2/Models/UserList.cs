using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M3HW2.Models;

namespace M3HW2.Models
{
    public class UserList
    {
        public List<User> users = new()
        {
            new User(name: "Max", lastName: "Borisenko", number: "1222", userLocale: "en"),
            new User(name:"Alex", lastName: "Petrov", number: "4532", userLocale: "en"),
            new User(name:"Eugene", lastName: "Namil", number: "685", userLocale: "en"),
            new User(name:"Ivan", lastName: "Ivanov", number: "23142", userLocale: "en"),
            new User(name:"Max", lastName: "Maximov", number: "2342", userLocale: "en"),
            new User(name:"Borya", lastName: "Borisov", number: "89066", userLocale: "en"),
            new User(name: "Borya", lastName: "Borisov", number: "19066", userLocale: "en"),
            new User(name:"Максим", lastName: "Борисенко", number: "6664", userLocale: "ru"),
            new User(name:"Саша", lastName: "Филатов", number: "8907", userLocale: "ru"),
            new User(name:"Юра", lastName: "Юрьев", number: "44094", userLocale: "ru"),
            new User(name:"Максим", lastName: "Максимов", number: "44234", userLocale: "ru"),
            new User(name:"Ростислав", lastName: "Рюрикович", number: "4444", userLocale: "ru"),
            new User(name:"Унга", lastName: "Эуо", number: "4424", userLocale: "ru"),
            new User(name:"", lastName: "", number: "6789", userLocale: "num"),
            new User(name:"", lastName: "", number: "5678", userLocale: "num"),
        };
    }
}
