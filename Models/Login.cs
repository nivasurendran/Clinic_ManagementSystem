using System.ComponentModel.DataAnnotations;

namespace Clinic_ManagementSystem.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Enter UserName")]
        [Display(Name="User Name:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [Display(Name = "Password:")]
        public string Password { get; set; }
    }
}
