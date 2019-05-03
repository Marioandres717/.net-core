using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System;

namespace test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };

            var actual = orderRepository.Retrive(10);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
