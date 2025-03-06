using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class Bookings
    {
        [Key]

        public int BookingID { get; set; }

        [Required(ErrorMessage = "Member ID is required.")]
        public int MemberID { get; set; }

        [Required]
        public Member Member { get; set; }

        public ICollection<Workouts> Workouts { get; set; }

        [Required(ErrorMessage = "Trainer ID is required.")]
        public int TrainerID { get; set; }

        [ForeignKey("TrainerID")]
        public Trainers Trainers { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required.")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

    
        [DataType(DataType.Duration)]
        [Required(ErrorMessage = "Duration is required.")]
        [Range(0.1, 24, ErrorMessage = "Duration must be between 0.1 and 24 hours.")]
        public int Duration { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Time is required.")]
        public DateTime Time { get; set; }


        [Required(ErrorMessage = "Status is required."), MaxLength(20)]
        [StringLength(20, ErrorMessage = "Status cannot exceed 20 characters.")]
        [RegularExpression(@"^(Pending|Confirmed|Cancelled)$", ErrorMessage = "Status must be either 'Pending', 'Confirmed', or 'Cancelled'.")]
        public string Status { get; set; }
    }
}
