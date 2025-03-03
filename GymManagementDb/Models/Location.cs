using System.ComponentModel.DataAnnotations;

namespace GymManagementDb.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        [DataType(DataType.PostalCode)]
        public decimal Postcode { get; set; }

        [Required]
        public string Suburb { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
