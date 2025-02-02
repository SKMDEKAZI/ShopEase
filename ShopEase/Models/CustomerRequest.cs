using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEase.Models
{
    public class CustomerRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Request ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Aisle reference is required")]
        [ForeignKey("Aisle")]
        [Display(Name = "Aisle Number")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid aisle reference")]
        public int AisleID { get; set; }

        [Required(ErrorMessage = "Customer reference is required")]
        [ForeignKey("Customer")]
        [Display(Name = "Customer ID")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid customer reference")]
        public int CustomerID { get; set; }

        [Display(Name = "Status")]
        public string RequestStatus { get; set; } = "Pending"; 

        [ForeignKey("Staff")]
        [Display(Name = "Assigned Staff")]
        public int? StaffID { get; set; } // Made nullable

        [Required(ErrorMessage = "Request date is required")]
        [Display(Name = "Request Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime RequestDate { get; set; } = DateTime.Now;  

        // Navigation properties
        public virtual Aisle? Aisle { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}