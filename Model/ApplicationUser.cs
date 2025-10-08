using Microsoft.AspNetCore.Identity;

namespace EasyClassAPI.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string Nome { get; set; }

 
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
