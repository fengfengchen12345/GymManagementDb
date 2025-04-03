using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class TrainerSpecialty
    {
        [Required]
        public string SpecialtyType;

        [Key]
        public int TrainersSpecialtyID { get; set; }

        [ForeignKey("TrainerID")]
        public Trainers Trainers { get; set; }

        [Required]
        public int TrainerID { get; set; }
    }
}
