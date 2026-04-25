using System.ComponentModel.DataAnnotations;
using EventsApp.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventsApp.ViewModels.Posts
{
    public class PostCreateEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(GlobalConstants.Post.ContentMaxLength, MinimumLength = GlobalConstants.Post.ContentMinLength)]
        [Display(Name = "Съдържание")]
        public string Content { get; set; } = null!;

        [Display(Name = "Свързано събитие (по избор)")]
        public int? EventId { get; set; }

        [Display(Name = "Снимка или видео")]
        public IFormFile? MediaFile { get; set; }

        [Display(Name = "Или URL на изображение")]
        [StringLength(GlobalConstants.Post.ImageUrlMaxLength)]
        public string? ImageUrl { get; set; }

        public string? CurrentMediaUrl { get; set; }

        public IEnumerable<SelectListItem> Events { get; set; } = Array.Empty<SelectListItem>();
    }
}
