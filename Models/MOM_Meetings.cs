using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MOM_Meetings
    {
        [Key]
        public int MeetingID { get; set; }

        [Required(ErrorMessage = "Meeting date is required")]
        [DataType(DataType.DateTime)]
        public DateTime MeetingDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid venue")]
        public int MeetingVenueID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid meeting type")]
        public int MeetingTypeID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid department")]
        public int DepartmentID { get; set; }

        [MaxLength(255)]

        public string? MeetingDescription { get; set; }

        [MaxLength(255)]
        public string? DocumentPath { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }

        public bool? IsCancelled { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CancellationDateTime { get; set; }

        [MaxLength(255)]
        public string? CancellationReason { get; set; }
    }

}
