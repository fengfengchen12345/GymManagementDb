using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GymManagementDb.Models;
using Microsoft.AspNetCore.Identity;
namespace GymManagementDb.Areas.Identity.Data
{
    public class GymManagementDbUser : IdentityUser
    {
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100)]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(100)]
        public string Last_Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Join_Date { get; set; }
        [Required]
        public int MembershipTpyeID { get; set; }
        [ForeignKey("MembershipTpyeID")]
        public MembershipType MemberShipType { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(150)]
        public override string Email { get; set; }
        [Required]
        [Phone]
        [StringLength(15)]
        public string Phone_Number { get; set; }
        [Required]
        public int WorkoutID { get; set; }
        [ForeignKey("WorkoutID")]
        public Workouts Workouts { get; set; }
    }
}