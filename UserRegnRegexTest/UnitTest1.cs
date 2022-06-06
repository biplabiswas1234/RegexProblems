using NUnit.Framework;
using RegexExpection;

namespace UserRegistrationTesting
{
    public class Tests
    {
        Validation validation;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
        }

        [Test]
        public void firstName()
        {
            string firstName = "Biplab";
            string result = null;
            try
            {
                result = validation.First_Name(firstName);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("First Name is Valid", ex.Message);
            }
        }

        [Test]
        public void lastName()
        {
            string Name = "Biswas";
            string result = null;
            try
            {
                result = validation.Last_Name(Name);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("Last Name is Valid", ex.Message);
            }
        }

        [Test]
        public void email_Id()
        {
            string Email = "biplabiswas1234@gmail.com";
            string result = null;
            try
            {
                result = validation.EmailId(Email);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("EmailId is valid", ex.Message);
            }
        }

        [Test]
        public void Mobile_Number()
        {
            string MobileNumber = "91 9954979057";
            string result = null;
            try
            {
                result = validation.Mobile(MobileNumber);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_1()
        {
            string Password = "Biplab097";
            string result = null;
            try
            {
                result = validation.Validate_PassWord(Password);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_Firsct_One_Upper_Case()
        {
            string Password = "Biplab1234";
            string result = null;
            try
            {
                result = validation.Validate_PassWord2(Password);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_AtEnd_One_Number()
        {
            string Passwords = "Biplabiswas097";
            string result = null;
            try
            {
                result = validation.Validate_PassWord3(Passwords);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }

        [Test]
        public void Password_One_Special_Char()
        {
            string Password = "Biplabiswas@097";
            string result = null;
            try
            {
                result = validation.Validate_PassWord4(Password);
            }
            catch (RegexCustomExpection ex)
            {
                Assert.AreEqual("Password is valid", ex.Message);
            }
        }
    }
}