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
        public string EmailAddress = "^[A-Za-z0-9]{3,}@[A-Za-z]{3,}.[a-zA-Z]{2,}$";
        public string MobileNum = "^[+][0-9]{2}[ ][0-9]{10}$";
        public string PassWord = "^[A-z0-9a-z@#&*+]{8,}$";
        public string PassWord2 = "^[A-Z]{1,}[A-z0-9a-z@#&*+.,]{8,}$";
        public string PassWord3 = "^[A-Z]{1,}[0-9A-Za-z!@#$.,';%^&*-]{6,}[0-9]{1,}$";
        public string PassWord4 = "^[A-Z]{1,}[A-Za-z0-9]{5,}[!@#$%.,'-^&*+]{1}[0-9]{1,}$";

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
        public void ValidateMobileNum(string Mobile_Num)
        {
            Regex regex = new Regex(MobileNum);
            if (regex.IsMatch(Mobile_Num))
            {
                Console.WriteLine("Mobile Number is Valid :" + Mobile_Num);
            }
            else
            {
                Console.WriteLine("Mobile Number is invalid");
            }
        }
        public void ValidatePassWord1(string passWord)
        {
            Regex regex = new Regex(PassWord);
            if (regex.IsMatch(passWord))
            {
                Console.WriteLine("PassWord is valid :" + passWord);
            }
            else
            {
                Console.WriteLine("PassWord is invalid");
            }
        }
        public void ValidatePassWord2(string passWord)
        {
            Regex regex = new Regex(PassWord2);
            if (regex.IsMatch(passWord))
            {
                Console.WriteLine("PassWord is valid :" + passWord);
            }
            else
            {
                Console.WriteLine("PassWord is invalid");
            }
        }
        public void ValidatePassWord3(string passWord)
        {
            Regex regex = new Regex(PassWord3);
            if (regex.IsMatch(passWord))
            {
                Console.WriteLine("PassWord is valid :" + passWord);
            }
            else
            {
                Console.WriteLine("PassWord is invalid");
            }
        }
        public void ValidatePassWord4(string passWord)
        {
            Regex regex = new Regex(PassWord4);
            if (regex.IsMatch(passWord))
            {
                Console.WriteLine("PassWord is valid :" + passWord);
            }
            else
            {
                Console.WriteLine("PassWord is invalid");
            }
        }
    }
}


