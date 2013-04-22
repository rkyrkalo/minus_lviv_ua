using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    ///  Stop words, used to remove on validation
    /// </summary>
    public class MinusStopWord
    {
        [StringLength(30)]
        [Display(Name = "")]
        public string Word { get; set; }

        [Display(Name = "Блокувати")]
        public bool Blocked { get; set; }
    }
}