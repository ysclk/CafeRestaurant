using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CafeRestaurant.Models;
using System.Windows.Forms;

namespace CafeRestaurant.Services
{
    internal class OrderDetailService : BaseService<ORDERDETAIL>
    {
        /// <summary>
        /// Marks an order detail as delivered by setting its status to 2.
        /// </summary>
        /// <param name="orderDetailId">The ID of the order detail to update.</param>
        public void MarkOrderAsDelivered(int orderDetailId)
        {
            var order = db.ORDERDETAIL.FirstOrDefault(o => o.ORDERDETAILID == orderDetailId);

            if (order == null)
                throw new Exception("Order not found.");

            order.ORDERSTATUS = 2; // Status 2 = Delivered
            db.SaveChanges();
        }

        /// <summary>
        /// Cancels an order by setting its status to 3 and shows a confirmation message.
        /// </summary>
        /// <param name="orderDetailId">The ID of the order detail to cancel.</param>
        public void CancelOrder(int orderDetailId)
        {
            var order = db.ORDERDETAIL.FirstOrDefault(o => o.ORDERDETAILID == orderDetailId);

            if (order == null)
                throw new Exception("Order not found.");

            order.ORDERSTATUS = 3; // Status 3 = Canceled
            db.SaveChanges();

            // Notify the user that the order has been canceled
            MessageBox.Show("Order has been canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
