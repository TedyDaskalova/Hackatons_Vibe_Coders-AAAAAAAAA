using System.ComponentModel.DataAnnotations;
using EventsApp.Common;
using EventsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventsApp.ViewModels.Events
{
    public class EventCreateEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.Event.TitleMaxLength, MinimumLength = GlobalConstants.Event.TitleMinLength)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } = null!;

        [StringLength(GlobalConstants.Event.DescriptionMaxLength)]
        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Required]
        [StringLength(GlobalConstants.Event.CityMaxLength)]
        [Display(Name = "Град")]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(GlobalConstants.Event.AddressMaxLength)]
        [Display(Name = "Адрес")]
        public string Address { get; set; } = null!;

        [Required]
        [Display(Name = "Начало")]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; } = DateTime.UtcNow.AddDays(1);

        [Required]
        [Display(Name = "Край")]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; } = DateTime.UtcNow.AddDays(1).AddHours(2);

        [Required]
        [Display(Name = "Жанр")]
        public EventGenre Genre { get; set; }

        [Url]
        [StringLength(GlobalConstants.Event.ImageUrlMaxLength)]
        [Display(Name = "URL на изображение")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Одобрено")]
        public bool IsApproved { get; set; }

        public bool CanEditApproval { get; set; }
    }
}
