using System;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Users
{
    public class StaffTicket
    {
        [Display(Name = "Користувач")]
        public string User { get; set; }

        [Display(Name = "Тип об’єкту")]
        public string ContentType { get; set; }

        [Display(Name = "ID об’єкту")]
        public int ObjectID { get; set; }

        //'content_type', 'object_id'
        public int ContentObject { get; set; }

        public string Url { get; set; }

        [Display(Name="Повідомлення")]
        public string Message { get; set; }

        [Display(Name="Додано")]
        public DateTime AddedDate { get; set; }

        [Display(Name = "Виконано")]
        public bool Done { get; set; }
        
    }
}