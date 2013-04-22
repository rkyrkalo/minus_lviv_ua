using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Activation;

namespace ClientMinus.Models.Links
{
    public class FriendLink
    {
        [StringLength(256)]
        [Display(Name = "Назва сайту")]
        public string Title { get; set; }

        [StringLength(256)]
        [Display(Name = "Адреса сайту")]
        public string Site { get; set; }

        [StringLength(256)]
        [Display(Name = "Розділ")]
        public FriendLinkCategory Category { get; set; }

        [StringLength(256)]
        [Display(Name = "Короткий опис сайту")]
        public string Description { get; set; }

        [Display(Name = "Код графічної кнопки")]
        public string ImageCode { get; set; }

        [StringLength(512)]
        [Display(Name = "Адреса сторінки де буде розміщено наш банер")]
        public string BannerPage { get; set; }

        [StringLength(128)]
        [Display(Name = "Контактний E-Mail")]
        public string Email { get; set; }

        [Display(Name = "Підтвердити")]
        public bool Approved { get; set; }

        [Display(Name="Створено")]
        public DateTime DateCreate { get; set; }

        [Display(Name="Підтвердженно")]
        public DateTime DateApproved { get; set; }

        [Display(Name="Власник баннеру отпримав повідомлення про розміщення його коду на сайті")]
        public bool Notified { get; set; }
    }
}