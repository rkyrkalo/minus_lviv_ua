using System;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Messages
{
    public class Message
    {
        [StringLength(120)]
        [Display(Name="Заголовок")]
        public string Subject { get; set; }

        [Display(Name = "Повідомлення")]
        public string Body { get; set; }

        [Display(Name = "Відправник")]
        public string Sender { get; set; }

        [Display(Name="Одержувач")]
        public string Recipient { get; set; }

        public string ParentMessage { get; set; }

        public DateTime SentAt { get; set; }

        public DateTime ReadAt { get; set; }

        public DateTime RepliedAt { get; set; }

        public DateTime SenderDeleted { get; set; }

        public DateTime RecipientDeletedAt { get; set; }
    
    }
}