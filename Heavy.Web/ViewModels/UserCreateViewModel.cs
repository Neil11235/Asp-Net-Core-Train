using System.ComponentModel.DataAnnotations;

namespace Heavy.Web.ViewModels
{
    public class UserCreateViewModel
    {
        [Required]
        [Display(Name ="用户名")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
