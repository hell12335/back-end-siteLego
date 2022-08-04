using Microsoft.AspNetCore.Mvc;
using WebLogin.Interfaces;
using WebLogin.Models.Request;

namespace WebLogin.Controller
{
    public class LoginController : ControllerBase
    {
        private readonly ILogin _loginRequest;
        public LoginController(LoginRequest request)
        {

        }
    }
}
