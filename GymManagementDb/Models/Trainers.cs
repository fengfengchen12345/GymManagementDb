using System.ComponentModel.DataAnnotations;

namespace GymManagementDb.Models
{
    public class Trainers
    {
        [Key]
        public int TrainerID { get; set; }


        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(0, 50)]
        public decimal YearsOfExperience { get; set; }

        public ICollection<Member> Members { get; set; }


        public ICollection<Bookings> Bookings { get; set; }


        public ICollection<TrainerSpecialty> TrainerSpecialty { get; set; }
    }
}

