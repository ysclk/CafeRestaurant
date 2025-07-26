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
    internal class OrderDTO
    {
        public int PRODUCTID { get; set; }
        public string PRODUCTNAME { get; set; }
        public int QUANTITY { get; set; }
        public decimal PRODUCTPRICE { get; set; }
        public decimal SUBTOTAL { get; set; }
        public string ORDERNOTE { get; set; }
        public int CUSTOMERID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public string ISPAID { get; set; }
        public string ORDERTYPE { get; set; }
        public int CATEGORYID {  get; set; }
        public string CATEGORYNAME {  get; set; }        
   
       
      
      

    }
}
