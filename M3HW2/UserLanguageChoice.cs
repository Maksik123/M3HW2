using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M3HW2.Interfaces;

namespace M3HW2
{
    public class UserLanguageChoice : IUserLanguageChoice
    {
        public string UserChoice()
        {
            Console.WriteLine("Please select your language(ru/Ru or en/En):");
            var userText = Console.ReadLine();
            string message;
            if (userText == "ru" || userText == "en" || userText == "Ru" || userText == "En")
            {
                if (userText == "ru" || userText == "Ru")
                {
                    message = "ru";
                    return message;
                }
                else
                {
                    message = "en";
                    return message;

                }
            }
            else
            {
                Console.WriteLine("Error: please enter correct");
                UserChoice();
                return "error";
            }
        }
    }
}
