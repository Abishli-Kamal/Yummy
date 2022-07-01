using System.ComponentModel.DataAnnotations;

namespace TemplatePraktika.ViewModels
{
    public class LoginVM
    {
        [Required, StringLength(maximumLength: 20)]
        public string UserName { get; set; }
        [Required, StringLength(maximumLength: 40),DataType(DataType.Password)]
        public string Password { get; set; }
            
        public bool RememberMe { get; set; }
    }
}
