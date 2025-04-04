using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class TrainerSpecialty
    {
        [Required(ErrorMessage = "SpecialtyType is required")]
        public string SpecialtyType { get; set; } 

        [Key]
        public int TrainersSpecialtyID { get; set; }

        [ForeignKey("TrainerID")]
        public int TrainerID { get; set; }
        [ForeignKey("TrainerID")]
        public Trainers Trainers { get; set; }
    }
}
