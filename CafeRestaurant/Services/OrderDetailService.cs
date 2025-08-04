using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Services
{
    internal class OrderDetailService:BaseService<ORDERDETAIL>
    {

        public void MarkOrderAsDelivered(int orderDetailId)
        {
           
                var order = db.ORDERDETAIL.FirstOrDefault(o => o.ORDERDETAILID == orderDetailId);

                if (order == null)
                    throw new Exception("Null");

                if (order != null) order.ORDERSTATUS = 2;

                db.SaveChanges();
            
        }

        public void CancelOrder(int orderDetailId)
        {
          
                var order = db.ORDERDETAIL.FirstOrDefault(o => o.ORDERDETAILID == orderDetailId);

                if (order == null)
                    throw new Exception("Null");

                if (order != null) order.ORDERSTATUS = 3;
                db.SaveChanges();
                MessageBox.Show("Sipariş iptal edildi.");
            
        }
    }
}
