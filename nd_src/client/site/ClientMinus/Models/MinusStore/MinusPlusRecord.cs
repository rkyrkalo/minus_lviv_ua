using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    ///  Plus-records that are uploaded to the site and attached to minuses
    /// </summary>
    public class MinusPlusRecord
    {
        public MinusRecord Minus { get; set; }

        public string User { get; set; }

        [Display(Name = "Файл", Description = "Бітрейт файлу буде знижено")]
        public object File { get; set; }

    }
}