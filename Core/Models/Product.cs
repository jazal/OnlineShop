using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }

        public decimal Price { get; set; }

    }
}
