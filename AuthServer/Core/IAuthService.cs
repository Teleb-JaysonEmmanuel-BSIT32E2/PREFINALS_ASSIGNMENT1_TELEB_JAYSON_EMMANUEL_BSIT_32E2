namespace AuthServer.Core
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user);
    }
}
