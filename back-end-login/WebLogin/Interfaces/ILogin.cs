using WebLogin.Models.Request;
using WebLogin.Models.Response;

namespace WebLogin.Interfaces
{
    public interface ILogin
    {
        Task<LoginResponse> ILoginRequest(LoginRequest loginRequest);
    }
}
