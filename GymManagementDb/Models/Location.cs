namespace GymManagementDb.Models
{
    public class Location
    {
    
        public int LocationID { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public decimal Postcode { get; set; }

        public string Suburb { get; set; }

        public ICollection<Member> Members { get; set; }
    }
}
