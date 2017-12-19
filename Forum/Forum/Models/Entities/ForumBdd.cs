using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ForumBdd:DbContext
    {
        public ForumBdd():base("name=ForumBdd")
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<LikeResponse> LikesResponses { get; set; }
    }
}