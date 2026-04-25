using System.ComponentModel.DataAnnotations;
using EventsApp.Common;

namespace EventsApp.ViewModels.Organizer
{
    public class OrganizerProfileViewModel
    {
        [Required]
        [StringLength(GlobalConstants.Organizer.OrganizationNameMaxLength, MinimumLength = GlobalConstants.Organizer.OrganizationNameMinLength)]
        [Display(Name = "Име на организация")]
        public string OrganizationName { get; set; } = null!;

        [StringLength(GlobalConstants.Organizer.DescriptionMaxLength)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [StringLength(GlobalConstants.Organizer.PhoneNumberMaxLength)]
        [Phone]
        [Display(Name = "Телефон")]
        public string? PhoneNumber { get; set; }

        [StringLength(GlobalConstants.Organizer.WebsiteMaxLength)]
        [Display(Name = "Уебсайт")]
        [Url]
        public string? Website { get; set; }

        [StringLength(GlobalConstants.Organizer.CompanyNumberMaxLength)]
        [Display(Name = "Фирмен номер")]
        public string? CompanyNumber { get; set; }

        public bool Approved { get; set; }
    }
}
