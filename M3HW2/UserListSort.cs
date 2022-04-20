using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M3HW2.Models;

namespace M3HW2
{
    public class UserListSort
    {
        public List<User> ruUsers = null;
        public List<User> enUsers = null;
        public List<User> numUsers = null;


        public List<User> UserSort(List<User> users)
        {
            List<User> sortUsers = (List<User>)users.OrderBy(User => User.Name).ThenBy(User => User.Number).ToList();
            return sortUsers;
        }

        public void SplitListByLocale()
        {
            UserList u = new();
            var us = u.users;

            List<User> ru = us.Where(User => User.Locale == "ru").ToList();
            ruUsers = UserSort(ru);
            List<User> en = us.Where(user => user.Locale == "en").ToList();
            enUsers = UserSort(en);
            List<User> num = us.Where(user => user.Locale == "num").ToList();
            numUsers = UserSort(num);
        }
        public List<User> ConcatListWithLocale(string message)
        {
            SplitListByLocale();
            if ( message == "ru")
            {
                ruUsers.AddRange(enUsers);
                ruUsers.AddRange(numUsers);
                return ruUsers;
            }
            if (message == "en")
            {
                enUsers.AddRange(ruUsers);
                enUsers.AddRange(numUsers);
                return enUsers;
            }
            else
            {
                Console.WriteLine("Sort by default settings");
                enUsers.AddRange(ruUsers);
                enUsers.AddRange(numUsers);
                return enUsers;
            }
        }
    }
}