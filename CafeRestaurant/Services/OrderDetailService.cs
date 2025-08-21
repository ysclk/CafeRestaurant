using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeRestaurant.Services
{
    public class OrderDetailService : BaseService<ORDERDETAIL>
    {
        public OrderDetailService(CafeRestaurantEntities db) : base(db)
        {
        }


        /// <summary>
        /// Marks an order detail as delivered by setting its status to 2.
        /// </summary>
        /// <param name="orderDetailId">The ID of the order detail to update.</param>
        public async Task MarkOrderAsDeliveredAsync(int orderDetailId)
        {
            var order = await db.ORDERDETAIL
                                .FirstOrDefaultAsync(o => o.ORDERDETAILID == orderDetailId);

            if (order == null)
                throw new Exception("Order not found.");

            order.ORDERSTATUS = 2; // Delivered
            await db.SaveChangesAsync();
        }

        /// <summary>
        /// Cancels an order by setting its status to 3.
        /// </summary>
        /// <param name="orderDetailId">The ID of the order detail to cancel.</param>
        public async Task CancelOrderAsync(int orderDetailId)
        {
            var order = await db.ORDERDETAIL
                                .FirstOrDefaultAsync(o => o.ORDERDETAILID == orderDetailId);

            if (order == null)
                throw new Exception("Order not found.");

            order.ORDERSTATUS = 3; // Canceled
            await db.SaveChangesAsync();
        }
    }
}
