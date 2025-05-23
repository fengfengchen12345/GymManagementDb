﻿using System.ComponentModel.DataAnnotations;
using GymManagementDb.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace GymManagementDb.Models
{
    public class MembershipType
    {
        [Key]
        public int MembershipTypeID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required]
        public int Cost { get; set; }

        [Required]
        [Range(0,180)]
        public int Duration { get; set; }
        public ICollection<GymManagementDbUser> Member { get; set; }

        

    }
}
