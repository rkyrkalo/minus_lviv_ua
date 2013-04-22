using System;
using System.ComponentModel.DataAnnotations;

namespace ClientMinus.Models.Friends
{
    public class FriendshipRequest
    {

        public string FromUser { get; set; }

        public string ToUser { get; set; }

        [StringLength(200)]
        [Display(Name = "Повідомлення")]
        public string Message { get; set; }


        public DateTime Created { get; set; }

        public DateTime Accepted { get; set; }

    }
}