using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Links
{
    public class FriendLinkCategory
    {
        [StringLength(256)]
        [Display(Name = "Назва категорії")]
        public string Name { get; set; }
    }
}