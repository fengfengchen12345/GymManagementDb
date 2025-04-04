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
        
        [Required]
        public ICollection<Workouts> Workouts { get; set; }

        [Required]
        public required ICollection<TrainerSpecialty> TrainerSpecialty { get; set; }
        public int TrainerSpecialtyID { get; internal set; }
    }
}

