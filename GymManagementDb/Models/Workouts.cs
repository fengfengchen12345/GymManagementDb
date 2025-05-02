using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GymManagementDb.Areas.Identity.Data;

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

        public ICollection<GymManagementDbUser> Member { get; set; }

        [ForeignKey("TrainerID")]
        public int TrainerID { get; set; }
        [ForeignKey("TrainerID")]
        public Trainers Trainers { get; set; }


    }
}
