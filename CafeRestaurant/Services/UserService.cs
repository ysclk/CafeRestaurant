using CafeRestaurant.DTOs;
using CafeRestaurant.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class UserService : BaseService<USER>
    {
        public UserService(CafeRestaurantEntities db) : base(db)
        {
        }


        /// <summary>
        /// Get a list of users with the same role asynchronously
        /// </summary>
        /// <param name="userRoleId">Role ID to filter users</param>
        /// <returns>List of users with Fullname, USERID, and Phone</returns>
        public async Task<List<UserListItem>> UserSameRoleListAsync(int userRoleId)
        {
            var list = await (from i in db.USER
                              where i.USERROLEID == userRoleId
                              select new UserListItem
                              {
                                  Fullname = i.USERNAME + " " + i.USERSURNAME,
                                  USERID = i.USERID,
                                  Phone = i.USERPHONE
                              }).ToListAsync();

            return list;
        }

        /// <summary>
        /// Get all users with their role names asynchronously using stored procedure
        /// </summary>
        /// <returns>List of UserDTO containing user info and role name</returns>
        public async Task<List<UserDTO>> GetAllWithRoleNameAsync()
        {
            var result = await db.Database.SqlQuery<UserDTO>("EXEC sp_UsersWithRoleName").ToListAsync();
            return result;
        }

        /// <summary>
        /// Get a user entity by email asynchronously
        /// </summary>
        /// <param name="userEmail">User email</param>
        /// <returns>USER entity or null if not found</returns>
        public async Task<USER> GetUserByEmailAsync(string userEmail)
        {
            var user = await db.USER.FirstOrDefaultAsync(i => i.USEREMAIL == userEmail);
            return user;
        }

        /// <summary>
        /// Get a user entity by ID asynchronously
        /// </summary>
        /// <param name="userId">User ID</param>
        /// <returns>USER entity or null if not found</returns>
        public async Task<USER> GetUserByIDAsync(int userId)
        {
            var user = await db.USER.FirstOrDefaultAsync(i => i.USERID == userId);
            return user;
        }
    }
}
