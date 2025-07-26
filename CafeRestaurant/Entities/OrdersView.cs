using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Entities
{

    /// <summary>
    /// Represents the OrdersView entity containing detailed information
    /// about orders, customers, products, and payment status for database mapping.
    /// </summary>
    internal class OrdersView
    {
        private int OrderDetailId { get; set; }
        private int OrderId { get; set; }
        private int CustomerId { get; set; }
        private string Customer { get; set; }
        private string CustomerPhone { get; set; }
        private string Product { get; set; }
        private int Quantity { get; set; }
        private decimal Subtotal { get; set; }
        private string OrderPaid { get; set; }
        private string OrderNote { get; set; }
        private string OrderDate { get; set; }
    }
}
