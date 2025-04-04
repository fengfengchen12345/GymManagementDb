using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace GymManagementDb.Models
{
    public class Workouts
    {
        [Key]
        public int WorkoutID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        public string Type { get; set; }


        [Range(0,180)]
        public int Duration { get; set; }

        public ICollection<IdentityUser> AspNetUsers { get; set; }

        [Required]
        public int TrainerID { get; set; }
        [ForeignKey("TrainerID")]
        public Trainers Trainers { get; set; }


    }
}
