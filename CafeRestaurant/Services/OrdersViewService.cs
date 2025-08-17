
using System;
using System.Collections.Generic;
using System.Linq;


namespace CafeRestaurant.Services
{
    public class OrdersViewService : BaseService<ORDERSVIEW>
    {
        /// <summary>
        /// Filters orders by customer name (case-insensitive).
        /// Returns all orders where the customer's name contains the provided string.
        /// </summary>
        public List<ORDERSVIEW> GetOrdersByCustomerName(List<ORDERSVIEW> listOrders, string customerName)
        {
            if (listOrders == null || string.IsNullOrWhiteSpace(customerName))
                return new List<ORDERSVIEW>();

            return listOrders
                .Where(o => !string.IsNullOrEmpty(o.CUSTOMERNAME) &&
                            o.CUSTOMERNAME.IndexOf(customerName, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        /// <summary>
        /// Filters orders by a specific order date.
        /// </summary>
        public List<ORDERSVIEW> GetOrdersByDate(List<ORDERSVIEW> listOrders, DateTime date)
        {
            if (listOrders == null)
                return new List<ORDERSVIEW>();

            return listOrders
                .Where(o => o.ORDERDATE == date.Date) // Compare only the date part
                .ToList();
        }

        /// <summary>
        /// Filters orders by order status.
        /// </summary>
        public List<ORDERSVIEW> GetOrdersByOrderStatus(List<ORDERSVIEW> listOrders, int orderStatus)
        {
            if (listOrders == null || orderStatus == 0)
                return new List<ORDERSVIEW>();

            return listOrders
                .Where(o => o.ORDERSTATUS == orderStatus)
                .ToList();
        }
    }
}