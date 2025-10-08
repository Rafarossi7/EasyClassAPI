using System.ComponentModel.DataAnnotations;

namespace EasyClassAPI.DTO
{
    public class RegisterDto
    {

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "A senha é obrigatória")]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "A senha e a confirmação não coincidem")]
        public string? ConfirmPassword { get; set; }



    }
}
