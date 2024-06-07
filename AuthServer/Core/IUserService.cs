namespace AuthServer.Core
{
    public interface IUserService
    {
        User GetUserByUsername(string username);
        void CreateUser(User user);
        bool ValidateUserCredentials(string username, string password);
    }
}
