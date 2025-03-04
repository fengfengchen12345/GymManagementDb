using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class Workouts
    {
        [Key]
        public int WorkoutID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        public string Type { get; set; }


        [Range(0,180)]
        public int Duration { get; set; }

        public ICollection<Member> Member { get; set; }

        [ForeignKey("BookingID")]
        public Bookings Bookings { get; set; }


        [Required]
        public int BookingID { get; set; }
    }
}
