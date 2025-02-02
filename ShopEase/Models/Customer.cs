using System.ComponentModel.DataAnnotations;

namespace ShopEase.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$",
            ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "First Name")]
        public string? CustomerName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$",
            ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "Last Name")]
        public string? CustomerSurname { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        [Display(Name = "Email Address")]
        public string? CustomerEmail { get; set; }
    }
}