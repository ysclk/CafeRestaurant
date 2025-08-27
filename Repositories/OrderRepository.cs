using CafeRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Repositories
{
    public class OrderRepository : BaseRepository<ORDER>
    {
        public OrderRepository(CafeRestaurantEntities db) : base(db)
        {
        }
    }
}
