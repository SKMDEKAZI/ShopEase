using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEase.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Admin name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Admin name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$",
            ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "Admin Name")]
        public string? AdminName { get; set; }

        [Required(ErrorMessage = "Admin surname is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Admin surname must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$",
            ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "Admin Surname")]
        public string? AdminSurname { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8,
            ErrorMessage = "Password must be 8-100 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain uppercase, lowercase, number, and special character")]
        [Display(Name = "Admin Password")]
        public string? AdminPassword { get; set; }
    }
}
