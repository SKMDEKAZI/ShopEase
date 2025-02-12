using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace ShopEase.Models
{
    public class Staff : IdentityUser<int>
    {
        [Key]
        [Column("StaffID")] // Ensures it remains StaffID in the database
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Prevents it from being treated as an Identity column
        public int StaffID
        {
            get => Id;  // Maps to IdentityUser<int> Id
            set => Id = value;
        }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$", ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "First Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$", ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "Last Name")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [StringLength(50, ErrorMessage = "Role cannot exceed 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only letters and spaces allowed for role")]
        [Display(Name = "Staff Role")]
        public string? Role { get; set; }

        [Required(ErrorMessage = "Availability status is required")]
        [Display(Name = "Availability Status")]
        [RegularExpression(@"^(Available|Busy|Offline)$", ErrorMessage = "Status must be 'Available', 'Busy', or 'Offline'")]
        public string? AvailabilityStatus { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be 3-50 characters")]
        public override string UserName { get; set; } = string.Empty;

        [NotMapped]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be 8-100 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain uppercase, lowercase, number, and special character")]
        public string? Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }
    }
}
