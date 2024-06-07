using System;
using Microsoft.IdentityModel.Tokens;

namespace AuthServer
{
    public static class Secret
    {
        public static readonly string Key = GenerateRandomKey();

        private static string GenerateRandomKey()
        {
            var key = new byte[32];
            using (var generator = System.Security.Cryptography.RandomNumberGenerator.Create())
            {
                generator.GetBytes(key);
                return Convert.ToBase64String(key);
            }
        }

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Convert.FromBase64String(Key));
        }
    }
}
