using CafeRestaurant.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CafeRestaurant.Services
{
    internal class OrderService : BaseService<ORDER>
    {
        /// <summary>
        /// Retrieves orders with details for a specific customer phone and date.
        /// Uses the stored procedure SP_ORDERWITHCUSTPHONE.
        /// </summary>
        public List<OrderDTO> UpdateOrderWithDetails(string customerPhone, DateTime date)
        {
            var result = db.Database.SqlQuery<OrderDTO>(
                "EXEC SP_ORDERWITHCUSTPHONE @USERPHONE, @DATEDAY",
                new SqlParameter("@USERPHONE", customerPhone),
                new SqlParameter("@DATEDAY", date)
            ).ToList();

            return result;
        }

        /// <summary>
        /// Retrieves orders along with order details for a specific customer phone, user role, and date.
        /// Uses the stored procedure SP_ORDERANDORDERDETAILS.
        /// </summary>
        public List<OrderDTO> UpdateOrder(string customerPhone, int userRole, DateTime date)
        {
            var result = db.Database.SqlQuery<OrderDTO>(
                "EXEC SP_ORDERANDORDERDETAILS @USERPHONE, @USERROLEID, @DATEDAY",
                new SqlParameter("@USERPHONE", customerPhone),
                new SqlParameter("@USERROLEID", userRole),
                new SqlParameter("@DATEDAY", date)
            ).ToList();

            return result;
        }
    }
}
