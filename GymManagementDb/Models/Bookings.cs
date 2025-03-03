using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class Bookings
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public int MemberID { get; set; }

        [Required]
        public Member Member { get; set; }

        public ICollection<Workouts> Workouts { get; set; }

        [Required]
        public int TrainerID { get; set; }

        [ForeignKey("TrainerID")]
        public Trainers Trainers { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Duration)]
        public decimal Duration { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime Time { get; set; }

        [ForeignKey("PaymentID")]
        public Payments Payments { get; set; }

        [Required]
        public int PaymentID { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
