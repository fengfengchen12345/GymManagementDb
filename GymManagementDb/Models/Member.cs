using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymManagementDb.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "First name cannot exceed 100 characters.")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100, ErrorMessage = "Last name cannot exceed 100 characters.")]
        public string Last_Name { get; set; }


        [Required(ErrorMessage = "Join Date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Join_Date { get; set; }


        [Required(ErrorMessage = "Membership Type is required.")]
        [ForeignKey("MembershipTpyeID")]
        public MembershipType MemberShipType { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(150, ErrorMessage = "Email cannot exceed 150 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string Phone_Number { get; set; }

        public Workouts Workouts { get; set; }
        [ForeignKey("WorkoutID")]
        public int WorkoutID { get; set; }


    }
}
