using Newtonsoft.Json;

namespace WebLogin.Models.Request
{
    public class LoginRequest
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("senha")]
        public string Senha { get; set; }
    
    }
}
