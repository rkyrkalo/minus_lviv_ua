using System;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Blurb
{
    public class Blurb
    {
        [StringLength(120)]
        [Display(Name = "Назва товару")]
        public string Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Опис товару")]
        public string Descriptio { get; set; }

        [Display(Name = "Куплю/продам")]
        public BuySell BuySell { get; set; }

        public string User { get; set; }  //'auth.User'

        [Display(Name = "Область")]
        public GeoRegion GeoRegion { get; set; }

        [Display(Name = "Місто")]
        public GeoCity GeoCity { get; set; }

        [Display(Name = "Категорія")]
        public BlurbCategory Category { get; set; }

        public DateTime PubDate { get; set; }

    }
}