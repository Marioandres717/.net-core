using System;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrive(int orderId)
        {
            var order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save(Order Order)
        {
            return true;
        }
    }
}