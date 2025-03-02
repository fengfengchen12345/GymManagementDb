namespace GymManagementDb.Models
{
    public class Trainers
    {

        public int TrainerID { get; set; }

        public string Name { get; set; }

        public decimal YearsOfExperience { get; set; }

        public ICollection<Member> Members { get; set; }

        public ICollection<Bookings> Bookings { get; set; }

        public ICollection<TrainerSpecialty> TrainerSpecialty { get; set; }
    }
}

