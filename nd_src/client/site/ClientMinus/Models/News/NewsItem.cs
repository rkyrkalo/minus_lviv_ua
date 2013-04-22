using System;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.News
{
    public class NewsItem
    {
        [ForeignKey("user")]
        public string User { get; set; }

        /// <summary>
        /// Get, set news title
        /// </summary>
        [StringLength(150)]
        [Display(Name="Заголовок")]
        public string Title { get; set; }

        /// <summary>
        /// Get, set Preview part
        /// </summary>
        [Display(Name="Вступна частина")]
        public string Preview { get; set; }

        /// <summary>
        /// Get, set Body content
        /// </summary>
        [Display(Name="Текст")]
        public string Body { get; set; }

        /// <summary>
        /// Default should be "true"
        /// </summary>
        [Display(Name="Дозволити коментарі")]
        public bool Allow { get; set; }

        [Display(Name="Дата публікації")]
        public DateTime PublicDate { get; set; }
    }
}