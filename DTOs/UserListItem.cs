using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{

    /// <summary>
    /// Represents a simplified user item for display in a list,
    /// including the user's full name, ID, and phone number.
    /// </summary>
    public class UserListItem
    {
        public string Fullname { get; set; }
        public int USERID { get; set; }
        public string Phone { get; set; }
    }
}
