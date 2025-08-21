using CafeRestaurant.DTOs;
using CafeRestaurant.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestaurant.Services
{
    public class AuthService
    {
        UserService _userService = new UserService(new CafeRestaurantEntities());

        
             // DI için interface

            public AuthService()
            {
                
            }

            /* ---------- 1 ---------- */
            public async Task<int> UserIdAsync(string email)
            {
                var user = await _userService.GetUserByEmailAsync(email);
                return user.USERID;
            }

            /* ---------- 2 ---------- */
            public async Task<AuthResult> LoginAsync(string email, string password)
            {
                var user = await _userService.GetUserByEmailAsync(email);
                if (user == null)
                    return new AuthResult { IsSuccess = false, Message = "There is not user!" };

                var hashed = HashPassword(password);
                if (!string.Equals(user.PASSWORDHASH, hashed, StringComparison.OrdinalIgnoreCase))
                    return new AuthResult { IsSuccess = false, Message = "Password is wrong!" };

            string action;
            switch (user.USERROLEID)
            {
                case 1:
                case 2:
                    action = "ShowAdminForm";
                    break;
                default:
                    action = "ShowAdminForm";
                    break;
            }

            return new AuthResult
                {
                    IsSuccess = true,
                    Action = (bool)user.ISFIRSTLOGIN ? "ShowPasswordResetForm" : action,
                    UserId = user.USERID,
                    UserMail = user.USEREMAIL
                };
            }

            /* ---------- 3 ---------- */
            public async Task<AuthResult> ChangePasswordAsync(int userId, string newPassword, string confirmPassword)
            {
                if (newPassword != confirmPassword)
                    return new AuthResult { IsSuccess = false, Message = "The Passwords are not same!" };

                var user = await _userService.GetByIdAsync(userId);
                if (user == null)
                    return new AuthResult { IsSuccess = false, Message = "There isn't user!" };

                if (VerifyPassword("1234", user.PASSWORDHASH) &&
                    string.Equals(newPassword, "1234", StringComparison.OrdinalIgnoreCase))
                    return new AuthResult { IsSuccess = false, Message = "Please change the first Password!" };

                user.PASSWORDHASH = HashPassword(newPassword);
                user.ISFIRSTLOGIN = false;

                await _userService.UpdateAsync(user);
                return new AuthResult { IsSuccess = true, Message = "Change is successful!", UserId = userId };
            }

            /* ---------- Helpers (sync) ---------- */
            private static string HashPassword(string password)
            {
                var sha256 = SHA256.Create();
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
            }

            public bool VerifyPassword(string enteredPassword, string storedHash)
                => string.Equals(HashPassword(enteredPassword), storedHash, StringComparison.OrdinalIgnoreCase);
        }

    }
