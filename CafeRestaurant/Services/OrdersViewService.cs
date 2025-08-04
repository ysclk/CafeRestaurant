using CafeRestaurant.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Services
{
    public class OrdersViewService : BaseService<ORDERSVIEW>
    {
     
        public List<ORDERSVIEW> GetOrdersByCustomerName(List<ORDERSVIEW> listOrders, string customerName)  
        {
            var filteredOrders = listOrders.Where(o => !string.IsNullOrEmpty(o.CUSTOMERNAME) &&
                    o.CUSTOMERNAME.IndexOf(customerName, StringComparison.OrdinalIgnoreCase) >= 0).ToList();


            return filteredOrders;

        }
        public List<ORDERSVIEW> GetOrdersByDate(List<ORDERSVIEW> listOrders, DateTime date)  
        {
            List<ORDERSVIEW> filteredOrders = new List<ORDERSVIEW>();
            if (listOrders != null && date != null)
            {
                filteredOrders   = listOrders.Where(o => o.ORDERDATE == date).ToList();    
            }     
                   
            return filteredOrders;
        } 
        public List<ORDERSVIEW> GetOrdersByOrderstatus(List<ORDERSVIEW> listOrders, int orderStatus)  
        {
            List<ORDERSVIEW> filteredOrders = new List<ORDERSVIEW>();
            if (listOrders != null && orderStatus != 0)
            {
                filteredOrders = listOrders.Where(o => o.ORDERSTATUS == orderStatus).ToList();
                
            }
            return filteredOrders;
        }

       

    }
}
