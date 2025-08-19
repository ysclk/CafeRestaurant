using CafeRestaurant.DTOs;
using System.Collections.Generic;
using System.Linq;
using CafeRestaurant.Models;

namespace CafeRestaurant.Services
{
    internal class UserService : BaseService<USER>
    {
        public List<UserListItem> UserSameRoleList(int userRoleId)
        {
            var list = (from i in db.USER
                        where i.USERROLEID == userRoleId
                        select new UserListItem { Fullname = i.USERNAME + " " + i.USERSURNAME, USERID = i.USERID, Phone = i.USERPHONE }).ToList();
            return list;
        }

        public List<UserDTO> GetAllWithRoleName()
        {
            return db.Database.SqlQuery<UserDTO>("EXEC sp_UsersWithRoleName").ToList();
        }

        public USER GetUserByEmail(string userEmail)
        {
            var user = (from i in db.USER
                        where i.USEREMAIL == userEmail select i).FirstOrDefault();
            return user ;
        }
        public USER GetUserByID(int userId)
        {
            var user = (from i in db.USER
                        where i.USERID == userId select i).FirstOrDefault();
            return user ;
        }

    }
}
