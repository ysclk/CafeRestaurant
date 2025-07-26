using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    /// <summary>
    /// Represents a data transfer object for product information,
    /// including product details, category, price, and stock level.
    /// </summary>

    internal class ProductDTO
    {
        public int PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        public string Category { get; set; }
        public decimal PRODUCTPRICE { get; set; }
        public int STOCK { get; set; }
        public int CATEGORYID { get; set; }

    }
}
