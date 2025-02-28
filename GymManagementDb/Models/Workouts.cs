namespace GymManagementDb.Models
{
    public class Workouts
    {
        public int WorkoutID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Duration { get; set; }

        public ICollection<Member> { get; set; }

        public Bookings Bookings { get; set; }

        public int BookingID { get; set; }
    }
}
