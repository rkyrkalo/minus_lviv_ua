using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Blurb
{
    public class GeoRegion
    {
        [Display(Name = "Область")]
        public string Title { get; set; }
    }
}