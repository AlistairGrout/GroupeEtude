using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class LikeResponse
    {
        public int Id { get; set; }
        public Response Response { get; set; }

        public User Voter { get; set; }
    }
}