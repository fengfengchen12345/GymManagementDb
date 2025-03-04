using System.ComponentModel.DataAnnotations;

namespace GymManagementDb.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }


        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(100, ErrorMessage = "City cannot exceed 100 characters.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Postcode is required.")]
        [DataType(DataType.PostalCode)]

        public int Postcode { get; set; }

        [Required(ErrorMessage = "Suburb is required.")]
        [StringLength(100, ErrorMessage = "Suburb cannot exceed 100 characters.")]
        public string Suburb { get; set; }

        
        public ICollection<Member> Members { get; set; }
    }
}
