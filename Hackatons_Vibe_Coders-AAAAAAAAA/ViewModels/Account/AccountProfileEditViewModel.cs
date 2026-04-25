using System.ComponentModel.DataAnnotations;
using EventsApp.Common;

namespace EventsApp.ViewModels.Account
{
    public class AccountProfileEditViewModel
    {
        [Required]
        [StringLength(GlobalConstants.User.UserNameMaxLength, MinimumLength = GlobalConstants.User.UserNameMinLength)]
        [RegularExpression(@"^[A-Za-z0-9._]+$", ErrorMessage = "Потребителското име може да съдържа само букви, цифри, точки и долни черти.")]
        [Display(Name = "Потребителско име")]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [Display(Name = "Имейл")]
        public string Email { get; set; } = null!;

        [StringLength(GlobalConstants.User.FirstNameMaxLength)]
        [Display(Name = "Име")]
        public string? FirstName { get; set; }

        [StringLength(GlobalConstants.User.LastNameMaxLength)]
        [Display(Name = "Фамилия")]
        public string? LastName { get; set; }

    }
}
