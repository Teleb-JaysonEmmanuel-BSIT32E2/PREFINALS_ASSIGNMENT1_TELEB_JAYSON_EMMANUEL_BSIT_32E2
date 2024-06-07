using System.Collections.Generic;
using System.Linq;
using AuthServer.Core;

namespace AuthServer.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public User GetUserByUsername(string username)
        {
            return _users.SingleOrDefault(u => u.Username == username);
        }

        public void CreateUser(User user)
        {
            _users.Add(user);
        }

        public bool ValidateUserCredentials(string username, string password)
        {
            var user = GetUserByUsername(username);
            if (user == null)
            {
                return false;
            }

            // You should use a proper password hashing method here
            return user.PasswordHash == password;
        }
    }
}
