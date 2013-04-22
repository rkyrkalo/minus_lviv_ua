using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    /// Model that divides records by types: Example: audio, midi, text
    /// </summary>
    public class FileType
    {
        [StringLength(15)]
        [Display(Name = "Назва типу файлів")]
        public string TypeName { get; set; }

        [StringLength(20)]
        [Display(Name = "Назва що відображатиметься на сайті")]
        public string DisplayName { get; set; }

        [Display(Name = "Опис",Description = "Введіть розширення файлів через кому (mp3,wav)")]
        public string Description { get; set; }
    }
}