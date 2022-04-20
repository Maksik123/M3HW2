using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M3HW2.Models;
using M3HW2.Interfaces;

namespace M3HW2
{
    public class Starter
    {
        public void Start()
        {
            UserListSort sort = new();
            UserLanguageChoice choice = new();
            var userChoice = choice.UserChoice();
            var userList = sort.ConcatListWithLocale(userChoice);
            foreach (User u in userList)
            {
                Console.WriteLine($"Name: {u.Name}\tNumber: {u.Number}");
            }
        }
    }
}
