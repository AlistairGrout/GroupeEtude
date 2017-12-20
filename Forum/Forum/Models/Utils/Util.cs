using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models.Utils
{
    public class Util
    {
        private static Util instance;
        public static Util Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Util();
                }
                return instance;
            }
        }


        public ForumBdd DB()
        {
            return new ForumBdd();
        }

        public void GenerateDB()
        {
            DB().Entry(new User { Username = "test" });
        }
    }
}