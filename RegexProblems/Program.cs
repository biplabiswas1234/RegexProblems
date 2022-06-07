using RegexExpection;
using System;

namespace RegexLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation userRegistration = new Validation();
            int option = 0;
            do
            {
                Console.WriteLine("1: For First name validation");
                Console.WriteLine("2: For Last name validation");
                Console.WriteLine("3: For Email validation");
                Console.WriteLine("4: For Mobile Number");
                Console.WriteLine("5: For Password Min Eight Char");
                Console.WriteLine("6: For Password At Least One Upper Case");
                Console.WriteLine("7: For Password At Least One Number");
                Console.WriteLine("8: For Password One Special Char");
                Console.WriteLine("9: For Email");
                Console.WriteLine("0: To stop");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        Console.WriteLine("Enter a First Name");
                        string FirstName = Console.ReadLine();
                        userRegistration.First_Name(FirstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter a Last Name");
                        string LastName = Console.ReadLine();
                        userRegistration.Last_Name(LastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter your EmailId: ");
                        string EmailId = Console.ReadLine();
                        userRegistration.EmailId(EmailId);
                        break;
                    case 4:
                        Console.WriteLine("Enter a Mobile Number");
                        string MobileNumber = Console.ReadLine();
                        userRegistration.Mobile(MobileNumber);
                        break;
                    case 5:
                        Console.WriteLine("Enter a Password");
                        string PasswordOne = Console.ReadLine();
                        userRegistration.Validate_PassWord(PasswordOne);
                        break;
                    case 6:
                        Console.WriteLine("Enter a Password");
                        string PasswordTwo = Console.ReadLine();
                        userRegistration.Validate_PassWord2(PasswordTwo);
                        break;
                    case 7:
                        Console.WriteLine("Enter a Password");
                        string PasswordThree = Console.ReadLine();
                        userRegistration.Validate_PassWord3(PasswordThree);
                        break;
                    case 8:
                        Console.WriteLine("Enter a Password");
                        string PasswordFour = Console.ReadLine();
                        userRegistration.Validate_PassWord4(PasswordFour);
                        break;

                    case 9:
                        Console.WriteLine("Enter  Email");
                        string email = Console.ReadLine();
                        userRegistration.Validate_AllEmails(email);
                        break;

                    case 0:
                        option = 0;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (option != 0);
        }
    }
}