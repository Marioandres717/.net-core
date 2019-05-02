namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }
        public OrderItem(int orderItemId)
        {   
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurcharsePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurcharsePrice == null) isValid = false;

            return isValid;
        }
    }
}