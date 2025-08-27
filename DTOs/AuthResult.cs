using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.DTOs
{
    /// <summary>
    /// Represents the result of an authentication attempt, including status, messages, 
    /// and optional user information such as ID and email.
    /// </summary>
    public class AuthResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string Action { get; set; } // Örn: "ShowAdminForm", "ShowPasswordResetForm"
        public int UserId { get; set; } // Gerekirse
        public string UserMail { get; set; }

    }
}
