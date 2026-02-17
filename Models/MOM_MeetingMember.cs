using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MOM_MeetingMember
    {
        [Key]
        public int MeetingMemberID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Meeting is required")]
        public int MeetingID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Staff member is required")]
        public int StaffID { get; set; }

        public bool IsPresent { get; set; }

        [MaxLength(500, ErrorMessage = "Remarks cannot exceed 500 characters")]
        public string? Remarks { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }
    }

}
