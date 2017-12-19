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
<<<<<<< HEAD
        public DbSet<Role> Roles { get; set; }
        public DbSet<Post> Posts { get; set; }

=======
        public DbSet<Category> Categories { get; set; }
>>>>>>> d75f77cc82726f55e10d9d4fe6cb674f1c8fa85d

    }
}