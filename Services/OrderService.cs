using CafeRestaurant.DTOs;
using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class OrderService
    {
        private readonly CafeRestaurantEntities db;

        public OrderService(CafeRestaurantEntities db)
        {
            this.db = db;
        }

        /// <summary>
        /// Retrieves orders with details for a specific customer phone and date.
        /// Uses the stored procedure SP_ORDERWITHCUSTPHONE.
        /// </summary>
        public async Task<List<OrderDTO>> UpdateOrderWithDetailsAsync(string customerPhone, DateTime date)
        {
            var result = await db.Database.SqlQuery<OrderDTO>(
                "EXEC SP_ORDERWITHCUSTPHONE @USERPHONE, @DATEDAY",
                new SqlParameter("@USERPHONE", customerPhone),
                new SqlParameter("@DATEDAY", date)
            ).ToListAsync();

            return result;
        }

        /// <summary>
        /// Retrieves orders along with order details for a specific customer phone, user role, and date.
        /// Uses the stored procedure SP_ORDERANDORDERDETAILS.
        /// </summary>
        public async Task<List<OrderDTO>> UpdateOrderAsync(string customerPhone, int userRole, DateTime date)
        {
            var result = await db.Database.SqlQuery<OrderDTO>(
                "EXEC SP_ORDERANDORDERDETAILS @USERPHONE, @USERROLEID, @DATEDAY",
                new SqlParameter("@USERPHONE", customerPhone),
                new SqlParameter("@USERROLEID", userRole),
                new SqlParameter("@DATEDAY", date)
            ).ToListAsync();

            return result;
        }
    }
}

