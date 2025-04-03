using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GymManagementDb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GymManagementDb.Areas.Identity.Data;

// Add profile data for application users by adding properties to the GymManagementDbUser class
public class GymManagementDbUser : IdentityUser


{
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
    public int MembershipTpyeID { get; set; }
    public MembershipType MemberShipType { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [StringLength(150, ErrorMessage = "Email cannot exceed 150 characters.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    [Phone(ErrorMessage = "Invalid phone number format.")]
    [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
    public string Phone_Number { get; set; }

    [ForeignKey("WorkoutID")]
    public Workouts Workouts { get; set; }
    [ForeignKey("WorkoutID")]
    public int WorkoutID { get; set; }

}

