using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Response
    {
        public int Id { get; set; }
        public Post OriginalPost { get; set; }
        public string Body { get; set; }
        public User Author { get; set; }
        public DateTime DateResp { get; set; }

    }
}