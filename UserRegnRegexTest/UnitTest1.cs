using NUnit.Framework;
using RegexProblems;

namespace UserRegnRegexTest
{

    public class Tests
    {
        UserRegistration registration;
        [SetUp]
        public void Setup()
        {
            registration = new UserRegistration();
        }

        [Test]
        public void ValidFirstName()
        {
            string FirstName = "Biplab";
            string expected = "First Name is valid";

            string actual = registration.checkFirstName(FirstName);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidLastName()
        {
            string LastName = "Biswas";
            string expected = "Last Name is valid";

            string actual = registration.checkLastName(LastName);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidEmail()
        {
            string Email = "biplabiswas1234@gmail.com";
            string expected = "Email is valid";

            string actual = registration.checkEmail(Email);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidNumber()
        {
            string Mobile = "+91 9954979057";
            string expected = "Mobile Number is valid";

            string actual = registration.ValidateMobileNum(Mobile);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidPassword()
        {
            string Password = "Biplab123@784114";
            string expected = "Password is valid";

            string actual = registration.ValidatePassWord4(Password);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidateEmail()
        {
            string email = "xyz123@gmail.com";
            string expected = "Email is valid";

            string actual = registration.ValidateAllEmail(email);

            Assert.AreEqual(expected, actual);
        }
    }

}