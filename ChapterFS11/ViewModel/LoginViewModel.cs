using System.ComponentModel.DataAnnotations;

namespace ChapterFS11.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe e-mail do usuário")]
        public string email { get; set; }

        [Required(ErrorMessage = "Informe senha do usuário")]
        public string senha { get; set; }
    }
}
