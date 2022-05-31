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
                userRegistration.checkfirstname(firstName);
            }
        }
    }
}

