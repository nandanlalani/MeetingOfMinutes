using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MOM_MeetingType
    {
        [Key]
        public int MeetingTypeID { get; set; }

        [Required(ErrorMessage = "Meeting type name is required")]
        [MinLength(2, ErrorMessage = "Meeting type name must be at least 2 characters")]
        [MaxLength(100, ErrorMessage = "Meeting type name cannot exceed 100 characters")]
        public string MeetingTypeName { get; set; }

        [MaxLength(100, ErrorMessage = "Remarks cannot exceed 100 characters")]
        public string Remarks { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }
    }
}
