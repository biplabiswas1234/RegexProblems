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
                Console.WriteLine("Enter your password rule 1");
                string password = Console.ReadLine();
                userRegistration.ValidatePassWord1(password);
                Console.WriteLine("Enter your password rule 2");
                string password2 = Console.ReadLine();
                userRegistration.ValidatePassWord2(password2);
                Console.WriteLine("Enter your password rule 3");
                string password3 = Console.ReadLine();
                userRegistration.ValidatePassWord3(password3);
            }
        }
    }
}

