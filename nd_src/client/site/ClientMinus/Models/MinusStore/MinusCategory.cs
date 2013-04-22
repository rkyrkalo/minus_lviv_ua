using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    /// Model that divides minuses by categories (greetings, for children, etc)
    /// </summary>
    public class MinusCategory
    {
        [StringLength(15)]
        [Display(Name = "Категорія")]
        public string Name { get; set; }

        [StringLength(20)]
        [Display(Name = "Відображувана назва категорії")]
        public string Display { get; set; }
    }
}