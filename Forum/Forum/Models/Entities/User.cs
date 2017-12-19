using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class User
    {
        public int Id { get; set;}
        [MaxLength(25)]
        public string Username { get; set; }
        [MaxLength(25)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime SubscriptionDate { get; set; }
        [DataType(DataType.Url)]
        [MaxLength(70)]
        public string FacebookLink { get; set; }
        [DataType(DataType.Url)]
        [MaxLength(70)]
        public string TwitterLink { get; set; }
        [DataType(DataType.Url)]
        [MaxLength(70)]
        public string LinkedinLink { get; set; }
        [MaxLength(70)]
        [DataType(DataType.Url)]
        public string Website { get; set; }
        public Role Role { get; set; }

    }
}