namespace GymManagementDb.Models
{
    public class Workouts
    {
        public int WorkoutID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public decimal Duration { get; set; }

        public Member Member { get; set; }
    }
}
