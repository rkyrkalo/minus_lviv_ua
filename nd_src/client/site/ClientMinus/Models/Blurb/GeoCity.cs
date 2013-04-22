using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Blurb
{
    public class GeoCity
    {
        [StringLength(30)]
        [Display(Name="Місто")]
        public string Title { get; set; }
        
        public GeoRegion Region { get; set; }
        
        public bool City { get; set; }
        
    }
}