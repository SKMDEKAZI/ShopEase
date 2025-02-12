
using Microsoft.AspNetCore.Identity;
using ShopEase.Models;

namespace ShopEase.Utilities
{
    public static class PasswordHelper
    {
        private static readonly PasswordHasher<Staff> _hasher = new();

        public static string HashPassword(Staff staff, string password)
        {
            return _hasher.HashPassword(staff, password);
        }

        public static bool VerifyPassword(Staff staff, string hashedPassword, string providedPassword)
        {
            return _hasher.VerifyHashedPassword(staff, hashedPassword, providedPassword)
                == PasswordVerificationResult.Success;
        }
    }
}