using System.ComponentModel.DataAnnotations;

namespace Forum.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
    }
}