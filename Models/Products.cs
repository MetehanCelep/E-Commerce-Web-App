using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_TicaretSitesi.Models
{
    [Table("Urunler")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public bool Stock { get; set; }
        public string Image { get; set; }
        public bool IsAddedToBasket { get; set; }
    }
}
