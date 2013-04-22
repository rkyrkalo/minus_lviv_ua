using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    /// represents Original artists, that perform minused records Auto populated by adding records    
    /// </summary>
    public class MinusAuthor
    {
        [StringLength(255)]
        [Display(Name = "Ім’я автора мінусовок")]
        public string Name { get; set; }

        [Display(Name = "Типи файлів")]
        public List<FileType> FileTypes { get; set; }
    }
}