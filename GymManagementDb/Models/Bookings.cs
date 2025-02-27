namespace GymManagementDb.Models
{
    public class Bookings
    {
        public int BookingID { get; set; }

        public int MemberID { get; set; }

        public Member Member { get; set; }

        public ICollection<Workouts> Workouts { get; set; }

        public int TrainerID { get; set; }

        public TrainerID TrainerID { get; set; }
        
        public DateTime Date { get; set; }

        public decimal Duration { get; set; }

        public DateTime Time { get; set; }
    }
}
