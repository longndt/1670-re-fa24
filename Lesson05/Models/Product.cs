using System.ComponentModel.DataAnnotations;

namespace Lesson05.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Image { get; set; }

        [Range(50, 1000)]
        public decimal Price { get; set; }
    }
}
