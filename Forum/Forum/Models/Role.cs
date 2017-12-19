using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }        
    }
}