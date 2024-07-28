namespace AppStarbucks.Services;

public interface IAuthService
{
    Task<bool> IsUserAuthenticated();
}
public class AuthService : IAuthService
{
    public async Task<bool> IsUserAuthenticated()
    {
        return true;
    }
}
