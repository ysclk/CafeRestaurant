using CafeRestaurant.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
