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
        public string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string EmailAddress = "^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}";

        public void checkFirstName(string Firstname)
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
        public void checkLastName(string Lastname)
        {
            Regex regex = new Regex(LastName);
            if (regex.IsMatch(Lastname))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Last Name is Invalid");
            }
        }
        public void checkEmail(string EmailID)
        {
            Regex regex = new Regex(EmailAddress);
            if (regex.IsMatch(EmailID))
            {
                Console.WriteLine("Email is valid");
            }
            else
            {
                Console.WriteLine("Email is Invalid");
            }
        }
    }
}
    

