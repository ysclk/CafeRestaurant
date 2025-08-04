using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    /// <summary>
    /// Represents a data transfer object for order details, 
    /// including product, customer, category, and payment information.
    /// </summary>
    public class OrderDTO
    {
        public string CUSTOMERNAME { get; set; }
        public int CUSTOMERID { get; set; }
        public int PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        public int STOCK { get; set; }
        public decimal PRODUCTPRICE { get; set; }
   //     public string ORDERPAID { get; set; }
        public string ORDERTYPE { get; set; }
        public decimal SUBTOTAL { get; set; }
        public string ORDERNOTE { get; set; }
        public int QUANTITY { get; set; }
        public int ORDERID { get; set; }
        public int ORDERDETAILID { get; set; }
    }
}
