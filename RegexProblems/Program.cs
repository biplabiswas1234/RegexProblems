using System;

namespace RegexProblems
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                UserRegistration userRegistration = new UserRegistration();
                Console.WriteLine("Enter the First Name");
                string firstName = Console.ReadLine();
                userRegistration.checkFirstName(firstName);
                Console.WriteLine("Enter the last Name");
                string lastName = Console.ReadLine();
                userRegistration.checkLastName(lastName);
                Console.WriteLine("Enter the email id");
                string emailID = Console.ReadLine();
                userRegistration.checkEmail(emailID);
                Console.WriteLine("Enter the phone number");
                string phoneNum = Console.ReadLine();
                userRegistration.ValidateMobileNum(phoneNum);
            }
        }
    }
}

