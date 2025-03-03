using System.ComponentModel.DataAnnotations;

namespace GymManagementDb.Models
{
    public class MembershipType
    {
        [Key]
        public int MembershipTypeID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [DataType(DataType.Duration)]
        public decimal Duration { get; set; }


        public ICollection<Member> Members { get; set; }
    }
}
