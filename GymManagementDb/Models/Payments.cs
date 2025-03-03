using System.ComponentModel.DataAnnotations;

namespace GymManagementDb.Models
{
    public class Payments
    {
        [Key]
        public int PaymentID { get; set; }

        [Required]
        public int MemberID { get; set; }

        ICollection<Bookings> Bookings { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime Payment_Date { get; set; }



    }
}
