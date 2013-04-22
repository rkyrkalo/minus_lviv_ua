using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Blurb
{
    public class BlurbCategory
    {
        [Display(Name = "Категорія")]
        public string Title { get; set; }

        public object Slug { get; set; }
    }
}