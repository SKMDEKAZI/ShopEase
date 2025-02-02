using System.ComponentModel.DataAnnotations;

namespace ShopEase.Models
{
    public class Aisle
    {
        [Key]
        public int AisleID { get; set; }
        [Required]
        public string? AisleName { get; set; }
        [Required]
        public string? StoreSection { get; set; }
    }
}
