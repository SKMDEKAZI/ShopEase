using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEase.Models
{
    public class Feedback
    {
        [Key]
        [Display(Name = "Feedback ID")]
        public int FeedbackID { get; set; }  // Corrected spelling

        [Required(ErrorMessage = "Request reference is required")]
        [ForeignKey("CustomerRequest")]
        [Display(Name = "Request ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid request ID")]
        public int RequestID { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1-5 stars")]
        [Display(Name = "Customer Rating")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(500, MinimumLength = 5,
            ErrorMessage = "Comments must be 5-500 characters")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Customer Feedback")]
        public string Comments { get; set; } = null!;

        // Navigation property
        public virtual CustomerRequest? CustomerRequest { get; set; }
    }
}