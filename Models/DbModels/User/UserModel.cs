using StudentLance.Models.Base;
using StudentLance.Enumerations;
using System.ComponentModel.DataAnnotations;
using StudentLance.Annotations;
using Microsoft.EntityFrameworkCore;

namespace StudentLance.Models.DbModels.User
{
    public class UserModel : BaseModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please enter your username.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter your e-mail address.")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string PhoneNumber { get; set; }

        [RequiredEnum(ErrorMessage = "User type is required")]
        [Display(Name = "User Type")]
        public UserType UserType { get; set; }
    }
}
