using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Mario",
                LastName = "Rendon"
            };
            string expected = "Rendon, Mario";
            

            // Act
            string actual = customer.FullName;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                LastName = "Rendon"
            };
            string expected = "Rendon";

            // Act
            string actual = customer.FullName;

            // Asssert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Mario"
            };
            string expected = "Mario";

            // Act
            string actual = customer.FullName;

            // Asssert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // Arrange
            var c1 = new Customer
            {
                LastName = "Rendon"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                LastName = "Zapata"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Sofiya"
            };
            Customer.InstanceCount += 1;

            // Act

            // Asssert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new Customer
            {
                LastName = "Rendon",
                EmailAddress = "mario@gmail.com"
            };

            var expected = true;

            /* ACT */
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "mario@gmail.com"
            };

            var expected = false;

            /* ACT */
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            // Arrange
            var customer = new Customer
            {
                EmailAddress = "mario@gmail.com"
            };

            var expected = false;

            /* ACT */
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
