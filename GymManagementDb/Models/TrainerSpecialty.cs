using System.ComponentModel.DataAnnotations;

namespace GymManagementDb.Models
{
    public class TrainerSpecialty
    {
        [Key]
        public int TrainersSpecialtyID { get; set; }

        
        public Trainers Trainers { get; set; }

        public int TrainerID { get; set; }
    }
}
