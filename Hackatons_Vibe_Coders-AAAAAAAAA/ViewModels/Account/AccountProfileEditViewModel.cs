using System.ComponentModel.DataAnnotations;
using EventsApp.Common;

namespace EventsApp.ViewModels.Account
{
    public class AccountProfileEditViewModel
    {
        [Required]
        [StringLength(GlobalConstants.User.UserNameMaxLength, MinimumLength = GlobalConstants.User.UserNameMinLength)]
        [RegularExpression(@"^[A-Za-z0-9._]+$", ErrorMessage = "Username may contain only letters, numbers, dots, and underscores.")]
        [Display(Name = "Username")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [StringLength(GlobalConstants.User.FirstNameMaxLength)]
        [Display(Name = "First name")]
        public string? FirstName { get; set; }

        [StringLength(GlobalConstants.User.LastNameMaxLength)]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }

    }
}
