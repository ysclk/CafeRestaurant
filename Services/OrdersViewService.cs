
using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace CafeRestaurant.Services
{
    public class OrdersViewService 
    {
        private readonly CafeRestaurantEntities db;

        public OrdersViewService(CafeRestaurantEntities db)
        {
            this.db = db;
        }



        public virtual async Task<List<ORDERSVIEW>> GetAllAsync()
        {
            var context = new CafeRestaurantEntities();
            return await context.Set<ORDERSVIEW>().ToListAsync();
        }

        /// <summary>
        /// Retrieves orders filtered by customer name (case-insensitive).
        /// </summary>
        /// <param name="customerName">The name or part of the name of the customer to search for.</param>
        /// <returns>A list of orders where the customer name contains the specified value.</returns>
        public async Task<List<ORDERSVIEW>> GetOrdersByCustomerNameAsync(List<ORDERSVIEW> listOrders, string customerName)
        {
            if (listOrders == null || string.IsNullOrWhiteSpace(customerName))
                return new List<ORDERSVIEW>();

            // CPU-bound işlem olduğu için Task.Run ile thread-pool'a taşıyoruz.
            return await Task.Run(() =>
                listOrders
                    .Where(o => !string.IsNullOrEmpty(o.CUSTOMERNAME) &&
                                o.CUSTOMERNAME.IndexOf(customerName, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList());
        }

        /// <summary>
        /// Retrieves orders filtered by a specific date.
        /// Only the date part of ORDERDATE is compared.
        /// </summary>
        /// <param name="date">The date to filter orders by.</param>
        /// <returns>A list of orders that match the specified date.</returns>
        public async Task<List<ORDERSVIEW>> GetOrdersByDateAsync(List<ORDERSVIEW> listOrders, DateTime date)
        {
            if (listOrders == null)
                return new List<ORDERSVIEW>();

            return await Task.Run(() =>
                listOrders
                    .Where(o => o.ORDERDATE == date.Date)   // Compare only the date part
                    .ToList());
        }

        /// <summary>
        /// Retrieves orders filtered by order status.
        /// </summary>
        /// <param name="orderStatus">The status value to filter orders by (e.g., 1=Pending, 2=Delivered, 3=Canceled).</param>
        /// <returns>A list of orders that have the specified status.</returns>
        public async Task<List<ORDERSVIEW>> GetOrdersByOrderStatusAsync(List<ORDERSVIEW> listOrders, int orderStatus)
        {
            if (listOrders == null || orderStatus == 0)
                return new List<ORDERSVIEW>();

            return await Task.Run(() =>
                listOrders
                    .Where(o => o.ORDERSTATUS == orderStatus)
                    .ToList());
        }
    }
}