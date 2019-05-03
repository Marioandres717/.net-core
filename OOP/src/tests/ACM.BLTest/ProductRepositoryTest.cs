using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size 11 red nike air max",
                ProductName = "Air Max"
            };

            var actual = productRepository.Retrive(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size Set",
                ProductName = "Air Max",
                HasChanges = true
            };

            var actual = productRepository.Save(updateProduct);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted Size Set",
                ProductName = "Air Max",
                HasChanges = true
            };

            var actual = productRepository.Save(updateProduct);

            Assert.AreEqual(false, actual);
        }
    }
}
