using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace ClientMinus.Models.Users
{
    public class UserProfile
    {
        [Display(Name="Користувач")]
        public string User { get; set; }

        /// <summary>
        /// Get, set user sex
        /// </summary>
        [Display(Name="Стать")]
        public Gender Sex { get; set; }

        [StringLength(128)]
        [Display(Name ="Місто")]
        public string City { get; set; }

        [StringLength(128)]
        [Display(Name = "Країна")]
        public string Country { get; set; }

        [StringLength(128)]
        [Display(Name = "Аватар")]
        public ImageField Avatar { get; set; }

        [Display(Name = "Дата Народження")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Get, set hide birthday
        /// </summary>
        [Display(Name="Приховати дату народження")]
        public bool HideBirthday { get; set; }

        [StringLength(10)]
        [Display(Name = "ICQ")]
        public string Icq { get; set; }

        [StringLength(128)]
        [Display(Name = "Jabber")]
        public string Jabber { get; set; }

        [StringLength(128)]
        [Display(Name="Skype")]
        public string Skype { get; set; }

        [StringLength(128)]
        [Display(Name = "Вебсайт")]
        public string WebSite { get; set; }

        /// <summary>
        /// Get, set about user
        /// </summary>
        [Display(Name="Про себе")]
        public string About { get; set; }

        /// <summary>
        /// Get, set information from admin
        /// </summary>
        [Display(Name = "Отримувати листи від адміністрації")]
        public bool AdminSubscribed { get; set; }

        /// <summary>
        /// Get, set user status
        /// </summary>
        [StringLength(20)]
        [Display(Name = "Статуc користувача")]
        public string StatusField { get; set; }

        /// <summary>
        /// Get, set user css style
        /// </summary>
        [StringLength(20)]
        [Display(Name = "CSS-стиль для статусу")]
        public string StatusCss { get; set; }

        /// <summary>
        /// Get, set if user is banned
        /// </summary>
        [Display(Name = "Користувача забанено")]
        public bool Banned { get; set; }

        /// <summary>
        /// Get, set until user is banned
        /// </summary>
        public bool BannedUntil { get; set; }

        [Display(Name = "Ознайомився з правилами")]
        public bool SeenRules { get; set; }
    
    }
}