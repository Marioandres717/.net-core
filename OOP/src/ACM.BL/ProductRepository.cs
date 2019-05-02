namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {
            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Air Max";
                product.ProductDescription = "Assorted Size 11 red nike air max";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}