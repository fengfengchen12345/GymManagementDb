using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Join_Date { get; set; }


        [ForeignKey("LocationID")]
        public Location Location { get; set; }

        [ForeignKey("MembershipTpyeID")]
        public MembershipType MemberShipType { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone_Number { get; set; }

        
        public ICollection<Workouts> Workouts { get; set; }


        public ICollection<Payments> Payments { get; set; }


    }
}
