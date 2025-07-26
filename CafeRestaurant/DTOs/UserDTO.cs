using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    internal class UserDTO
    {
        public int USERID { get; set; }
        public string USERNAME { get; set; }
        public string USERSURNAME { get; set; }
        public string USERPHONE { get; set; }
        public string USEREMAIL { get; set; }
        public string USERADDRESS { get; set; }       
        public string ROLENAME { get; set; }
        public int ROLEID { get; set; }

    }
}
