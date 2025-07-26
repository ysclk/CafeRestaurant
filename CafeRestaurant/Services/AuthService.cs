using CafeRestaurant.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class AuthService
    {
        UserService userService = new UserService();

        public AuthResult Login(string email, string password)
        {
            USER user = userService.GetUserByEmail(email);
            password = HashPassword(password);

            if (user == null)
            {
                return new AuthResult
                {
                    IsSuccess = false,
                    Message = "There is not user!"
                };
            }

            if (user.PASSWORDHASH != password )
            {
                return new AuthResult
                {
                    IsSuccess = false,
                    Message = "Password is wrong!"
                };
            }

            if (user.ISFIRSTLOGIN == true )
            {
                return new AuthResult
                {
                    IsSuccess = true,
                    Action = "ShowPasswordResetForm",
                    UserId = user.USERID,
                    UserMail= user.USEREMAIL
                };
            }

            if (user.USERROLEID == 1)
            {
                return new AuthResult
                {
                    IsSuccess = true,
                    Action = "ShowAdminForm",
                    UserId = user.USERID,
                    UserMail = user.USEREMAIL
                };
            }
            if (user.USERROLEID == 2)
            {
                return new AuthResult
                {
                    IsSuccess = true,
                    Action = "ShowOrderForm",
                    UserId = user.USERID,
                    UserMail = user.USEREMAIL
                };
            }
            return new AuthResult
            {
                IsSuccess = true,
                Action = "ShowUserForm",
                UserId = user.USERID,
              
            };
        }

        public string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                return BitConverter.ToString(bytes).Replace("-", "").ToUpper();

               
            }
        }
        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            var enteredHash = HashPassword(enteredPassword);  // Kullanıcının girdiği şifreyi tekrar hash’le
            return string.Equals(enteredHash, storedHash, StringComparison.OrdinalIgnoreCase);  // Veri tabanındakiyle karşılaştır
        }

        public AuthResult ChangePassword(int userId, string newPassword, string confirmPassword)
        {
            if (newPassword != confirmPassword)
                return new AuthResult { IsSuccess = false, Message = "The Passwords are not same!" };

            var user = userService.GetById(userId);
            if (user == null)
                return new AuthResult { IsSuccess = false, Message = "There isn't user!" };

            // Default şifre 1234 ise ve kullanıcı aynı şifreyi girmeye çalışıyorsa
            if (VerifyPassword("1234", user.PASSWORDHASH) &&
                string.Equals(newPassword, "1234", StringComparison.OrdinalIgnoreCase))
            {
                return new AuthResult { IsSuccess = false, Message = "Please change the first Password!" };
            }

            user.PASSWORDHASH = HashPassword(newPassword);
            user.ISFIRSTLOGIN = false;

            try
            {
                userService.Update(user);
                return new AuthResult { IsSuccess = true, Message = "Change is successful!", UserId = userId };
            }
            catch (Exception ex)
            {
                return new AuthResult { IsSuccess = false, Message = "Update is unsuccessful: " + ex.Message };
            }
        }
    }

}
