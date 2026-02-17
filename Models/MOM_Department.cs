using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MOM_Department
    {
        [Key]
        public int DepartmentID { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [MinLength(2, ErrorMessage = "Department name must be at least 2 characters")]
        [MaxLength(100, ErrorMessage = "Department name cannot exceed 100 characters")]
        public string DepartmentName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }

        [MaxLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? DepartmentDescription { get; set; }
    }
}
