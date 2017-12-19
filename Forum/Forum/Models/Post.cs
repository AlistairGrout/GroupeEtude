using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Post
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public Categorie Categorie { get; set; }
        public DateTime Date { get; set; }
    }
}