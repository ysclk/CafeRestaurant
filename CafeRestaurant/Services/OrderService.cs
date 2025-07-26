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
        public List<OrderDTO> UpdateOrderWithDetails(string customerPhone, DateTime date )
        {
            var result = db.Database.SqlQuery<OrderDTO>(
                "EXEC SP_ORDERWITHCUSTPHONE @USERPHONE, @DATEDAY",
                new SqlParameter("@USERPHONE", customerPhone),
                new SqlParameter("@DATEDAY", date)
            ).ToList();
            return result;
        }
    }
}
