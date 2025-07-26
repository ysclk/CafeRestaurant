using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    /// <summary>
    /// Represents a data transfer object used for displaying order information,
    /// including customer details, product, payment status, and order metadata.
    /// </summary>
    internal class OrdersViewDTO
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
