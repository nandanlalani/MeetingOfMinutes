using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MOM_Staff
    {
        [Key]
        public int StaffID { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid department")]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Staff name is required")]
        [MinLength(2, ErrorMessage = "Staff name must be at least 2 characters")]
        [MaxLength(100, ErrorMessage = "Staff name cannot exceed 100 characters")]
        public string StaffName { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[\d\s\-\+\(\)]{10,15}$", ErrorMessage = "Enter a valid mobile number (10-15 digits)")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format")]
        public string EmailAddress { get; set; }

        [MaxLength(250, ErrorMessage = "Remarks cannot exceed 250 characters")]
        public string? Remarks { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }
    }


}
