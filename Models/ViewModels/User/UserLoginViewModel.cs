using StudentLance.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace StudentLance.Models.ViewModels.User
{
    public class UserLoginViewModel : BaseModel, IValidatableObject
    {
        [Required(ErrorMessage = "Please enter your username.")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsConfirmed { get; set; } = true;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (IsConfirmed is false)
            {
                yield return new ValidationResult("Username or password is incorrect!");
            }
        }
    }
}
