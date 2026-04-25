using System.ComponentModel.DataAnnotations;
using EventsApp.Common;
using EventsApp.Models;

namespace EventsApp.ViewModels.Preferences
{
    public class PreferencesViewModel
    {
        [Display(Name = "Предпочитан жанр")]
        public EventGenre? PreferredGenre { get; set; }

        [StringLength(GlobalConstants.Preferences.PreferredCityMaxLength)]
        [Display(Name = "Предпочитан град")]
        public string? PreferredCity { get; set; }

        [Range(GlobalConstants.Preferences.MinAgeLower, GlobalConstants.Preferences.MinAgeUpper)]
        [Display(Name = "Минимална възраст")]
        public int? MinAge { get; set; }

        [Range(0, 10000)]
        [Display(Name = "Максимално разстояние (км)")]
        public int? MaxDistanceKm { get; set; }
    }
}
