using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Repositories
{
    public class OrderDetailsRepository : BaseRepository<ORDERDETAIL>
    {
        public OrderDetailsRepository(CafeRestaurantEntities db) : base(db)
        {
        }
    }
}
