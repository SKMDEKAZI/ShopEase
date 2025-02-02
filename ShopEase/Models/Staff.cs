using System.ComponentModel.DataAnnotations;

namespace ShopEase.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$",
            ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "First Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last name must be 2-50 characters")]
        [RegularExpression(@"^[a-zA-Z\s\-']+$",
            ErrorMessage = "Only letters, spaces, hyphens, and apostrophes allowed")]
        [Display(Name = "Last Name")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [StringLength(50, ErrorMessage = "Role cannot exceed 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]+$",
            ErrorMessage = "Only letters and spaces allowed for role")]
        [Display(Name = "Staff Role")]
        public string? Role { get; set; }

        [Required(ErrorMessage = "Availability status is required")]
        [Display(Name = "Availability Status")]
        [RegularExpression(@"^(Available|Busy|Offline)$",
            ErrorMessage = "Status must be Available, Busy, or Offline")]
        public string? AvailabilityStatus { get; set; }

    }
}