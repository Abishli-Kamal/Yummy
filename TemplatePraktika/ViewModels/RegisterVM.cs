using System.ComponentModel.DataAnnotations;

namespace TemplatePraktika.ViewModels
{
    public class RegisterVM
    {
        [Required ,StringLength(maximumLength:20)]
        public string FirstName { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string LastName { get; set; }
        [Required, StringLength(maximumLength: 20)]
        public string UserName { get; set; }
        [Required, StringLength(maximumLength: 40)]
        public string Email { get; set; }
        [Required, StringLength(maximumLength: 30),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, StringLength(maximumLength: 30), DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
