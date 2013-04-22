using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Users
{
    public class UserRating
    {
        [Display(Name = "Користувач")]
        public string User { get; set; }

        [Display(Name="Просунутий рейтинг")]
        public int Rating { get; set; }

        [Display(Name = "Середній рейтинг файлів")]
        public int AverageRating { get; set; }
    }
}