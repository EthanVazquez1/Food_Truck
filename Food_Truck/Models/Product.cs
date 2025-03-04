using System.ComponentModel.DataAnnotations;

namespace Food_Truck.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000")]
        public decimal Price { get; set; }
    }
}
