using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.common;
using System.Collections.Generic;
using ACM.BL;
namespace Acme.commonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "mario@gmail.com",
                FirstName = "Mario",
                LastName = "Rendon",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with steel head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            LogginService.WriteToFile(changedItems);
        }
    }
}
