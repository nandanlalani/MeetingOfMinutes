using System.ComponentModel.DataAnnotations;

namespace MOM.Models
{
    public class MOM_MeetingVenue
    {
        [Key]
        public int MeetingVenueID { get; set; }

        [Required(ErrorMessage = "Venue name is required")]
        [MinLength(2, ErrorMessage = "Venue name must be at least 2 characters")]
        [MaxLength(100, ErrorMessage = "Venue name cannot exceed 100 characters")]
        public string MeetingVenueName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }
    }

}
