using System.Linq;
using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    internal class UserroleService:BaseService<ROLES>
    {
        public string GetRoleName(int roleId)
        {
            return db.ROLES.Where(x => x.ROLEID == roleId).Select(x=>x.ROLENAME).FirstOrDefault();
        }
    }
}
