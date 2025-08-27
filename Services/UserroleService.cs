using CafeRestaurant.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class UserroleService
    {
        private readonly CafeRestaurantEntities db;

        public UserroleService(CafeRestaurantEntities db)
        {
            this.db = db;

        }

        public async Task<string> GetRoleName(int roleId)
        {
             return await db.ROLES.Where(x => x.ROLEID == roleId).Select(x=>x.ROLENAME).FirstOrDefaultAsync();
        }
    }
}
