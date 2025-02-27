namespace GymManagementDb.Models
{
    public class Payments
    {
        public int PaymentID { get; set; }

        public int MemberID { get; set; }

        ICollection<Bookings> Bookings { get; set; }

        public decimal Amount { get; set; }

        public string Status { get; set; }

        public DateTime Payment_Date { get; set; }



    }
}
