using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CafeRestaurant.Models;

namespace CafeRestaurant.Repositories
{
    public class UserRoleRepository : BaseRepository<ROLES>
    {
        public UserRoleRepository(CafeRestaurantEntities db) : base(db)
        {
        }
    }
}
