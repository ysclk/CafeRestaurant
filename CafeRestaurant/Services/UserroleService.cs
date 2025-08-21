using CafeRestaurant.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class UserroleService:BaseService<ROLES>
    {
        public UserroleService(CafeRestaurantEntities db) : base(db)
        {
        }

        public async Task<string> GetRoleName(int roleId)
        {
             return await db.ROLES.Where(x => x.ROLEID == roleId).Select(x=>x.ROLENAME).FirstOrDefaultAsync();
        }
    }
}
