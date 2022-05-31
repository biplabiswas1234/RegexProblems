using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    internal class UserRegistration
    {
        public string FirstName = "^[A-Z]{1}[a-zA-Z]{2,}$";


        public void checkfirstname(string Firstname)
        {
            Regex Regex = new Regex(FirstName);
            if (Regex.IsMatch(Firstname))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("First Name is Invalid");
            }
        }

    }
}
